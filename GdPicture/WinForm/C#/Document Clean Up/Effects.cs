using GdPicture14;
using System.Collections.Generic;
using System.Drawing;



namespace DocumentCleanUp
{
    namespace DocumentCleanUp
    {

        // -------------------------------
        // class definition
        // -------------------------------

        public abstract class ADocumentCleanUpEffectParameters
        {
            public ADocumentCleanUpEffectParameters Clone()
            {
                return ((ADocumentCleanUpEffectParameters)(this.MemberwiseClone()));
            }
        }

        public abstract class ADocumentCleanUpEffect
        {
            protected ADocumentCleanUpEffectParameters _parameters = null;
            public abstract string Name { get; }

            public ADocumentCleanUpEffectParameters Parameters
            {
                get
                {
                    return _parameters;
                }
            }

            public ADocumentCleanUpEffect Clone()
            {
                ADocumentCleanUpEffect obj = (ADocumentCleanUpEffect)(this.MemberwiseClone());
                if (obj._parameters != null)
                {
                    obj._parameters = this._parameters.Clone();
                }
                return obj;
            }
        }

        // -------------------------------
        // effects class definition
        // -------------------------------

        // Auto deskew
        public class AutoDeskewEffectParameters : ADocumentCleanUpEffectParameters
        {
            public AutoDeskewEffectParameters()
            {
                // VBConversions Note: Non-static class variable initialization is below.  Class variables cannot be initially assigned non-static values in C#.
                BackColor = Color.White;

            }
            public float MaxAngleOfResearch { get; set; } = 10;
            public Color BackColor { get; set; }
            public float AngleStep { get; set; } = 0.25F;
            public bool Optimistic { get; set; } = true;
        }

        public class AutoDeskewEffect : ADocumentCleanUpEffect
        {
            public AutoDeskewEffect()
            {
                _parameters = new AutoDeskewEffectParameters();
            }

            public override string Name
            {
                get
                {
                    return "Auto deskew";
                }
            }
        }

        // Auto invert negative
        public class AutoInvertEffect : ADocumentCleanUpEffect
        {

            public override string Name
            {
                get
                {
                    return "Auto invert negative";
                }
            }
        }

        // Auto text invert
        public class AutoTextInvertEffectParameters : ADocumentCleanUpEffectParameters
        {
            public int MinObjectWidth { get; set; }
            public int MinObjectHeight { get; set; }
            public int MinBlackPercent { get; set; }
            public int MaxBlackPercent { get; set; }
            public bool FixBackground { get; set; }
            public bool ConnectedToLines { get; set; }
            public int MaxLinesThickness { get; set; }
        }

        public class AutoTextInvertEffect : ADocumentCleanUpEffect
        {
            public AutoTextInvertEffect()
            {
                _parameters = new AutoTextInvertEffectParameters();
            }

            public override string Name
            {
                get
                {
                    return "Auto text invert";
                }
            }
        }

        // Crop black borders
        public class CropBlackBordersEffectParameters : ADocumentCleanUpEffectParameters
        {
            public float Confidence { get; set; } = 75;
            public int SkipLinesCount { get; set; }
        }

        public class CropBlackBordersEffect : ADocumentCleanUpEffect
        {
            public CropBlackBordersEffect()
            {
                _parameters = new CropBlackBordersEffectParameters();
            }

            public override string Name
            {
                get
                {
                    return "Crop black borders";
                }
            }
        }

        // Crop black borders
        public class CropBlackBordersEffectExParameters : ADocumentCleanUpEffectParameters
        {
            public float Confidence { get; set; } = 75;
            public int SkipLinesCount { get; set; }
        }

        public class CropBlackBordersExEffect : ADocumentCleanUpEffect
        {
            public CropBlackBordersExEffect()
            {
                _parameters = new CropBlackBordersEffectExParameters();
            }

            public override string Name
            {
                get
                {
                    return "Crop black borders extended";
                }
            }
        }

        // Crop borders
        public class CropBordersEffectParameters : ADocumentCleanUpEffectParameters
        {
            public float Confidence { get; set; } = 99;
            public ReferencePoint PixelReference { get; set; }
            public int Left { get; set; }
            public int Top { get; set; }
            public int Width { get; set; }
            public int Height { get; set; }
            public ImagingContext Context { get; set; }
        }

        public class CropBordersEffect : ADocumentCleanUpEffect
        {
            public CropBordersEffect()
            {
                _parameters = new CropBordersEffectParameters();
            }

            public override string Name
            {
                get
                {
                    return "Crop borders";
                }
            }
        }

        // Crop white borders
        public class CropWhiteBordersEffectParameters : ADocumentCleanUpEffectParameters
        {
            public float Confidence { get; set; } = 99;
            public int SkipLinesCount { get; set; }
        }

        public class CropWhiteBordersEffect : ADocumentCleanUpEffect
        {
            public CropWhiteBordersEffect()
            {
                _parameters = new CropWhiteBordersEffectParameters();
            }

            public override string Name
            {
                get
                {
                    return "Crop white borders";
                }
            }
        }

        // delete black borders
        public class DeleteBlackBordersEffectParameters : ADocumentCleanUpEffectParameters
        {
            public int Margin { get; set; } = 0;
            public bool SkewedBorders { get; set; } = false;
        }

        public class DeleteBlackBordersEffect : ADocumentCleanUpEffect
        {

            public DeleteBlackBordersEffect()
            {
                _parameters = new DeleteBlackBordersEffectParameters();
            }

            public override string Name
            {
                get
                {
                    return "Delete black borders";
                }
            }
        }

        // despeckle
        public class DespeckleEffect : ADocumentCleanUpEffect
        {

            public override string Name
            {
                get
                {
                    return "Despeckle";
                }
            }
        }

        // despeckle more
        public class DespeckleMoreEffect : ADocumentCleanUpEffect
        {

            public override string Name
            {
                get
                {
                    return "Despeckle more";
                }
            }
        }

        // Despeckle advanced
        public class DespeckAdvancedParameters : ADocumentCleanUpEffectParameters
        {
            public DespeckleType DespeckleMode { get; set; } = DespeckleType.FourConnected;
            public int Strength { get; set; } = 5;
        }

        public class DespeckleAdvancedEffect : ADocumentCleanUpEffect
        {
            public DespeckleAdvancedEffect()
            {
                _parameters = new DespeckAdvancedParameters();
            }

            public override string Name
            {
                get
                {
                    return "Despeckle (advanced)";
                }
            }
        }

        // median
        public class MedianEffectParameters : ADocumentCleanUpEffectParameters
        {
            public int KernelSize { get; set; } = 1;
        }

        public class MedianEffect : ADocumentCleanUpEffect
        {
            public MedianEffect()
            {
                _parameters = new MedianEffectParameters();
            }

            public override string Name
            {
                get
                {
                    return "Median";
                }
            }
        }

        // remove blob
        public class RemoveBlobEffectParameters : ADocumentCleanUpEffectParameters
        {
            public int MinBlobWidth { get; set; } = 20;
            public int MinBlobHeight { get; set; } = 20;
            public int MaxBlobWidth { get; set; } = 100;
            public int MaxBlobHeight { get; set; } = 100;
            public int MinFillPercent { get; set; } = 75;
            public int MaxFillPercent { get; set; } = 100;
        }

        public class RemoveBlobEffect : ADocumentCleanUpEffect
        {
            public RemoveBlobEffect()
            {
                _parameters = new RemoveBlobEffectParameters();
            }
            public override string Name
            {
                get
                {
                    return "Remove blob";
                }
            }
        }

        // remove punch holes
        public class RemoveHolePunchEffectParameters : ADocumentCleanUpEffectParameters
        {
            public HolePunchMargins Margins { get; set; } = HolePunchMargins.MarginLeft | HolePunchMargins.MarginRight | HolePunchMargins.MarginBottom | HolePunchMargins.MarginTop;
        }

        public class RemoveHolePunchEffect : ADocumentCleanUpEffect
        {
            public RemoveHolePunchEffect()
            {
                _parameters = new RemoveHolePunchEffectParameters();
            }
            public override string Name
            {
                get
                {
                    return "Remove punch holes";
                }
            }
        }

        // remove lines
        public class RemoveLinesEffectParameters : ADocumentCleanUpEffectParameters
        {
            public LineRemoveOrientation Orientation { get; set; } = LineRemoveOrientation.Horizontal;
            public int MaxLineGap { get; set; } = -1;
            public int MaxLineThickness { get; set; } = 8;
            public int MinLineLength { get; set; } = 75;
            public int MaxInterception { get; set; } = 8;
            public bool ReConnectBrokenCharacters { get; set; } = false;
        }

        public class RemoveLinesEffect : ADocumentCleanUpEffect
        {
            public RemoveLinesEffect()
            {
                _parameters = new RemoveLinesEffectParameters();
            }
            public override string Name
            {
                get
                {
                    return "Remove lines";
                }
            }
        }

        //remove staple mark
        public class RemoveStapleMarkEffect : ADocumentCleanUpEffect
        {

            public override string Name
            {
                get
                {
                    return "Remove staple mark";
                }
            }
        }

        // bitonal close8
        public class BitonalClose8Effect : ADocumentCleanUpEffect
        {

            public override string Name
            {
                get
                {
                    return "Bitonal morphological close";
                }
            }
        }

        // bitonal despeckle
        public class BitonalDespeckleEffectParameters : ADocumentCleanUpEffectParameters
        {
            public bool FixText { get; set; }
        }

        public class BitonalDespeckleEffect : ADocumentCleanUpEffect
        {
            public BitonalDespeckleEffect()
            {
                _parameters = new BitonalDespeckleEffectParameters();
            }
            public override string Name
            {
                get
                {
                    return "Bitonal despeckle";
                }
            }
        }

        // bitonal despeckle more
        public class BitonalDespeckleMoreEffectParameters : ADocumentCleanUpEffectParameters
        {
            public bool FixText { get; set; }
        }

        public class BitonalDespeckleMoreEffect : ADocumentCleanUpEffect
        {
            public BitonalDespeckleMoreEffect()
            {
                _parameters = new BitonalDespeckleMoreEffectParameters();
            }
            public override string Name
            {
                get
                {
                    return "Bitonal despeckle more";
                }
            }
        }

        // bitonal ouline
        public class BitonalOutlineEffect : ADocumentCleanUpEffect
        {

            public override string Name
            {
                get
                {
                    return "Bitonal outline";
                }
            }
        }

        // bitonal skeletonize
        public class BitonalSkeletonizeEffectParameters : ADocumentCleanUpEffectParameters
        {
            public int Repetition { get; set; } = 4;
        }

        public class BitonalSkeletonizeEffect : ADocumentCleanUpEffect
        {
            public BitonalSkeletonizeEffect()
            {
                _parameters = new BitonalSkeletonizeEffectParameters();
            }
            public override string Name
            {
                get
                {
                    return "Bitonal skeletonize";
                }
            }
        }

        // bitonal vigorous despeckle
        public class BitonalVigorousDespeckleEffectParameters : ADocumentCleanUpEffectParameters
        {
            public bool CheckForDotOfI { get; set; } = false;
        }

        public class BitonalVigorousDespeckleEffect : ADocumentCleanUpEffect
        {
            public BitonalVigorousDespeckleEffect()
            {
                _parameters = new BitonalVigorousDespeckleEffectParameters();
            }
            public override string Name
            {
                get
                {
                    return "Bitonal vigorous despeckle";
                }
            }
        }

        // bitonal dilate
        public class BitonalDilateEffectParameters : ADocumentCleanUpEffectParameters
        {
            public int KernelSize { get; set; } = 1;
        }

        public class BitonalDilateEffect : ADocumentCleanUpEffect
        {
            public BitonalDilateEffect()
            {
                _parameters = new BitonalDilateEffectParameters();
            }
            public override string Name
            {
                get
                {
                    return "Bitonal dilate";
                }
            }
        }

        // bitonal dilate 4
        public class BitonalDilate4Effect : ADocumentCleanUpEffect
        {
            public override string Name
            {
                get
                {
                    return "Bitonal dilate 4 directions";
                }
            }
        }

        // bitonal dilate 8
        public class BitonalDilate8Effect : ADocumentCleanUpEffect
        {
            public override string Name
            {
                get
                {
                    return "Bitonal dilate 8 directions";
                }
            }
        }

        // bitonal dilate h
        public class BitonalDilateHEffect : ADocumentCleanUpEffect
        {
            public override string Name
            {
                get
                {
                    return "Bitonal dilate horizontal";
                }
            }
        }

        // bitonal dilate v
        public class BitonalDilateVEffect : ADocumentCleanUpEffect
        {
            public override string Name
            {
                get
                {
                    return "Bitonal dilate vertical";
                }
            }
        }

        // bitonal erode
        public class BitonalErodeEffectParameters : ADocumentCleanUpEffectParameters
        {
            public int KernelSize { get; set; } = 1;
        }

        public class BitonalErodeEffect : ADocumentCleanUpEffect
        {
            public BitonalErodeEffect()
            {
                _parameters = new BitonalErodeEffectParameters();
            }
            public override string Name
            {
                get
                {
                    return "Bitonal erode";
                }
            }
        }

        // bitonal erode 4
        public class BitonalErode4Effect : ADocumentCleanUpEffect
        {
            public override string Name
            {
                get
                {
                    return "Bitonal erode 4 directions";
                }
            }
        }

        // bitonal erode 8
        public class BitonalErode8Effect : ADocumentCleanUpEffect
        {
            public override string Name
            {
                get
                {
                    return "Bitonal erode 8 directions";
                }
            }
        }

        // bitonal erode v
        public class BitonalErodeVEffect : ADocumentCleanUpEffect
        {
            public override string Name
            {
                get
                {
                    return "Bitonal erode vertical";
                }
            }
        }

        // bitonal fill holes horizontal
        public class BitonalFillHolesHEffect : ADocumentCleanUpEffect
        {
            public override string Name
            {
                get
                {
                    return "Bitonal fill holes horizontal";
                }
            }
        }

        // bitonal fill holes horizontal & vertical
        public class BitonalFillHolesHVEffect : ADocumentCleanUpEffect
        {
            public override string Name
            {
                get
                {
                    return "Bitonal fill holes horizontal and vertical";
                }
            }
        }

        // bitonal fill holes vertical
        public class BitonalFillHolesVEffect : ADocumentCleanUpEffect
        {
            public override string Name
            {
                get
                {
                    return "Bitonal fill holes vertical";
                }
            }
        }

        // bitonal open 8
        public class BitonalOpen8Effect : ADocumentCleanUpEffect
        {
            public override string Name
            {
                get
                {
                    return "Bitonal morphological open";
                }
            }
        }

        // bitonal remove isolated dots 2x2
        public class BitonalRemoveIsolatedDots2X2Effect : ADocumentCleanUpEffect
        {
            public override string Name
            {
                get
                {
                    return "Bitonal remove isolated dots 2x2";
                }
            }
        }

        // bitonal remove isolated dots 4
        public class BitonalRemoveIsolatedDots4Effect : ADocumentCleanUpEffect
        {
            public override string Name
            {
                get
                {
                    return "Bitonal remove isolated dots 4 directions";
                }
            }
        }

        // bitonal remove isolated dots 8
        public class BitonalRemoveIsolatedDots8Effect : ADocumentCleanUpEffect
        {
            public override string Name
            {
                get
                {
                    return "Bitonal remove isolated dots 8 directions";
                }
            }
        }

        // -------------------------------
        // effects list
        // -------------------------------
        public class DocumentCleanUpEffects
        {
            private List<ADocumentCleanUpEffect> _list = new List<ADocumentCleanUpEffect>();

            public DocumentCleanUpEffects()
            {
                _list.Add(new AutoDeskewEffect());
                _list.Add(new AutoInvertEffect());
                _list.Add(new AutoTextInvertEffect());
                _list.Add(new CropBlackBordersEffect());
                _list.Add(new CropBlackBordersExEffect());
                _list.Add(new CropBordersEffect());
                _list.Add(new CropWhiteBordersEffect());
                _list.Add(new DeleteBlackBordersEffect());
                _list.Add(new DespeckleEffect());
                _list.Add(new DespeckleMoreEffect());
                _list.Add(new DespeckleAdvancedEffect());
                _list.Add(new MedianEffect());
                _list.Add(new RemoveBlobEffect());
                _list.Add(new RemoveHolePunchEffect());
                _list.Add(new RemoveLinesEffect());
                _list.Add(new RemoveStapleMarkEffect());
                _list.Add(new BitonalClose8Effect());
                _list.Add(new BitonalDespeckleEffect());
                _list.Add(new BitonalDespeckleMoreEffect());
                _list.Add(new BitonalOutlineEffect());
                _list.Add(new BitonalSkeletonizeEffect());
                _list.Add(new BitonalVigorousDespeckleEffect());
                _list.Add(new BitonalDilateEffect());
                _list.Add(new BitonalDilate4Effect());
                _list.Add(new BitonalDilate8Effect());
                _list.Add(new BitonalDilateHEffect());
                _list.Add(new BitonalDilateVEffect());
                _list.Add(new BitonalErodeEffect());
                _list.Add(new BitonalErode4Effect());
                _list.Add(new BitonalErode8Effect());
                _list.Add(new BitonalErodeVEffect());
                _list.Add(new BitonalFillHolesHEffect());
                _list.Add(new BitonalFillHolesHVEffect());
                _list.Add(new BitonalFillHolesVEffect());
                _list.Add(new BitonalOpen8Effect());
                _list.Add(new BitonalRemoveIsolatedDots2X2Effect());
                _list.Add(new BitonalRemoveIsolatedDots4Effect());
                _list.Add(new BitonalRemoveIsolatedDots8Effect());
            }

            public List<ADocumentCleanUpEffect> List
            {
                get
                {
                    return _list;
                }
            }
        }
    }
}
