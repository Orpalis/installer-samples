#if USE_OMNIPAGE_OCR
/*
 This connector has been created using OmniPage Capture SDK 21.0.
 You will need to add reference to the following assemblies: 
   - Kofax.OmniPageCSDK.ArgTypes.dll
   - Kofax.OmniPageCSDK.Objects.dll
 */

using System;
using GdPicture14;
using Newtonsoft.Json;
using Kofax.OmniPageCSDK.ArgTypes;
using Kofax.OmniPageCSDK.Objects;
using System.Collections.Generic;
using static GdPicture14.GdPicturePDF;
using System.IO;


namespace GdPicture.OCR.Plugins
{
    public class OmniPage
    {
        private static object m_locker = new object();
        private static List<OmniPage> m_instances = new List<OmniPage>();
        GdPicturePDF m_nativePDF;


        public static void AttachPlugin(GdPicturePDF pdf)
        {
            lock (m_locker)
            {
                OmniPage instance = new OmniPage(pdf);
                m_instances.Add(instance);
            }
        }


        public static void DetachPlugin(GdPicturePDF pdf)
        {
            lock (m_locker)
            {
                foreach (OmniPage instance in m_instances)
                {
                    if (instance.m_nativePDF == pdf)
                    {
                        instance.Close();
                        m_instances.Remove(instance);

                        return;
                    }
                }
            }
        }


        private OmniPage(GdPicturePDF pdf)
        {
            if (pdf == null)
            {
                throw new ArgumentNullException(nameof(pdf));
            }

            if (pdf.GetOverrideOcrEngine())
            {
                throw new InvalidOperationException("The GdPicturePDF object is already attached to another OCR engine");
            }

            m_nativePDF = pdf;
            m_nativePDF.SetOverrideOcrEngine(true);
            m_nativePDF.ExternalOcrPageRequest += this.ExternalOcrRequest;
        }


        private void Close()
        {
            m_nativePDF.SetOverrideOcrEngine(false);
            m_nativePDF.ExternalOcrPageRequest -= this.ExternalOcrRequest;
            m_nativePDF = null;
        }


        private void ExternalOcrRequest(int ImageID, PdfOcrOptions PdfOcrOptions, out GdPictureStatus Status, out string ResultEncoding, out string OcrResult)
        {
            ResultEncoding = "json";
            OcrResult = "";

            string imageData = Path.GetTempFileName(); //using temporary file to transfer image data. We may be able to use System.Drawing.Bitmap instead.

            try
            {
                using (GdPictureImaging gdpictureImaging = new GdPictureImaging())
                {
                    Status = gdpictureImaging.SaveAsTIFF(ImageID, imageData, TiffCompression.TiffCompressionAUTO);

                    if (Status == GdPictureStatus.OK)
                    {
                        Engine.Init(null, null);// use your company and product name here to make Kofax happy!

                        using (SettingCollection settings = new SettingCollection())
                        {
                            if (PdfOcrOptions.DetectOrientation)
                            {
                                settings.ImageRotation = IMG_ROTATE.ROT_AUTO;
                            }
                            else
                            {
                                settings.ImageRotation = IMG_ROTATE.ROT_NO;
                            }

                            if (PdfOcrOptions.DetectSkew)
                            {
                                settings.ImageDeskew = IMG_DESKEW.DSK_AUTO;
                            }
                            else
                            {
                                settings.ImageDeskew = IMG_DESKEW.DSK_NO;
                            }

                            settings.Languages.Current = GetLanguages(PdfOcrOptions);

                            using (Page page = new Page(imageData, 0, settings))
                            {
                                page.Preprocess();
                                page.Recognize();

                                LETTER[] letters = page[IMAGEINDEX.II_ORIGINAL].GetLetters();
                                int letterCount = letters.Length;

                                if (letterCount > 0)
                                {
                                    GdPictureOcrWord currentWord = new GdPictureOcrWord()
                                    {
                                        Characters = new List<GdPictureOcrCharacter>()
                                    };

                                    GdPictureOcrLine currentLine = new GdPictureOcrLine()
                                    {
                                        Words = new List<GdPictureOcrWord>(new GdPictureOcrWord[] { currentWord })
                                    };

                                    GdPictureOcrParagraph currentParagraph = new GdPictureOcrParagraph()
                                    {
                                        Lines = new List<GdPictureOcrLine>(new GdPictureOcrLine[] { currentLine })
                                    };

                                    int pageRotate = 0;

                                    switch (page.PreprocessInfo.Rotation)
                                    {
                                        case IMG_ROTATE.ROT_LEFT:
                                            pageRotate = 90;
                                            break;
                                        case IMG_ROTATE.ROT_RIGHT:
                                            pageRotate = 270;
                                            break;
                                        case IMG_ROTATE.ROT_DOWN:
                                            pageRotate = 180;
                                            break;
                                    }

                                    float pageSkewAngle = page.PreprocessInfo.Slope / 18F;

                                    GdPictureOcrResult ocrResult = new GdPictureOcrResult()
                                    {
                                        Paragraphs = new List<GdPictureOcrParagraph>(new GdPictureOcrParagraph[] { currentParagraph }),
                                        PageRotation = pageRotate,
                                        PageSkewAngle = pageSkewAngle
                                    };

                                    int letterNumber = 0;
                                    int prevParagraphRotate = 0;

                                    foreach (LETTER letter in letters)
                                    {
                                        letterNumber++;

                                        bool isLast = letterNumber == letterCount;
                                        int paragraphRotate;

                                        if (letter.makeup.HasFlag(MAKEUP.R_RIGHTTEXT))
                                        {
                                            paragraphRotate = 90;
                                        }
                                        else if (letter.makeup.HasFlag(MAKEUP.R_LEFTTEXT))
                                        {
                                            paragraphRotate = 270;
                                        }
                                        else
                                        {
                                            paragraphRotate = 0;
                                        }

                                        int textWritingDirection = 0; //todo urgent: add support for rtl and top to bottom.

                                        if (letterNumber == 1)
                                        {
                                            currentParagraph.ParagraphRotation = paragraphRotate;
                                            currentParagraph.TextWritingDirection = textWritingDirection;
                                            prevParagraphRotate = paragraphRotate;
                                        }

                                        GdPictureOcrCharacter currentCharacter = new GdPictureOcrCharacter()
                                        {
                                            BBox = new GdPictureOcrRect(letter.left, letter.top, letter.left + letter.width, letter.top + letter.height),
                                            Value = letter.code
                                        };

                                        ((List<GdPictureOcrCharacter>)currentWord.Characters).Add(currentCharacter);

                                        if (letter.makeup.HasFlag(MAKEUP.R_ENDOFPARA) ||
                                            prevParagraphRotate != paragraphRotate)
                                        {//starting new paragraph
                                            if (!isLast)
                                            {
                                                currentWord = new GdPictureOcrWord()
                                                {
                                                    Characters = new List<GdPictureOcrCharacter>()
                                                };

                                                currentLine = new GdPictureOcrLine()
                                                {
                                                    Words = new List<GdPictureOcrWord>(new GdPictureOcrWord[] { currentWord })
                                                };

                                                currentParagraph = new GdPictureOcrParagraph()
                                                {
                                                    ParagraphRotation = paragraphRotate,
                                                    TextWritingDirection = textWritingDirection,
                                                    Lines = new List<GdPictureOcrLine>(new GdPictureOcrLine[] { currentLine })
                                                };

                                                ((List<GdPictureOcrParagraph>)ocrResult.Paragraphs).Add(currentParagraph);
                                            }
                                        }
                                        else if (letter.makeup.HasFlag(MAKEUP.R_ENDOFLINE))
                                        {//starting new line
                                            currentWord = new GdPictureOcrWord()
                                            {
                                                Characters = new List<GdPictureOcrCharacter>()
                                            };

                                            currentLine = new GdPictureOcrLine()
                                            {
                                                Words = new List<GdPictureOcrWord>(new GdPictureOcrWord[] { currentWord })
                                            };

                                            ((List<GdPictureOcrLine>)currentParagraph.Lines).Add(currentLine);
                                        }
                                        else if (letter.makeup.HasFlag(MAKEUP.R_ENDOFWORD))
                                        {//starting new word.
                                            currentWord = new GdPictureOcrWord()
                                            {
                                                Characters = new List<GdPictureOcrCharacter>()
                                            };

                                            ((List<GdPictureOcrWord>)currentLine.Words).Add(currentWord);
                                        }

                                        prevParagraphRotate = paragraphRotate;
                                    }

                                    OcrResult = JsonConvert.SerializeObject(ocrResult);
                                }
                            }
                        }
                    }
                }
            }
            catch (OutOfMemoryException)
            {
                Status = GdPictureStatus.OutOfMemory;
            }
            catch
            {
                Status = GdPictureStatus.GenericError;
            }
            finally
            {
                File.Delete(imageData);
            }
        }


        private LANGUAGES[] GetLanguages(PdfOcrOptions PdfOcrOptions)
        {
            string[] dictionaries = PdfOcrOptions.Dictionary.Split('+');

            if (dictionaries != null && dictionaries.Length > 0)
            {
                List<LANGUAGES> languages = new List<LANGUAGES>(dictionaries.Length);

                foreach (string dictionary in dictionaries)
                {
                    switch (dictionary)
                    {
                        case "fra":
                            languages.Add(LANGUAGES.LANG_FRE);
                            break;

                        case "eng":
                            languages.Add(LANGUAGES.LANG_ENG);
                            break;

                        case "deu":
                            languages.Add(LANGUAGES.LANG_DUT);
                            break;

                        case "por":
                            languages.Add(LANGUAGES.LANG_POR);
                            break;

                        case "spa":
                            languages.Add(LANGUAGES.LANG_SPA);
                            break;

                        case "jpn":
                            languages.Add(LANGUAGES.LANG_JPN);
                            break;
                            //todo: continue, I can't do that...
                    }
                }

                return languages.ToArray();
            }

            return null;
        }
    }
}
#endif