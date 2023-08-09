using System.Drawing;
using System.Collections.Generic;



namespace Csharp_Forms_Processing
{
	public class FilledForm
	{
		
		public int m_Image; //Image, has to be cleared by owner
		public Rectangle m_FoundAnchor; //Position of Anchor on FilledForm
		public Rectangle[] Fields; //Rectangles Surrounding the OMR fields
		int m_NumberOfFields;
		public int[] Results; //Array to hold results of OMR image
		public int[] Confidence; // Array for confidence of each field result
		
		//Constructor
		public FilledForm(int Image, int NumberOfFields, ref List<Rectangle> TemplateFields)
		{
			m_Image = Image;
			m_NumberOfFields = NumberOfFields;
			Fields = new Rectangle[NumberOfFields + 1];
			Results = new int[NumberOfFields + 1];
			Confidence = new int[NumberOfFields + 1];
			CopyFieldsFromTemplate(TemplateFields);
		}
		
		//Copies the Coordinates of the OMR Fields from the TemplateForm
		public void CopyFieldsFromTemplate(List<Rectangle> TemplateFields)
		{
			Rectangle rect = new Rectangle();
			int counter = 0;
			
			foreach (Rectangle tempLoopVar_rect in TemplateFields)
			{
				rect = tempLoopVar_rect;
				Fields[counter] = rect;
				counter++;
			}
		}
		
		//Adjust the Field Positions in the Form depending on the location the anchor was found on it
		public void AdjustFieldsAccordingToAnchor(Rectangle NewAnchorPosition, Rectangle TemplateAnchorPosition)
		{
			m_FoundAnchor = NewAnchorPosition;
			//Calculate Difference in Position between Anchor Found on Filled Form and Original Anchor On Template Form
            int Left = NewAnchorPosition.X - TemplateAnchorPosition.X;
            int Top = NewAnchorPosition.Y - TemplateAnchorPosition.Y;
			
			//Add Difference to Current Filled Form Fields Positions
			for (int i = 0; i <= m_NumberOfFields; i++)
			{
				Fields[i].X += Left;
				Fields[i].Y += Top;
			}
		}
	}
	
}
