using GdPicture14.WEB;
using GdPicture14;
using System.Globalization;

namespace angular15_rest_core.DocuViewareCustomActions
{
    /// <summary>
    /// This class defines what a form field is in our context
    /// </summary>
    internal sealed class FormField
    {
        public int FieldId { get; set; }
        public string FieldName { get; set; }
        public string FieldValue { get; set; }
        public FormField(int fieldId, string fieldName, string fieldValue)
        {
            FieldId = fieldId;
            FieldName = fieldName;
            FieldValue = fieldValue;
        }
    }

    /// <summary>
    /// This class defines the InvoiceLine object
    /// </summary>
    internal sealed class InvoiceLine
    {
        public int ArticleQuantity { get; set; }
        public float ArticleUnitPrice { get; set; }
        public InvoiceLine(int articleQuantity, float articleUnitPrice)
        {
            ArticleQuantity = articleQuantity;
            ArticleUnitPrice = articleUnitPrice;
        }
    }

    public class FormFieldsDemo
    {
        private const string ARTICLE = "Article";
        private const string QTY = "Qty";
        private const string UNIT_PRICE = "Price";
        private const string VAT = "VAT";
        private const string SUBTOTAL = "Subtotal";
        private const string VAT_AMOUNT = "VATAmount";
        private const string TOTAL_AMOUNT = "TotalAmount";

        /// <summary>
        /// Entry point for the custom action handler
        /// </summary>
        public static void HandleFormFieldsAction(CustomActionEventArgs e)
        {
            switch (e.actionName)
            {
                case "Calculate":
                    Calculate(e);
                    break;
                case "SaveAsPdf":
                    SaveAsPdf(e);
                    break;
                default:
                    return;
            }
        }

        /// <summary>
        /// This method will explore the form fields do the math and set the results
        /// </summary>
        private static void Calculate(CustomActionEventArgs e)
        {
            GdPicturePDF oGdPicturePdf;
            e.docuVieware.GetNativePDF(out oGdPicturePdf);

            float vatRate, subtotal, vatAmount, total;
            GetInvoiceTotal(oGdPicturePdf, out vatRate, out subtotal, out vatAmount, out total);

            // Put the result values into the corresponding form fields
            int iFormFieldCount = oGdPicturePdf.GetFormFieldsCount();
            for (int fieldIdx = 0; fieldIdx < iFormFieldCount; fieldIdx++)
            {
                int fieldId = oGdPicturePdf.GetFormFieldId(fieldIdx);
                switch (oGdPicturePdf.GetFormFieldFullTitle(fieldId))
                {
                    case SUBTOTAL:
                        oGdPicturePdf.SetFormFieldValue(fieldId, subtotal.ToString(CultureInfo.InvariantCulture) + " $");
                        break;
                    case VAT_AMOUNT:
                        oGdPicturePdf.SetFormFieldValue(fieldId, vatAmount.ToString(CultureInfo.InvariantCulture) + " $");
                        break;
                    case TOTAL_AMOUNT:
                        oGdPicturePdf.SetFormFieldValue(fieldId, total.ToString(CultureInfo.InvariantCulture) + " $");
                        break;
                }
            }
            e.docuVieware.RedrawPage();
        }

        /// <summary>
        /// This method will put together the invoice lines and compute Subtotal, VAT and Total
        /// </summary>
        private static void GetInvoiceTotal(GdPicturePDF oGdPicturePdf, out float vatRate, out float subtotal, out float vatAmount, out float total)
        {
            List<InvoiceLine> invoiceLines = new List<InvoiceLine>();
            {
                List<FormField> formFields;
                vatRate = 0;
                GetFormFieldsList(oGdPicturePdf, out formFields);
                // Put together the invoice lines
                foreach (FormField field in formFields)
                {
                    if (field.FieldName.StartsWith(ARTICLE))
                    {
                        InvoiceLine line = GetLineItem(formFields, field);
                        if (line != null)
                        {
                            invoiceLines.Add(line);
                        }
                    }
                    else if (field.FieldName.Equals(VAT))
                    {
                        vatRate = Convert.ToSingle(field.FieldValue.Split('%')[0]);
                    }
                }
                formFields.Clear();
            }
            // Compute the subtotal, VAT and total
            subtotal = 0;
            foreach (InvoiceLine line in invoiceLines)
            {
                subtotal += line.ArticleQuantity * line.ArticleUnitPrice;
            }
            invoiceLines.Clear();
            vatAmount = subtotal / 100 * vatRate;
            total = subtotal + vatAmount;
        }

        /// <summary>
        /// This method gather all the form fields that are found on the demo PDF document in a list
        /// </summary>
        private static void GetFormFieldsList(GdPicturePDF oGdPicturePdf, out List<FormField> formFields)
        {
            formFields = new List<FormField>();
            for (int fieldIdx = 0; fieldIdx <= oGdPicturePdf.GetFormFieldsCount() - 1; fieldIdx++)
            {
                int fieldId = oGdPicturePdf.GetFormFieldId(fieldIdx);
                if ((oGdPicturePdf.GetFormFieldFullTitle(fieldId) == SUBTOTAL) || (oGdPicturePdf.GetFormFieldFullTitle(fieldId) == VAT_AMOUNT) || (oGdPicturePdf.GetFormFieldFullTitle(fieldId) == TOTAL_AMOUNT))
                {
                    oGdPicturePdf.SetFormFieldValue(fieldId, "");
                }
                string fieldName = oGdPicturePdf.GetFormFieldFullTitle(fieldId);
                string fieldValue = oGdPicturePdf.GetFormFieldValue(fieldId);
                FormField field = new FormField(fieldId, fieldName, fieldValue);
                formFields.Add(field);
            }
        }

        /// <summary>
        /// This method gather the quantity and the unit price for an article and returns either a complete invoice line or null
        /// </summary>
        private static InvoiceLine GetLineItem(List<FormField> formFields, FormField field)
        {
            int lineIdx = int.Parse(field.FieldName.Substring(7));
            int articleQuantity = 0;
            float articleUnitPrice = 0;

            FormField qtyField = formFields.Find(item => item.FieldName == QTY + lineIdx.ToString());
            if (!qtyField.FieldValue.Equals(string.Empty))
            {
                articleQuantity = int.Parse(qtyField.FieldValue);
            }
            FormField unitPriceField = formFields.Find(item => item.FieldName == UNIT_PRICE + lineIdx.ToString());
            if (!unitPriceField.FieldValue.Equals(string.Empty))
            {
                articleUnitPrice = float.Parse(unitPriceField.FieldValue);
            }

            if ((articleQuantity != 0) && (articleUnitPrice != 0))
            {
                return new InvoiceLine(articleQuantity, articleUnitPrice);
            }
            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        private static void SaveAsPdf(CustomActionEventArgs e)
        {
            // We are going to save the PDF into a stream
            MemoryStream stream = new MemoryStream();
            GdPicturePDF oGdPicturePdf;
            e.docuVieware.GetNativePDF(out oGdPicturePdf);
            GdPicturePDF savedPdfDocument = new GdPicturePDF();
            savedPdfDocument.NewPDF();
            savedPdfDocument.ClonePage(oGdPicturePdf, 1);
            savedPdfDocument.FlattenFormFields();
            savedPdfDocument.SaveToStream(stream);
            // We then convert the stream to a byte array
            byte[] content = stream.ToArray();
            stream.Flush();
            stream.Close();
            // We send back the file data just created as result
            e.result = Convert.ToBase64String(content);
        }
    }
}
