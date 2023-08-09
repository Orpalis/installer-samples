using System;
using System.Collections.Generic;


namespace GdPicture.OCR.Plugins
{
    /// <summary>
    /// The OcrResult class manages the ocr result.
    /// </summary>
    [Serializable]
    public sealed class GdPictureOcrResult
    {
        /// <summary>
        /// The standard rotation applied to the page before starting the OCR process.
        /// Accepted values are 0, 90, 180 and 270.
        /// </summary>
        public int PageRotation;


        /// <summary>
        /// The detected page skew angle, in degrees, clockwise.
        /// </summary>
        public float PageSkewAngle;


        /// <summary>
        /// The paragraphs of the page.
        /// </summary>
        public IEnumerable<GdPictureOcrParagraph> Paragraphs;
    }


    [Serializable]
    public sealed class GdPictureOcrParagraph
    {
        /// <summary>
        /// The standard rotation of the paragraph.
        /// Accepted values are 0, 90, 180 and 270.
        /// </summary>
        public int ParagraphRotation;


        /// <summary>
        /// The text writing direction.
        /// Supported values are: 0 for left to right, 1 for right to left, 2 for top to bottom.
        public int TextWritingDirection;


        /// <summary>
        /// The lines of the paragraph.
        /// </summary>
        public IEnumerable<GdPictureOcrLine> Lines;
    }


    [Serializable]
    public sealed class GdPictureOcrLine
    {
        /// <summary>
        /// The words of the line.
        /// </summary>
        public IEnumerable<GdPictureOcrWord> Words;
    }


    [Serializable]
    public sealed class GdPictureOcrWord
    {
        /// <summary>
        /// The bounding box.
        /// It is not mandatory to provide it since it can be computed from character boxes.
        /// </summary>
        public GdPictureOcrRect BBox;


        /// <summary>
        /// The characters of the word.
        /// </summary>
        public IEnumerable<GdPictureOcrCharacter> Characters;
    }


    [Serializable]
    public sealed class GdPictureOcrCharacter
    {
        /// <summary>
        /// The bounding box.
        /// </summary>
        public GdPictureOcrRect BBox;


        /// <summary>
        /// The character value.
        /// </summary>
        public char Value;
    }


    [Serializable]
    public sealed class GdPictureOcrRect
    {
        public int Left;
        public int Top;
        public int Right;
        public int Bottom;


        internal int Width
        {
            get
            {
                return Right - Left;
            }
        }


        internal int Height
        {
            get
            {
                return Bottom - Top;
            }
        }


        public GdPictureOcrRect(int Left, int Top, int Right, int Bottom)
        {
            this.Left = Left;
            this.Top = Top;
            this.Right = Right;
            this.Bottom = Bottom;
        }
    }
}