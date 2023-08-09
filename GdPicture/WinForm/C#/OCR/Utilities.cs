using System.Collections.Generic;
using System.Drawing;
using System.Text;
using GdPicture14;

namespace Ocr
{
    /// <summary>
    /// The Utilities class offers a couple of utilities to the sample application.
    /// </summary>
    class Utilities
    {
        /// <summary>
        /// MarkRegions marks the requested elements within the viewer.
        /// </summary>
        /// <param name="gdViewer">The viewer.</param>
        /// <param name="blocks">The boxes for the blocks.</param>
        /// <param name="paragraphs">The boxes for the paragraphs.</param>
        /// <param name="textLines">The boxes for the text lines.</param>
        /// <param name="words">The boxes for the words.</param>
        /// <param name="characters">The boxes for the characters.</param>
        /// <param name="horizontalResolution">The horizontal resolution of the image.</param>
        /// <param name="verticalResolution">The vertical resolution of the image.</param>
        public static void MarkRegions(GdViewer gdViewer, Rectangle[] blocks, Rectangle[] paragraphs,
            Rectangle[] textLines, Rectangle[] words, Rectangle[] characters, float horizontalResolution,
            float verticalResolution)
        {
            gdViewer.RemoveAllRegions();

            if (blocks != null)
            {
                AddRegions(gdViewer, blocks, BlockColor, horizontalResolution, verticalResolution);
            }

            if (paragraphs != null)
            {
                AddRegions(gdViewer, paragraphs, ParagraphColor, horizontalResolution, verticalResolution);
            }

            if (textLines != null)
            {
                AddRegions(gdViewer, textLines, TextLineColor, horizontalResolution, verticalResolution);
            }

            if (words != null)
            {
                AddRegions(gdViewer, words, WordColor, horizontalResolution, verticalResolution);
            }

            if (characters != null)
            {
                AddRegions(gdViewer, characters, CharacterColor, horizontalResolution, verticalResolution);
            }
        }

        /// <summary>
        /// GetBlocksBoundingBoxes retrieves the bounding boxes for the blocks.
        /// </summary>
        /// <param name="ocrResultId">The ocr result identifier.</param>
        /// <param name="gdPictureOcr">The GdPictureOcr.</param>
        /// <returns>An array with the bounding boxes.</returns>
        public static Rectangle[] GetBlocksBoundingBoxes(string ocrResultId, GdPictureOCR gdPictureOcr)
        {
            List<Rectangle> rectanglesList = new List<Rectangle>();
            int blocksCount = gdPictureOcr.GetBlockCount(ocrResultId);
            for (int blockIndex = 0; blockIndex < blocksCount; blockIndex++)
            {
                rectanglesList.Add(new Rectangle(gdPictureOcr.GetBlockLeft(ocrResultId, blockIndex),
                    gdPictureOcr.GetBlockTop(ocrResultId, blockIndex),
                    gdPictureOcr.GetBlockRight(ocrResultId, blockIndex) -
                    gdPictureOcr.GetBlockLeft(ocrResultId, blockIndex),
                    gdPictureOcr.GetBlockBottom(ocrResultId, blockIndex) -
                    gdPictureOcr.GetBlockTop(ocrResultId, blockIndex)));
            }

            return rectanglesList.ToArray();
        }

        /// <summary>
        /// GetParagraphsBoundingBoxes retrieves the bounding boxes for the paragraphs.
        /// </summary>
        /// <param name="ocrResultId">The ocr result identifier.</param>
        /// <param name="gdPictureOcr">The GdPictureOcr.</param>
        /// <returns>An array with the bounding boxes.</returns>
        public static Rectangle[] GetParagraphsBoundingBoxes(string ocrResultId, GdPictureOCR gdPictureOcr)
        {
            List<Rectangle> rectanglesList = new List<Rectangle>();
            int paragraphCount = gdPictureOcr.GetParagraphCount(ocrResultId);
            for (int paragraphsIndex = 0; paragraphsIndex < paragraphCount; paragraphsIndex++)
            {
                rectanglesList.Add(new Rectangle(gdPictureOcr.GetParagraphLeft(ocrResultId, paragraphsIndex),
                    gdPictureOcr.GetParagraphTop(ocrResultId, paragraphsIndex),
                    gdPictureOcr.GetParagraphRight(ocrResultId, paragraphsIndex) -
                    gdPictureOcr.GetParagraphLeft(ocrResultId, paragraphsIndex),
                    gdPictureOcr.GetParagraphBottom(ocrResultId, paragraphsIndex) -
                    gdPictureOcr.GetParagraphTop(ocrResultId, paragraphsIndex)));
            }

            return rectanglesList.ToArray();
        }

        /// <summary>
        /// GetTextLinesBoundingBoxes retrieves the bounding boxes for the text lines.
        /// </summary>
        /// <param name="ocrResultId">The ocr result identifier.</param>
        /// <param name="gdPictureOcr">The GdPictureOcr.</param>
        /// <returns>An array with the bounding boxes.</returns>
        public static Rectangle[] GetTextLinesBoundingBoxes(string ocrResultId, GdPictureOCR gdPictureOcr)
        {
            List<Rectangle> rectanglesList = new List<Rectangle>();
            int textLineCount = gdPictureOcr.GetTextLineCount(ocrResultId);
            for (int textLinesIndex = 0; textLinesIndex < textLineCount; textLinesIndex++)
            {
                rectanglesList.Add(new Rectangle(gdPictureOcr.GetTextLineLeft(ocrResultId, textLinesIndex),
                    gdPictureOcr.GetTextLineTop(ocrResultId, textLinesIndex),
                    gdPictureOcr.GetTextLineRight(ocrResultId, textLinesIndex) -
                    gdPictureOcr.GetTextLineLeft(ocrResultId, textLinesIndex),
                    gdPictureOcr.GetTextLineBottom(ocrResultId, textLinesIndex) -
                    gdPictureOcr.GetTextLineTop(ocrResultId, textLinesIndex)));
            }

            return rectanglesList.ToArray();
        }

        /// <summary>
        /// GetWordsBoundingBoxes retrieves the bounding boxes for the words.
        /// </summary>
        /// <param name="ocrResultId">The ocr result identifier.</param>
        /// <param name="gdPictureOcr">The GdPictureOcr.</param>
        /// <returns>An array with the bounding boxes.</returns>
        public static Rectangle[] GetWordsBoundingBoxes(string ocrResultId, GdPictureOCR gdPictureOcr)
        {
            List<Rectangle> rectanglesList = new List<Rectangle>();
            int wordCount = gdPictureOcr.GetWordCount(ocrResultId);
            for (int wordIndex = 0; wordIndex < wordCount; wordIndex++)
            {
                rectanglesList.Add(new Rectangle(gdPictureOcr.GetWordLeft(ocrResultId, wordIndex),
                    gdPictureOcr.GetWordTop(ocrResultId, wordIndex),
                    gdPictureOcr.GetWordRight(ocrResultId, wordIndex) -
                    gdPictureOcr.GetWordLeft(ocrResultId, wordIndex),
                    gdPictureOcr.GetWordBottom(ocrResultId, wordIndex) -
                    gdPictureOcr.GetWordTop(ocrResultId, wordIndex)));
            }

            return rectanglesList.ToArray();
        }

        /// <summary>
        /// GetCharactersBoundingBoxes retrieves the bounding boxes for the characters.
        /// This version demonstrates how to associate blocks, paragraphes, text lines and symbols.
        /// </summary>
        /// <param name="ocrResultId">The ocr result identifier.</param>
        /// <param name="gdPictureOcr">The GdPictureOcr.</param>
        /// <returns>An array with the bounding boxes.</returns>
        public static Rectangle[] GetCharactersBoundingBoxes(string ocrResultId, GdPictureOCR gdPictureOcr)
        {
            List<Rectangle> rectanglesList = new List<Rectangle>();
            int blocksCount = gdPictureOcr.GetBlockCount(ocrResultId);
            int paragaphIndexGlobal = 0;
            int textLineIndexGlobal = 0;
            int wordIndexGlobal = 0;
            int characterIndexGlobal = 0;
            for (int blockIndex = 0; blockIndex < blocksCount; blockIndex++)
            {
                int paragaphsCount = gdPictureOcr.GetBlockParagraphCount(ocrResultId, blockIndex);
                for (int paragaphIndex = 0; paragaphIndex < paragaphsCount; paragaphIndex++)
                {
                    int textLinesCount = gdPictureOcr.GetParagraphTextLineCount(ocrResultId, paragaphIndexGlobal);
                    for (int textLineIndex = 0; textLineIndex < textLinesCount; textLineIndex++)
                    {
                        int wordsCount = gdPictureOcr.GetTextLineWordCount(ocrResultId, textLineIndexGlobal);
                        for (int wordIndex = 0; wordIndex < wordsCount; wordIndex++)
                        {
                            int charactersCount = gdPictureOcr.GetWordCharacterCount(ocrResultId, wordIndexGlobal);
                            for (int characterIndex = 0; characterIndex < charactersCount; characterIndex++)
                            {
                                rectanglesList.Add(new Rectangle(
                                    gdPictureOcr.GetCharacterLeft(ocrResultId, characterIndexGlobal),
                                    gdPictureOcr.GetCharacterTop(ocrResultId, characterIndexGlobal),
                                    gdPictureOcr.GetCharacterRight(ocrResultId, characterIndexGlobal) -
                                    gdPictureOcr.GetCharacterLeft(ocrResultId, characterIndexGlobal),
                                    gdPictureOcr.GetCharacterBottom(ocrResultId, characterIndexGlobal) -
                                    gdPictureOcr.GetCharacterTop(ocrResultId, characterIndexGlobal)));
                                characterIndexGlobal++;
                            }
                            wordIndexGlobal++;
                        }
                        textLineIndexGlobal++;
                    }
                    paragaphIndexGlobal++;
                }
            }

            return rectanglesList.ToArray();
        }

        public static Rectangle[] GetCharactersBoundingBoxesSimplified(string ocrResultId, GdPictureOCR gdPictureOcr)
        {
            List<Rectangle> rectanglesList = new List<Rectangle>();
            int characterCount = gdPictureOcr.GetCharacterCount(ocrResultId);
            for (int characterIndex = 0; characterIndex < characterCount; characterIndex++)
            {
                    rectanglesList.Add(new Rectangle(gdPictureOcr.GetCharacterLeft(ocrResultId, characterIndex),
                    gdPictureOcr.GetCharacterTop(ocrResultId, characterIndex),
                    gdPictureOcr.GetCharacterRight(ocrResultId, characterIndex) -
                    gdPictureOcr.GetCharacterLeft(ocrResultId, characterIndex),
                    gdPictureOcr.GetCharacterBottom(ocrResultId, characterIndex) -
                    gdPictureOcr.GetCharacterTop(ocrResultId, characterIndex)));
            }

            return rectanglesList.ToArray();
        }

        /// <summary>
        /// AddRegions adds regions to the provided viewer.
        /// </summary>
        /// <param name="gdViewer">The viewer.</param>
        /// <param name="rectangles">The rectangles.</param>
        /// <param name="color">The color to be used for drawing.</param>
        /// <param name="horizontalResolution">The horizontal resolution of the image.</param>
        /// <param name="verticalResolution">The vertical resolution of the image.</param>
        private static void AddRegions(GdViewer gdViewer, Rectangle[] rectangles, Color color,
            float horizontalResolution, float verticalResolution)
        {
            foreach (var rectangle in rectangles)
            {
                int regionId = gdViewer.AddRegionInches("", rectangle.Left / horizontalResolution,
                    rectangle.Top / verticalResolution, (rectangle.Right - rectangle.Left) / horizontalResolution,
                    (rectangle.Bottom - rectangle.Top) / verticalResolution, ForegroundMixMode.ForegroundMixModeUNDEFINED,
                    color);
                gdViewer.SetRegionEditable(regionId, false);
                gdViewer.SetRegionBorderWidth(regionId, 1);
                gdViewer.SetRegionBorderColor(regionId, color);
            }
        }

        /// <summary>
        /// The color to be used for blocks.
        /// </summary>
        private static readonly Color BlockColor = Color.Green;

        /// <summary>
        /// The color to be used for paragraphs.
        /// </summary>
        private static readonly Color ParagraphColor = Color.Cyan;

        /// <summary>
        /// The color to be used for text lines.
        /// </summary>
        private static readonly Color TextLineColor = Color.Magenta;

        /// <summary>
        /// The color to be used for words.
        /// </summary>
        private static readonly Color WordColor = Color.Blue;

        /// <summary>
        /// The color to be used for characters.
        /// </summary>
        private static readonly Color CharacterColor = Color.Red;
    }
}