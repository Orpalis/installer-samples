using GdPicture14;

namespace barcode_recognition
{
    public enum ThresholdingMode
    {
        Linear,
        Bradley,
        Otsu,
        Sauvola,
        Wan
    }

    sealed class Globals
    {
        public const int DEFAULT_BRADLEY_THRESHOLD = 20; //this is the value internally used in GdPicture to threshold barcode images.
        public static ThresholdingMode binarizationMode = ThresholdingMode.Bradley;

        public static DespeckleType DEFAULT_DESPECKLE_TYPE = DespeckleType.FourConnected;
        public static int DEFAULT_DESPECKLE_STRENGTH = 5;

        //Parameters for thresholding functions
        public static int thresholdValue = DEFAULT_BRADLEY_THRESHOLD;
        public static int smoothKernel; //used for sauvola thresholding
        public static int contrastMinDif; //used for sauvola thresholding

        public static DespeckleType despeckleType = DEFAULT_DESPECKLE_TYPE;
        public static int despeckleStrength = DEFAULT_DESPECKLE_STRENGTH;

        public static readonly GdPictureImaging gdPictureImaging = new GdPictureImaging();
        public static readonly GdPicturePDF gdPicturePDF = new GdPicturePDF();
        public static int nativeImage;
        public static DocumentType docSourceType;
    }
}
