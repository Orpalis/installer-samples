using System;
using System.Drawing;
using System.Collections.Generic;


namespace Csharp_Forms_Processing
{
    public class TemplateForm
    {

        public int m_Image; //Template Form Image Identifier
        //Anchor ID and Positions
        public IntPtr m_AnchorID;
        public Rectangle m_AnchorPosition;

        //List to contain Field Positions
        public List<Rectangle> m_Fields;

        //OMR Recognition Process Options
        public bool m_IsCircular; //Whether OMR fields are circular and checkboxes(True) or Oval(False)
        public bool m_HasCharacter; //Whether OMR field has a character inside of it or it is empty
        public bool m_UseConfidence; //Whether to use Confidence in the OMR Recognition Process or not
        public double m_Sensitivity; //Amount of Sinsitivity to be used in OMR Recognition Process if m_UseConfidence is set to True
        public int m_MinimumConfidence; //Minimum Confidence to accept a value as CHECKED

        //Counters
        public int m_NumberOfFields;

        public TemplateForm()
        {
            m_AnchorPosition = new Rectangle(0, 0, 0, 0);
            m_Fields = new List<Rectangle>();
            m_IsCircular = true;
            m_HasCharacter = false;
            m_UseConfidence = false;
            m_Sensitivity = 0.5;
            //Initialize Counters
            m_NumberOfFields = 0;
        }

        public void Clear()
        {
            //NOTE IMPORTANT: m_Image and m_AnchorID have to be cleared outside the scope of the object, because they are owned by oGdPictureImaging
            //which is a member of the GUIManager instance
            m_AnchorPosition = new Rectangle(0, 0, 0, 0);

            m_IsCircular = true;
            m_HasCharacter = false;
            m_UseConfidence = false;
            m_Sensitivity = 0.5;
            m_NumberOfFields = 0;
            m_Fields.Clear();
        }

        //- To be called each time a new Rectangle is drawn (Handled by MouseUp Event in the TemplateForm GdViewer)
        //- If multiple fields are added with one Rectangle, the MouseUp event will split those accordingly to the desired number of fields,
        //   and AddField will be called multiple times.
        public void AddField(Rectangle Rect)
        {
            m_Fields.Add(Rect);
            m_NumberOfFields++;
        }

        //Updates a Fields info
        //Called upon RegionEdited By User
        public void UpdateField(int FieldNumber, Rectangle RECT)
        {
            Rectangle r = m_Fields[FieldNumber];
            r.X = RECT.X;
            r.Y = RECT.Y;
            r.Width = RECT.Width;
            r.Height = RECT.Height;
            m_Fields[FieldNumber] = r;
        }

        //Update Anchor, to be called on creation of Anchor, and any change occuring to the Anchor Rectangle (Handled by RegionEditedByUser event)
        public void UpdateAnchor(IntPtr Anchor, Rectangle Position)
        {
            m_AnchorID = Anchor;
            m_AnchorPosition = Position;
        }
    }

}
