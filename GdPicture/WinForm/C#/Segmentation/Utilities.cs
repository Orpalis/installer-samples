using GdPicture14;
using System.Collections.Generic;
using System.Drawing;


namespace Segmenter
{
    static class Utilities
    {
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

        public static void MarkRegions(GdPictureSegmenter gdPictureSegmenter, string resultID,
            GdViewer gdViewer, bool showBlocks, bool showParagraphs,
            bool showTextLines, bool showWords, bool showCharacters, 
            bool showText, bool showBitmap, bool showLines,
            float horizontalResolution, float verticalResolution)
        {
            gdViewer.RemoveAllRegions();

            GetElementsBoundingBoxes(gdPictureSegmenter, resultID,
                                     showText, showBitmap, showLines,
                                     out List<Rectangle> blocks,
                                     out List<Rectangle> paragraphs,
                                     out List<Rectangle> lines,
                                     out List<Rectangle> words,
                                     out List<Rectangle> chars);

            if (showBlocks)
            {
                AddRegions(gdViewer, blocks, BlockColor, horizontalResolution, verticalResolution);
            }

            if (showParagraphs)
            {
                AddRegions(gdViewer, paragraphs, ParagraphColor, horizontalResolution, verticalResolution);
            }

            if (showTextLines)
            {
                AddRegions(gdViewer, lines, TextLineColor, horizontalResolution, verticalResolution);
            }

            if (showWords)
            {
                AddRegions(gdViewer, words, WordColor, horizontalResolution, verticalResolution);
            }

            if (showCharacters)
            {
                AddRegions(gdViewer, chars, CharacterColor, horizontalResolution, verticalResolution);
            }
        }


        public static void GetElementsBoundingBoxes(GdPictureSegmenter gdPictureSegmenter,
                                                    string segmentationResultId,
                                                    bool getText, bool getBitmap, bool getLines,
                                                    out List<Rectangle> blocks,
                                                    out List<Rectangle> paragraphs,
                                                    out List<Rectangle> lines,
                                                    out List<Rectangle> words,
                                                    out List<Rectangle> chars)
        {
            blocks = new List<Rectangle>();
            paragraphs = new List<Rectangle>();
            lines = new List<Rectangle>();
            words = new List<Rectangle>();
            chars = new List<Rectangle>();

            int blocksCount = gdPictureSegmenter.GetBlockCount(segmentationResultId);

            for (int blockIndex = 0; blockIndex < blocksCount; blockIndex++)
            {
                OCRBlockType blockType = gdPictureSegmenter.GetBlockType(segmentationResultId, blockIndex);

                if( (blockType == OCRBlockType.Unknown /*type returned by connected components*/) ||
                    (getText && IsTextBlockType(blockType)) ||
                    (getBitmap && IsImageBlockType(blockType)) ||
                    (getLines && IsLineBlockType(blockType))
                    )
                { 

                blocks.Add(new Rectangle(gdPictureSegmenter.GetBlockLeft(segmentationResultId, blockIndex),
                                         gdPictureSegmenter.GetBlockTop(segmentationResultId, blockIndex),
                                         gdPictureSegmenter.GetBlockRight(segmentationResultId, blockIndex) -
                                         gdPictureSegmenter.GetBlockLeft(segmentationResultId, blockIndex),
                                         gdPictureSegmenter.GetBlockBottom(segmentationResultId, blockIndex) -
                                         gdPictureSegmenter.GetBlockTop(segmentationResultId, blockIndex)));
                int paragaphsCount = gdPictureSegmenter.GetBlockParagraphCount(segmentationResultId, blockIndex);

                    for (int paragaphIndex = gdPictureSegmenter.GetBlockFirstParagraphIndex(segmentationResultId, blockIndex); paragaphIndex < gdPictureSegmenter.GetBlockFirstParagraphIndex(segmentationResultId, blockIndex) + paragaphsCount; paragaphIndex++)
                    {
                        paragraphs.Add(new Rectangle(gdPictureSegmenter.GetParagraphLeft(segmentationResultId, paragaphIndex),
                                       gdPictureSegmenter.GetParagraphTop(segmentationResultId, paragaphIndex),
                                       gdPictureSegmenter.GetParagraphRight(segmentationResultId, paragaphIndex) -
                                       gdPictureSegmenter.GetParagraphLeft(segmentationResultId, paragaphIndex),
                                       gdPictureSegmenter.GetParagraphBottom(segmentationResultId, paragaphIndex) -
                                       gdPictureSegmenter.GetParagraphTop(segmentationResultId, paragaphIndex)));
                        int textLinesCount = gdPictureSegmenter.GetParagraphTextLineCount(segmentationResultId, paragaphIndex);

                        for (int textLineIndex = gdPictureSegmenter.GetParagraphFirstTextLineIndex(segmentationResultId, paragaphIndex); textLineIndex < gdPictureSegmenter.GetParagraphFirstTextLineIndex(segmentationResultId, paragaphIndex) + textLinesCount; textLineIndex++)
                        {
                            lines.Add(new Rectangle(gdPictureSegmenter.GetTextLineLeft(segmentationResultId, textLineIndex),
                                                    gdPictureSegmenter.GetTextLineTop(segmentationResultId, textLineIndex),
                                                    gdPictureSegmenter.GetTextLineRight(segmentationResultId, textLineIndex) -
                                                    gdPictureSegmenter.GetTextLineLeft(segmentationResultId, textLineIndex),
                                                    gdPictureSegmenter.GetTextLineBottom(segmentationResultId, textLineIndex) -
                                                    gdPictureSegmenter.GetTextLineTop(segmentationResultId, textLineIndex)));

                            int wordsCount = gdPictureSegmenter.GetTextLineWordCount(segmentationResultId, textLineIndex);
                            for (int wordIndex = gdPictureSegmenter.GetTextLineFirstWordIndex(segmentationResultId, textLineIndex); wordIndex < gdPictureSegmenter.GetTextLineFirstWordIndex(segmentationResultId, textLineIndex) + wordsCount; wordIndex++)
                            {
                                words.Add(new Rectangle(gdPictureSegmenter.GetWordLeft(segmentationResultId, wordIndex),
                                                        gdPictureSegmenter.GetWordTop(segmentationResultId, wordIndex),
                                                        gdPictureSegmenter.GetWordRight(segmentationResultId, wordIndex) -
                                                        gdPictureSegmenter.GetWordLeft(segmentationResultId, wordIndex),
                                                        gdPictureSegmenter.GetWordBottom(segmentationResultId, wordIndex) -
                                                        gdPictureSegmenter.GetWordTop(segmentationResultId, wordIndex)));

                                int charactersCount = gdPictureSegmenter.GetWordCharacterCount(segmentationResultId, wordIndex);
                                for (int characterIndex = gdPictureSegmenter.GetWordFirstCharacterIndex(segmentationResultId, wordIndex); characterIndex < gdPictureSegmenter.GetWordFirstCharacterIndex(segmentationResultId, wordIndex) + charactersCount; characterIndex++)
                                {
                                    chars.Add(new Rectangle(
                                        gdPictureSegmenter.GetCharacterLeft(segmentationResultId, characterIndex),
                                        gdPictureSegmenter.GetCharacterTop(segmentationResultId, characterIndex),
                                        gdPictureSegmenter.GetCharacterRight(segmentationResultId, characterIndex) -
                                        gdPictureSegmenter.GetCharacterLeft(segmentationResultId, characterIndex),
                                        gdPictureSegmenter.GetCharacterBottom(segmentationResultId, characterIndex) -
                                        gdPictureSegmenter.GetCharacterTop(segmentationResultId, characterIndex)));
                                }
                            }
                        }
                    }
                }
            }
        }


        public static bool IsImageBlockType(OCRBlockType blockType)
        {
            return blockType == OCRBlockType.FlowingImage ||
                   blockType == OCRBlockType.HeadingImage ||
                   blockType == OCRBlockType.PulloutImage;
        }


        public static bool IsTextBlockType(OCRBlockType blockType)
        {
            return blockType == OCRBlockType.CaptionText ||
                   blockType == OCRBlockType.FlowingText ||
                   blockType == OCRBlockType.HeadingText ||
                   blockType == OCRBlockType.PulloutText ||
                   blockType == OCRBlockType.Table;
        }


        public static bool IsLineBlockType(OCRBlockType blockType)
        {
            return blockType == OCRBlockType.VerticalLine ||
                   blockType == OCRBlockType.HorizontalLine;
        }


        private static void AddRegions(GdViewer gdViewer, IEnumerable<Rectangle> rectangles, Color color,
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
    }
}