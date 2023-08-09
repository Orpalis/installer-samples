//#define USE_JSON_MODEL //Not recommended. Here for pedagogical purpose.

using System;
using GdPicture14;
using System.Collections.Generic;
using static GdPicture14.GdPicturePDF;

#if USE_JSON_MODEL
using Newtonsoft.Json;
#endif


namespace GdPicture.OCR.Plugins
{
    public class GdPictureTesseract
    {
        private static object m_locker = new object();
        private static List<GdPictureTesseract> m_instances = new List<GdPictureTesseract>();
        GdPicturePDF m_nativePDF;


        public static void AttachPlugin(GdPicturePDF pdf)
        {
            lock (m_locker)
            {
                GdPictureTesseract instance = new GdPictureTesseract(pdf);
                m_instances.Add(instance);
            }
        }


        public static void DetachPlugin(GdPicturePDF pdf)
        {
            lock (m_locker)
            {
                foreach (GdPictureTesseract instance in m_instances)
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


        private GdPictureTesseract(GdPicturePDF pdf)
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
#if USE_JSON_MODEL
            m_nativePDF.ExternalOcrPageRequest -= this.ExternalOcrRequestJson;
#else
            m_nativePDF.ExternalOcrPageRequest -= this.ExternalOcrRequestGdPictureOCRJson;
#endif
        }


        private void Close()
        {
            m_nativePDF.SetOverrideOcrEngine(false);
#if USE_JSON_MODEL
#else
            m_nativePDF.ExternalOcrPageRequest -= this.ExternalOcrRequestGdPictureOCRJson;
#endif
            m_nativePDF = null;
        }

#if USE_JSON_MODEL
        private void ExternalOcrRequestJson(int ImageID, PdfOcrOptions PdfOcrOptions, out GdPictureStatus Status, out string ResultEncoding, out string OcrResult)
        {
            using (GdPictureOCR gdpictureOCR = new GdPictureOCR())
            {
                gdpictureOCR.ResourceFolder = PdfOcrOptions.ResourcePath;
                gdpictureOCR.AddCustomDictionary(PdfOcrOptions.Dictionary);
                gdpictureOCR.OCRMode = PdfOcrOptions.OCRMode;
                gdpictureOCR.EnableOrientationDetection = PdfOcrOptions.DetectOrientation;
                gdpictureOCR.EnableSkewDetection = PdfOcrOptions.DetectSkew;
                gdpictureOCR.EnablePreprocessing = PdfOcrOptions.EnableProprocessing;
                gdpictureOCR.SetImage(ImageID);

                string resultID = gdpictureOCR.RunOCR();

                Status = gdpictureOCR.GetStat();

                if (Status == GdPictureStatus.OK)
                {
                    GdPictureOcrResult ocrResult = new GdPictureOcrResult()
                    {
                        Paragraphs = new List<GdPictureOcrParagraph>(),
                        PageRotation = gdpictureOCR.GetPageRotation(resultID),
                        PageSkewAngle = gdpictureOCR.GetPageSkewAngle(resultID)
                    };

                    for (int paragraphIdx = 0; paragraphIdx < gdpictureOCR.GetParagraphCount(resultID); paragraphIdx++)
                    {

                        int paragraphRotate;
                        OCRBlockOrientation blockOrientation = gdpictureOCR.GetBlockOrientation(resultID, gdpictureOCR.GetParagraphBlockIndex(resultID, paragraphIdx));

                        switch (blockOrientation)
                        {
                            case OCRBlockOrientation.Left:
                                paragraphRotate = 270;
                                break;
                            case OCRBlockOrientation.Right:
                                paragraphRotate = 90;
                                break;
                            case OCRBlockOrientation.Down:
                                paragraphRotate = 180;
                                break;

                            default:
                                paragraphRotate = 0;
                                break;
                        }

                        OCRBlockType blockType = gdpictureOCR.GetBlockType(resultID, gdpictureOCR.GetParagraphBlockIndex(resultID, paragraphIdx));
                        //rejecting non text block.
                        if (blockType != OCRBlockType.CaptionText &&
                            blockType != OCRBlockType.FlowingText &&
                            blockType != OCRBlockType.HeadingText &&
                            blockType != OCRBlockType.PulloutText &&
                            blockType != OCRBlockType.VerticalText &&
                            blockType != OCRBlockType.Table)
                        {
                            continue;
                        }

                        GdPictureOcrParagraph paragraph = new GdPictureOcrParagraph()
                        {
                            Lines = new List<GdPictureOcrLine>(),
                            ParagraphRotation = paragraphRotate,
                            TextWritingDirection = (int)gdpictureOCR.GetBlockWritingDirection(resultID, gdpictureOCR.GetParagraphBlockIndex(resultID, paragraphIdx))
                        };

                        ((List<GdPictureOcrParagraph>)ocrResult.Paragraphs).Add(paragraph);
                        int firstLineIdx = gdpictureOCR.GetParagraphFirstTextLineIndex(resultID, paragraphIdx);
                        int lineCount = gdpictureOCR.GetParagraphTextLineCount(resultID, paragraphIdx);

                        for (int lineIdx = firstLineIdx; lineIdx < firstLineIdx + lineCount; lineIdx++)
                        {
                            GdPictureOcrLine line = new GdPictureOcrLine()
                            {
                                Words = new List<GdPictureOcrWord>()
                            };

                            ((List<GdPictureOcrLine>)paragraph.Lines).Add(line);
                            int firstWordIdx = gdpictureOCR.GetTextLineFirstWordIndex(resultID, lineIdx);
                            int wordCount = gdpictureOCR.GetTextLineWordCount(resultID, lineIdx);

                            for (int wordIdx = firstWordIdx; wordIdx < firstWordIdx + wordCount; wordIdx++)
                            {
                                int wordLeft = gdpictureOCR.GetWordLeft(resultID, wordIdx);
                                int wordTop = gdpictureOCR.GetWordTop(resultID, wordIdx);
                                int wordRight = gdpictureOCR.GetWordRight(resultID, wordIdx);
                                int wordBottom = gdpictureOCR.GetWordBottom(resultID, wordIdx);

                                GdPictureOcrWord word = new GdPictureOcrWord()
                                {
                                    BBox = new GdPictureOcrRect(wordLeft, wordTop, wordRight, wordBottom),
                                    Characters = new List<GdPictureOcrCharacter>()
                                };

                                ((List<GdPictureOcrWord>)line.Words).Add(word);
                                int firstCharacterIdx = gdpictureOCR.GetWordFirstCharacterIndex(resultID, wordIdx);
                                int characterCount = gdpictureOCR.GetWordCharacterCount(resultID, wordIdx);

                                for (int characterIdx = firstCharacterIdx; characterIdx < firstCharacterIdx + characterCount; characterIdx++)
                                {
                                    int characterLeft = gdpictureOCR.GetCharacterLeft(resultID, characterIdx);
                                    int characterTop = gdpictureOCR.GetCharacterTop(resultID, characterIdx);
                                    int characterRight = gdpictureOCR.GetCharacterRight(resultID, characterIdx);
                                    int characterBottom = gdpictureOCR.GetCharacterBottom(resultID, characterIdx);
                                    GdPictureOcrCharacter character = new GdPictureOcrCharacter()
                                    {
                                        BBox = new GdPictureOcrRect(characterLeft, characterTop, characterRight, characterBottom),
                                        Value = gdpictureOCR.GetCharacterValue(resultID, characterIdx)
                                    };
                                    ((List<GdPictureOcrCharacter>)word.Characters).Add(character);
                                }
                            }
                        }
                    }
                    ResultEncoding = "json";
                    OcrResult = JsonConvert.SerializeObject(ocrResult);
                }
                else
                {
                    ResultEncoding = OcrResult = null;
                }
            }
        }
#else
        private void ExternalOcrRequestGdPictureOCRJson(int ImageID, PdfOcrOptions PdfOcrOptions, out GdPictureStatus Status, out string ResultEncoding, out string OcrResult)
        {
            using (GdPictureOCR gdpictureOCR = new GdPictureOCR())
            {
                gdpictureOCR.ResourceFolder = PdfOcrOptions.ResourcePath;
                gdpictureOCR.AddCustomDictionary(PdfOcrOptions.Dictionary);
                gdpictureOCR.OCRMode = PdfOcrOptions.OCRMode;
                gdpictureOCR.EnableOrientationDetection = PdfOcrOptions.DetectOrientation;
                gdpictureOCR.EnableSkewDetection = PdfOcrOptions.DetectSkew;
                gdpictureOCR.SetImage(ImageID);

                string resultID = gdpictureOCR.RunOCR();

                Status = gdpictureOCR.GetStat();

                if (Status == GdPictureStatus.OK)
                {
                    ResultEncoding = "gdpictureocr-json";
                    OcrResult = gdpictureOCR.GetSerializedResult(resultID);
                    Status = gdpictureOCR.GetStat();
                }
                else
                {
                    ResultEncoding = OcrResult = null;
                }
            }
        }

#endif
    }
}