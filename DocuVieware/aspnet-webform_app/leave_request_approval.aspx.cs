using System;
using System.Drawing;
using System.IO;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using GdPicture14;
using GdPicture14.Annotations;
using GdPicture14.WEB;

namespace DocuVieware_webform_app_demo
{
    public partial class LeaveRequestApproval : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DocuVieware1.Timeout = Global.SESSION_TIMEOUT;
            if (!IsPostBack)
            {
                CustomSnapInGeneration();
                DocuVieware1.LoadFromStream(new FileStream(Global.GetDocumentsDirectory() + @"\leave_requests.pdf", FileMode.Open, FileAccess.Read), true, "leave_requests.pdf");
            }
        }

        /// <summary>
        /// Generates and register the custom snap-in content
        /// </summary>
        private void CustomSnapInGeneration()
        {
            using (HtmlGenericControl icon = new HtmlGenericControl("svg"))
            {
                icon.Attributes["viewBox"] = "0 0 16 16";
                icon.Attributes["width"] = "100%";
                icon.Attributes["height"] = "100%";
                icon.InnerHtml = "<path d=\"M0 16c2-6 7.234-16 16-16-4.109 3.297-6 11-9 11s-3 0-3 0l-3 5h-1z\"></path>";

                using (HtmlGenericControl panel = new HtmlGenericControl("div"))
                {
                    panel.ClientIDMode = ClientIDMode.Static;
                    panel.ID = "LeaveRequestApprovalSnapInPanel" + DocuVieware1.UniqueID;
                    using (HtmlGenericControl customSnapInButtonDiv = new HtmlGenericControl("div"))
                    {
                        customSnapInButtonDiv.Style["float"] = "left";
                        customSnapInButtonDiv.Style["margin-top"] = "6px";
                        customSnapInButtonDiv.Style["margin-left"] = "6px";
                        using (HtmlGenericControl customSnapInButton = new HtmlGenericControl("button"))
                        {
                            customSnapInButton.ID = "LeaveRequestApprovalSnapInBlueMarker" + DocuVieware1.UniqueID;
                            customSnapInButton.Attributes["class"] = "btn-valid";
                            customSnapInButton.Style["margin-bottom"] = "15px";
                            customSnapInButton.Style["margin-left"] = "15px";
                            customSnapInButton.Style["height"] = "26px";
                            customSnapInButton.Style["width"] = "80px";
                            customSnapInButton.Style["display"] = "block";
                            customSnapInButton.Style["background"] = ColorTranslator.ToHtml(DocuVieware1.ActiveSelectedColor);
                            customSnapInButton.InnerHtml = "Marker";
                            customSnapInButton.Attributes["onclick"] = "blueMarkerAnnotation(); return false;";
                            customSnapInButtonDiv.Controls.Add(customSnapInButton);
                        }
                        panel.Controls.Add(customSnapInButtonDiv);
                        using (HtmlGenericControl customSnapInButton = new HtmlGenericControl("button"))
                        {
                            customSnapInButton.ID = "LeaveRequestApprovalSnapInTimestamp" + DocuVieware1.UniqueID;
                            customSnapInButton.Attributes["class"] = "btn-valid";
                            customSnapInButton.Style["margin-bottom"] = "15px";
                            customSnapInButton.Style["margin-left"] = "15px";
                            customSnapInButton.Style["height"] = "26px";
                            customSnapInButton.Style["width"] = "80px";
                            customSnapInButton.Style["display"] = "block";
                            customSnapInButton.Style["background-color"] = ColorTranslator.ToHtml(DocuVieware1.ActiveSelectedColor);
                            customSnapInButton.InnerHtml = "Timestamp";
                            customSnapInButton.Attributes["onclick"] = "addTimestamp(); return false;";
                            customSnapInButtonDiv.Controls.Add(customSnapInButton);
                        }
                        panel.Controls.Add(customSnapInButtonDiv);
                        using (HtmlGenericControl customSnapInButton = new HtmlGenericControl("button"))
                        {
                            customSnapInButton.ID = "LeaveRequestApprovalSnapInSignature" + DocuVieware1.UniqueID;
                            customSnapInButton.Attributes["class"] = "btn-valid";
                            customSnapInButton.Style["margin-bottom"] = "15px";
                            customSnapInButton.Style["margin-left"] = "15px";
                            customSnapInButton.Style["height"] = "26px";
                            customSnapInButton.Style["width"] = "80px";
                            customSnapInButton.Style["display"] = "block";
                            customSnapInButton.Style["background-color"] = ColorTranslator.ToHtml(DocuVieware1.ActiveSelectedColor);
                            customSnapInButton.InnerHtml = "Signature";
                            customSnapInButton.Attributes["onclick"] = "addSignature(); return false;";
                            customSnapInButtonDiv.Controls.Add(customSnapInButton);
                        }
                        panel.Controls.Add(customSnapInButtonDiv);
                    }
                    DocuVieware1.AddCustomSnapIn("LeaveRequestApprovalSnapIn", "Leave Request Approval", icon, panel, true);
                }
            }
        }

        /// <summary>
        /// Triggered when the user clicks either the "Apply Timestamp" or "Apply signature" button
        /// It retrives the native document depending on its type (image or PDF), create and initialize
        /// the proper AnnotationManager object that will be used to draw the annotations.
        /// </summary>
        /// <param name="customActionEventArgs">The arguments received from the Global.asax.cs custom actions handler</param>
        public static void HandleAnnotationAction(CustomActionEventArgs customActionEventArgs)
        {
            DocumentType documentType = customActionEventArgs.docuVieware.GetDocumentType();
            switch (documentType)
            {
                case DocumentType.DocumentTypeBitmap:
                    AnnotateImageDocument(customActionEventArgs);
                    break;
                case DocumentType.DocumentTypePDF:
                    AnnotatePdfDocument(customActionEventArgs);
                    break;
                default:
                    customActionEventArgs.message = new DocuViewareMessage("Document format not supported.", icon: DocuViewareMessageIcon.Error);
                    break;
            }
        }

        /// <summary>
        /// This is the method that is dedicated to process image documents
        /// It retrieves the currently loaded native image handle and initializes an annotation manager object from it.
        /// </summary>
        /// <param name="customActionEventArgs">The arguments received from the custom action handler</param>
        private static void AnnotateImageDocument(CustomActionEventArgs customActionEventArgs)
        {
            int imageId;
            GdPictureStatus status = customActionEventArgs.docuVieware.GetNativeImage(out imageId);
            if (status == GdPictureStatus.OK)
            {
                using (AnnotationManager annotationManager = new AnnotationManager())
                {
                    status = annotationManager.InitFromGdPictureImage(imageId);
                    if (status == GdPictureStatus.OK)
                    {
                        if (customActionEventArgs.actionName == "addTimestamp")
                        {
                            AddTimestampAnnotation(customActionEventArgs, annotationManager);
                        }
                        else if (customActionEventArgs.actionName == "addSignature")
                        {
                            AddSignatureAnnotation(customActionEventArgs, annotationManager);
                        }
                    }
                    else
                    {
                        customActionEventArgs.message = new DocuViewareMessage("Failed to initialize annotation manager. Status is: " + status + ".", icon: DocuViewareMessageIcon.Error);
                    }
                }
            }
            else
            {
                customActionEventArgs.message = new DocuViewareMessage("Failed to retrieve native document. Status is: " + status + ".", icon: DocuViewareMessageIcon.Error);
            }
        }

        /// <summary>
        /// This is the method that is dedicated to process PDF documents
        /// It retrieves the currently loaded native PDF and initializes an annotation manager object from it.
        /// </summary>
        /// <param name="customActionEventArgs">The arguments received from the custom action handler</param>
        private static void AnnotatePdfDocument(CustomActionEventArgs customActionEventArgs)
        {
            GdPicturePDF gdpicturePdf;
            GdPictureStatus status = customActionEventArgs.docuVieware.GetNativePDF(out gdpicturePdf);
            if (status == GdPictureStatus.OK)
            {
                using (AnnotationManager annotationManager = new AnnotationManager())
                {
                    status = annotationManager.InitFromGdPicturePDF(gdpicturePdf);
                    if (status == GdPictureStatus.OK)
                    {
                        if (customActionEventArgs.actionName == "addTimestamp")
                        {
                            AddTimestampAnnotation(customActionEventArgs, annotationManager);
                        }
                        else if (customActionEventArgs.actionName == "addSignature")
                        {
                            AddSignatureAnnotation(customActionEventArgs, annotationManager);
                        }
                    }
                    else
                    {
                        customActionEventArgs.message = new DocuViewareMessage("Failed to initialize annotation manager. Status is: " + status + ".", icon: DocuViewareMessageIcon.Error);
                    }
                }
            }
            else
            {
                customActionEventArgs.message = new DocuViewareMessage("Failed to retrieve native document. Status is: " + status + ".", icon: DocuViewareMessageIcon.Error);
            }
        }

        /// <summary>
        /// Draw the signature at the given location with a given size from a base64 encoded PNG image
        /// </summary>
        /// <param name="customActionEventArgs">The arguments received from the custom action handler</param>
        /// <param name="annotationManager">The annotation manager object</param>
        private static void AddSignatureAnnotation(CustomActionEventArgs customActionEventArgs, AnnotationManager annotationManager)
        {
            CleanAnnotation(annotationManager, "signature");
            const string BASE64_SIGNATURE_IMAGE = "iVBORw0KGgoAAAANSUhEUgAAASwAAACaCAYAAAATmXWpAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAGYktHRAD/AP8A/6C9p5MAAAAJcEhZcwAASdIAAEnSAahFivgAACxYSURBVHja7Z0JlFTVtb93VU/MMwJO4IDigEFRwYcDiAScEFAGaUHolqmJigMOQRSMhhhQkUHbAUUURDHYojg+J/RpMIQ8TbL+UYyJeQ7vaYwGlwNizP983F12UVR33+qu4d7qfdb6LaCprrp17znf2XufffaRf//73xJGVVVVSWFhoaS57eY02mml01NOjzv9ymmN0yqnCU7t4n+hqKhI1q9fH8p7aDKFTaG98DQDq7XTVKeHnZYotPZ1au7UxKm900lOdzk94NTdgGUyGbCyDayI0/FqUQGqI50Kank98Jrp9KjTngYsk8mAlS1gtVX4POR0Guzx+Xt86M+cljqVGLBMYdRnn30m3377rQErJMDCpbvH6edOu9cz1vWs0wADlimM+vzzzw1YIQHWcU7POE1Sa6m+7XynxQ5YBQYsk8mAlQlgDXJ62WmsU7SB8a8DeC8HrP0zBaw333xTFi9enAkVOXV2OtRpoNNIp9H652SniU5nOZ3k1NNpd6fiyspK+fjjj23gmAxYWQBWf6fnnIamaWWxmGC9A1ZppoC1ZMmSdKZs7O1Uqm4wK53rNH5Hukal0zyny52udLpC/32r0wpdPV3epEmTy5ctW3b4xo0bmzlJLvXOO+/YADZg5S2wjtKVvdPTnLc13QHr5kwBa+nSpQ29vrYK6Js1rwz4XOg02GkfpxZ1uMURXRntwmpqJBKZ1bx58wdbtWr1kNP5Tvs5SRYUcTrAabzTQqdbhw8fXv71118X2yDOL3333Xeybdu2XbR9+3b+L9IYgNVDY1ZnSPpbfwesRx2wmgcMWOSPjVFIYUWdp/chHYlrrVhsUAj+p9M1ar1lopXoZ2FqbhAvibfcaUS7du02bNq0qacN8vzSypUrZciQIbvolltuka1btxbkO7BYzbtHB2w0AwOqkwPWOgesfQIErKMUUo85nanwylQ73Gmxutpnq5ucjoZVR6oJ+XEvOF2kwG0a+/+WLVuufe21146wQZ5fmjNnTtIOMWXKlLx3CbEEFmhMJpqhAVvsgLXaAevYAACLQV7h9KrTDHUHs9G4t7jaLzrd5tS5ge91oniuK2kj05y6JnndQbvvvvuGLVu2dLVBnl+69tprk3aMadOm5TWw6PiXq3XVMoODNRKNRpesWLGiNMfAaqdwxkXrJ7lpuIWr1G3bsx6/D5h+rtbatDrAN65fv36PORehiQ3yvAcWYzmS78Dq6fSg0yFZGKg/veGGGy7IIbD2EG/V7y7JXCzJb8OqWyjeAoffa+EhnqUW1fwaLKrEDnzXmWeeOYsArQ3yvAcWYYYSB6xovgKriw7g/8jSIJ189dVXz8kRsMjSv9fpl+K5wEFoxMxwDe+T6phTbVZVpVpVJ0vt+zhjjU3pr48cObLvv/71Lxvk+QesiOwawslbC4v9gLOd5kh6VsT8tDMvuOCCa3MALBJXn3Ca6wMM2W64hMTSflzLa9hxQC7Y7ZKaJUyc7jEHrGYGrLwF1i5jN1+BRX4RMZSOWRycI8rLy5dmGVhYVlXqQjULGKxijUnj1iSzJXAlRkXKxek+rapYI83hEaDlgCUGLAu6h0br1q1LBFYH7cyDszwwzxgzZswyN3giWQJWG/GC2zcHGFa0w5xeceoW97O9xIu1rRYvTSHV1ke8NIc9DFiNDliRbdu2BS9x9NVXXy2cPXt2gZPUplGjRkk0utPkPd1pmXjL+9lsQ93guYss3CwAC+vklzrg20qwG8+BLT1j9N8HO63V69+tHu/Hw14o3kpixIDVqIAVqaioKProo4+KAnfBCxYsiErqeVNddTD0zMHAPHnYsGF3bt++PdPA4p5Qv+sJqXslLSiNbUC4hWSrk8x6rvivO5bYDhIvLvYj/mHAMpcwELrpppvqM/NeJ17MJJKDQTl07Nixd2bBJTxV3aGDQwIr2rFO7zqtd+rbgPfhGbMZe0FsMjNgGbDCCqzD1OrolqNBeWp5efnCDAfdsS6el/RVmshGI8B4qdP/SMNTTNhu9JLE1dI3YBmwwggsZtsbxNuAm6s28Jxzzln4/fffZ8rCIlOfJFhKvhRIOBrPZaJClsD7Hg0E39LEZ2zAalTAKibong/AwqpiefzQHA7O088999wlDliZsrBIASBVo3VIYAVUxyhkeou3CXv/Brxff7WuuhqwGi2wCkaPHl2yadOm5mEHFkHdG3M8QEdOnjx5UYZcQmpWUSH1xJDAqlABe6d4uWLkw+Gu71PP96NeF8H6qbvcdANWo3IJy8rKCt55552SMAOLLSAs7/fJ8SA9t7S09MZM7Gu7/vrrZ4i3yhYWV3CaPpNu+u8DnZ526lTP98OtJBu+jQGr0QJrx0JaRUWFhB1YWB0PSGbrPflppTNnzrw6E/di7ty5lMYht6xIgt9YEKB+1X5xPzteLawW9Xg/XECqTwxK9p8GrEYDLPL5ogTd//a3vxWHFVgFanlUBGCgTp03b96VGXIJsVQyVS01nY3rq5JdUy7KFWKpWohk8C93uqUmWBuwGpeFFfZVQmbxZyV3qQw7AeuOO+4YnyFg8f5scj40AN+zpkauFUm7fZN0tEXirW76bbE8ulIFdY1nRhqwGlcMK+zAOkMHQ6HkuBUUFMxes2bN8AwCK8gNoFD76rQarCTiT6ksGEQU0HUWIjRgNQpgleSDhUWOD4cSjArAgI0UFRVVrl+//tRGCCz2MpIDN7SGiYNUhipJbd8gOWf3O10vdWzPMmAZsMICrA46EA4LwKBt6YD1uAPWMY0MWMSVOBjiSql5QaBMvBLVBXETTV0T0dXi5W11qOsCDFiNyyWcMGFCMdvfwgisIToLB2HlrKMDVpUDVrdGBCzAwiZmqorWtEKLxbVCoeYHVrHnSs6Zrw3sBqzGBaypU6eGNtP9F06zAjJ4D1RgtW1EwDpavLpjtWWvkyj6ovjfqM17sbF7rN+LMGBZ0D0MwGLmpob5oIAM3uMdsB5wwCppJMAic73KB1hGildk0M+iSHN9psTDfJ9raMDKW2Bhjf8Quwo7sKhYyUbgzhKMdo4D1q0BPqo+nY1YFOVdODCituKBRQqg6T7fk+z4hyXFgoQGrLy2sArzBVgDne6Q4GxVmeWAdXUjARb11zeLl71eWyNnDPcucf9gtIbn+azUI8/MgJV/ogjmFVdckXRshxVY54u35B2UtsgBq7QRAIt6XL8Rb+WvrnaBePXmi5JYXsVxkw21rUgOHV6fCzJg5Z8+/vjjohEjRiQ9rq68vDwSyBLJdQCLqpPnBWQQM/hWO2ANzHNgsQ+QFT9qqZfU8VpOoKa6aP8a/j+iIqmUPZL1rvFlwMpPzZ07N+nznjJlinz55ZfRMAELv3ah0xEBARa5QuscsPbPY2DhxlE1lBIvfmJMJPM+Ijuf5pN4MCabWa8Sby9oi/pemAGrca0STp06VQJ5ak4twCJjmtIlQQm4UzrlYQes1nkMrNixWn5iTFic5MeVxcEu9mc8sMi3oiDfQQ25MANWowHWjlXDyZMnR8JWrYE9ZhSGy3U5mVgj+LzcAaswT4GFlURqwoU+X8/eP0rJdFKrqiDOwoq1Xk6Pi3fqc4OaAatRWVhNp02bVhi2oDvVAJZI6keAZapNcrrNAUvyFFjkUlGT3c9eQALqZL4TcC/UZxQPqoi+D/XLpqfjGRqwGpdLGMZVQo65ukKC01itvChPgcWhES+K/8zzI502SvVpzpEk1horh9S3KknHBRqwDFhBBxZ1vacEBFYEjgkuD8lTYHFCDdasnxU8rCXq6l+nfy9SReLgxcouhfw6pesCDVj5qTlz5iQ9W3TSpEkFHPQSJmCxsjQmIMCifC/B6O5ZBBbw4Kj6tjrwWXzYS60h4nuHi+c28+fxCgkC4CRnUmRvmNPJ4iWAUk+MGlYj9e/kQp3pNEJ/Z4vTbP35sfq+nC1IEP4Q8Qoocg/20Z9v0j+L9DrjXT4+k1SH7ul8AAas/NSyZcuK+vTpE3GSOBU6y6vZBx98UCTjx48PlI466qia+iiz+EkBARaDkzIozaPRqAwcODDV7xlxKnFq4bSXUzenvk4nOw12OsOpzD0oNnmTmMKWGNIAWHS4T7x4ERn/K/S+3Kq6XbxtMazWLRevyCGWz2X6dywnZgTy2a7QSYA/r1RA4ea+I15gfKlaWbHN5gv0c5epCMgTk3rb6T2nu8TL1eJz5uvvzHD6g1qjAPMU8YLzbKD+kQKvZRzo/M8YXbumdM9nz55NHo9BIeDatm2bbN26NVGRr7/+OrIjrSEkjRm70unHAbkerJd7avl/As/kaXUTb/megTpBvBr0FQqZSgXCKh3ov1S4/EzBMlotnrPFq9rZWy0brKo24p1TiHBPi/UzGfQlCS5ZKg2Lqkq8BNBkLfb+zfQaiF295XSOWnlH6bWeqt/zA/H2fs5W8C1WkFKl9Enx8rvuUzguj4PrTH3Wp6qFRwoJG6/bx33XlFrPnj3ls88+MyhkUbhwlZWVMnHiRD+KOhWXlZVJEhUuWbKk+JNPPsl5hWG/rUAtiuMDcj0MPorN4Zp110GFu1qq1sU8tXawNuaIF3DG4pioFsaROsC7KByKA/CdWqklNDqF38E6u6kGgExXWHVM+DkwJWG0rQoYHaaAwl0dqeCao++NNcdRYRyY+5p4h8req/AD9Bcq2HF9cVf3iQP5D+2II47YMVsbSLInXHZcd58tMcF4pzZp0qQI7xeWRifH5ch2ljsgaamDAMgQj5khXsyGAXO3XtdCHWCUCyYxsodaA00lOGkYdTVgukbB5acBmtcleU7VQIXMQWm4LmDYWd9rsHhW4AniWa3nKTSxTrFUsdaw3rDcVivwmCjO6tGjx6BXXnml+xtvvNHJqalToZOEQe+//35ogTVmTHrCzqNHjy785z//GZbzOXcAa1GaBkBNjVl/X/EsoGEKIGZyLCXiN1hJbFPBZfmjDkrcvmZSP/crSA0r6CkFgp9Gx7lFYZ1oHcbOEzwrB32ECQKrF+v1GJ1AsMAuKCgouL9t27a3tmvXbo3TaqdVTnOdxjsNcDrEqbNTEycJki699NLGDqzIeeedF6GaQ1gGVCudQfdL0/sBGawmrKGfiBfYXqozNLElrKcx2ukZgMRtYpYSJXxxdVLNuGdABdUHx5W9TfznSOGaY10l1tVvqhCbL8E7/JXrwU0kBoiljvtJLa6r9JljkWGdLRdvgiKONk77wJ7iTU45sZbZR9dIgJXoFjIZEjLpOG3atOiOPKwQAYvO1Ksev8sNYNbFpSMREjfhXoUTsRIy1k9RGLaWXbO0E9toHZTRelxHEN1DBuKDOjD9NKDEgsMFSe4TuXJsz9k9ND2r+tkwATE5AeFh4k1kLIrE3Msn9d8silwunvVGn9pDMrxdLJY02QiAxXOId/v4+468PncPImECFjM/K2vdfLwW144ZkTgHLhyuC0mLxJtYvif/iM28bep5LbN1sOZLI3ZFSoTfwD+pJa/IrpvQydF6Tv/Mpwag2yvI6FOMQKyyRQozcsyqxLPSgByWGxYck2QTA1Z6Ylg/ZLqHpLXQDrF3DTCjcxAQZ9WIU4ixGJgJOd2FFbzdJT0rcbh0WFcnBv+W+WqddMAd7fP1uNIE5rGk4q0rrAwSafMJ5H7vR1ftY/Q13Mh7FGBYmuSpxcILrGQeo324jaSQd2bACh+wWKmj7ncPqd5ISydhBWi5eEvd87RjHK7/n4kAHfGPF8X/aTBBb+RKMRH4ja2NUcDF18ZiIsCKxYJtkif3pSGtUPsr6S7kzhEHu0S8GOljCrPHFWyxSRWQxZJoC/IFWORhNVZgESPAcvqpeDPWOn3gDDiyzpm1shEfYgWR7PKSLHxWRDJbux43h7iM390DWBJUbzg94eej9Of76r+x2kgg/VGW7lNYGs8TT4HcOyZVVpnJVZunfRmvgFzDheJZaiTjkjJySFlZWYd//OMfhU4SJn366acyYsSIRgOsqA4SltqZwf9XQRXLqs7FYLhYvBXFbN6DTDX2DBLba+rz9bN1MMVDFCviJX1GAGuWvicrjli9C6QBVUUbUcNKbSOeBQ/MSKIlHsaOh5UdOnR4oFevXj9zusRpstMgp4Oc2jsVOEk9VejUogG/X6fatm2blhsEsHZsfg5gI5hLugGrebiBD+jgwrIZlsPrKtTBeHoeDJCYxer3u5BBTm5VvCuM+8JqKzE9VloJQGPx7q1Q66D3Cysi7HlquX5WxAiZHJgYOIiFiYBV7uXieR3UZGETOy4o4RC/E11EQpLYTMXR9957Lwg7QnY00hYwkdnugp8PrEhBwHyOWVL834gcXmMbHZT758EgYLULa9XP9Aeob9VnEo3r6Aycf4qXj3VDDfeFZ0rMy6ys9LeYe0k6DnEwMv6xbHEtyYObIV7qxRH6nJuG6Lvtshd2/PjxBW+//XbLXF4UtGSpmExkZmISQ/HdD5Tk1Gf2Lsvh9bKSBrCCUqK5vo2OS4D8HJ+vBzpkwcefM9hLvAoNH+szqck9x1rGktvT+JK1gU4YBUuLZGDSeIAYCyuAjC1MsSA/McygbnXZxSKfMmUKFRtycr1txHPtYvu+gBQrfnWtME0WL4aUqzZdH3jY3Zuj9N772TPIa3DLx8X9jNmaYP3/ibf9prb70UwHymFpvH4sPqwKqliwTepnKmJsxH7Mmtu5YRh01OfOTmRcSIwDkmHZWM4KJilBuYoL+2qlpaUFn376adZ2itCp8cFJ5GRTLNTHvUulAiVxkptzdL+4fqySq0LeebFcrxH/rjWbi38VB4GodvivxJs86oJ3if5+OuqYsQuBHQm4p4/pn+SDEe8kFlehA7FK/OeVNdaGlY0lNki83DlWKTnUFohhQAyQNFaHTUcbPnx40caNGzPu3WCiUq2SciyAiiDtqVK/WZCA4wOSmz1qXO9afcBhbgRvKQLY3sdrO+szGxj3M1yJj8RbivfTeQAcoD+tAdcM9IjFrNNnAERZTUsGS2IcgHSDeKtt1vw1LJc9tX+z0ksIAIAxKZC2Atxy6T5G+/Xr13Tz5s3NMvUBdDJmVVaQntSb0E0atvmXToor0y4HN4ycItzX1iHvmAz2y328js5J9dF7pNpNANpV4llMHVL4TBImx9XzellxvEM/F/fTT9AVkGHJ44pmrIPneWsjXrCe+7jc6WXx3Ecs2bZZvpYd9dPKysqi33zzTdrDMcy6ZyhYsIY4NCJdB58yYAjO98jBAyzXBxeW2lbJGh0NV8rPJmes4s2y8wGqBGspn3xIip/LdqlL6nG9bCxmewvxqfYp/m47/d10VqjlPYnF4S4NE8+tJkxBXIiEYmJAYZ/QEluBjjuC+KxCktryrHhFA+hHWVt5rKiokC+++CJt44+AOfSt0i80Xuq/ubimhnWGezEkyw8NqmMlXBTCDhfvevN82BJSl5XCs2RiII0klvdC0JZjvFh08NNp4l9D+sOcFAcJEHhRgVDfEAAB+ZukYYskDMj+4oU0WHygVj6bnsmDIpUDmBJXxfrA8mSfJe4y4Yv2Ev6WWGGknX430ibY6E6FWkr0HCjpXYyKP8iEv0cA1vvvv9+qoW8MRNgaQ2yKGY2VtEyWFpkh2U9toNPiXvQNWWfrJZ41FFEtUQjV1YbKzpVH+V0CsX8W/3so4ztvhQ5sv/2JDO/firdy1ZCG1UMspk09fhfY4IIShCaPDPhRPLJ5DQOzUAfzIdo/AViVeO43sbSg1QZLRyMHbIJ4MdFXxZvUye9Lx37S+BJPTJpRgPXJJ580KOhO52Vf3yvayTpk4SbRif3O8ulqrG4ul3CZ+2Q7E3yOxRtwy6mm8B91/B6DG7fxjLifdXP6nfhbFUzW6NSLfLyOQU3M5EXx0lwa2gAI1n4q5W6wPslPY7GBkMaZUj9LiUFGDIjYLcCr1HsfmEztNDbGIi4j2fYsdhDrJRS0Zxrfv2lD9hIyGEhIA1RQ9dAs3hyyqVdlGR7jtcMla7hcxDX2ClAHAjpzxDPTY410gCel9tVZrITr9JnGxyaIVZDjVN+Zc5h4rlRtCy5c1zUKq95pug/AlfSZ830Oiv7iuTi4dtSNT1fAnskCzwMIsoCQL5U+kjWSi4n3PqzPEuPiWGlYrIvnWDxq1KiiDz/8MGVLlc5E4A2K9pHsB6EBFWZ+NupRsTqGCTq3hk5PigCraCy1ExvqEoAOU6BwOivu2fCQ71Mg1NYIGmPaH55kMDfkOZOwSDWHDrU808XayfdN8/2gOmxlHa8hCfUWqY6ZZSrxlP4C+DdofwpUnlOaG5MbuXAA6yUdI+MbMEYKysvLo6kAi6DrTL3ZbKVplaMbAW3niL9Zs6HtIh3kxHMSXZT2+vN79d6wMXtyADoKMQTiLfHWDJbW7xQcNTWsCWJcF6cIpwIfr8c1e0aSJ3MS72Qh5YE6OjPfB3equb5fO30GHaV6Px2wI870I/0sYo7sR+WEo2F6b05UsdJ3vA6iP+j9IfbECnR3fT/eF5e6jUKsqdTzTMSE1ke/89Paj3fLYv9opvecWNvheh/IkSvVe8X9IIiOlXSOaozeO35nL73vzVLoJ3weEwF5dIQlMACOEf9b3HaEIUaOHFnywgsv1JlSAdFYlXtKb/KRkvutKdxk8rsyuY2AGQKrCb98tewcx4goyLAIYikbU3TA5/LeMMiWy65HwtMJH5XazXJig+Ta7JHiZ7atpePG6nlxL+/V/rOHQgUwUOuJGNO74gWny/U+AlxcU2ZnVuMW6r29Q6oPiohtK1mqfYFVzfsVfHfpa+/UPzno9ffiWXGU2V6kz46tRW9r335Q35NJiP2iq/T3saCZjO7T979T3/9mHXiERmaofqIDf5BCsZ9Cs5d4rtJuCtpmCkBiWvP1Ws6V9IcVogqLfgoh7uEjCspHpPp08Pv1/i3We8N3q9Tvzj1eq/elSsfEE/pvnuc8/d6nKogP0mecDGpN9DVYmY/pPZ6qE01hLd9hh8XrXMLCv/71r7WO+e7aWXioF0hwNv120C+cyTMK6WT/T7xVtRk1/N8pcT87yQcUMtmaaee6MuHnzbWjldfyu+21U07x+VmAiI7TSgfE4TowT9EBW6aDuVLFMWmkRHyocPq76s96bTfofaYjY8UzG5NoOlzva3/xrCZOKyJeeoAObgAQO/26pYrOXaygLNCBwAT3n/o5fEdSHZ5R+Byir2+iv9tCv1crfd8uOgD3088/TAfdoLjvO177CKAl3+wq/Yy79Jks18G5RqrPTrxTr2d+HDzfUqCermMvdq6ln0A9r+usY2KYeDlTyxQuDyqIJukksb9+vyZx9ylaw3NGsdOGWuu9IAaHBXuacoFnfasCn+e5XieBGNTu1MnnF3qPpuoExST2O/3e9L8KSW5l8/2Lp0yZUlDTQaqt9QvHliqDuLpxlX7BTDU21r4v3gx/WgLxl+rNjg/KEtt7WbJr3sdagXZGOk3iLoATZNeSxomNTvSIVE9IsWRBOmcPfQ8Agrs4p7i4eHFJScl9Tg86rda/3+l0k9P1TjOdxjgNdurrdJjTQU79nJY4Peq01OkEp2InyYL2d9cdy/IvUwA2y8JzKVS4xwb7XgoMJj0sn7F6PVzXLVKdHvSSjr8XFK6VCkPCDmepJusEdZcC4jkVVuYc8dJT9pPsla3mc9rod4y5nFiaJO+y6jxBJwzYwi6Km3V8AVbcRSb8gTXcx5KysrIWH3300S4xrKOV+M/r7BbUzO5jdKbKRKdjVmE5+v+0w8QvizO74F6ckvA7scNDu+bgXpylHTbZZ18rO1tdUameLbvq98DSYRYmnnKdDpxl2vH58zbtWBc3bdp07KJFiwY988wzvZ0OdNrDqalToZP4VCqvTZtuu+02adEiFIUc6NPddPAyKd+gUFounsWyRP9NPHmLeCV+3tdBjxUDmAcrNDpKzbljQWqx47xq4k1x9+7dD5w1a9YP55IyC2Cq/bd22g4B/4IMOkzN4zLw3lgpWCVsQ9kk1VYLD32ugjLRl2bFh5nwwCzfByyF/5Lqagg8+JbaUXHTfqMdPGa609GJyRC3IFbzvwpaKjAQYMWaPEoHDO/RNL4TMeBff/31UB6IwJHvbdq0CQOw/LSIgggXChe5t04+WNrX60RDXCoWl6tU8GHJDdd+s7f425uZi5YIruiAAQM6P/HEE21jgx9IEV8g1hHU04kTG4HKBZJ+KxCTfZ0O5BVx70+8hv11Zyf5HUbCs5L5bPhY/IgJ5TD9TLLC54iXTR6rpb5Wrx8gYXrPEC/werp2VqyrYeLFAn0H2gHWa6+9Fkpgbd68OZ+A5WfAN1Wg9VKYMbZ/qn3kXqneSsRENlX7A57LXpLb04+4dkJQ8VVHm0+fPr0ktvkZ35ggaBCW5VNpBBlxZdJt1QAdrLdY7CDWyHomQNgtye9gxmOVxfvg3PT6zGAxKGHhsILSX6oD2Yv12qqc/kc89/QX2uGAEfHGQxVIE8QLtiYDeiu9dxNSuTADVl60iAIJr6C3gor+w+SP1R1baWXhgEWQc3VM0O/bS/bi2YVxwOo0ceLEZp9//vkOY4pB+JJ24vgXBf2m08ggvjzN10yAmVUrrJQnpXrViRUcVnmSJa/RAbBWYrEtzO37FXpDangYwAyrjZUdVrLY8DtDPNOdlTVcT9w5qh1co991oHYero0Yxj41fIeowq2magUsRT8qKebTGbDyvtGPmSgPVpBhzFyvfT92FNnd2kcna58l1YltOA2JJ0frGMN79+/fv0tFRcWOpGZmb5YX5+ngCsNZcrEcn27iLRKk62CIqAKCmM/bel/a6UMknjW2lut5UP8/tiXkeb2n/N4Jem8JiBIIX6oPHtOcXCGsJ0x2MrMxy1md6yK7muZ0Cly8p7Sj1NQ6KTCTuXutFa4pF9UzYDXaxrhggsVyZ4Ilb2+a9u9YLtwtCjestViy6QH6e3WFbeoylCJDhgxpOWvWrB/GObP2Gh2kzO6namcPQwE0ltuvlvRYWXxfZhKsNly8N8RzOQ9WAHVJuMktFA49FAIr9EHiYv9avFgYFTo368PESsJ1660PHxj63W6wuwLuWR+A5jPmJ+koEe1QqZxHaMDKcevSpYscd9xxQVWBUyunrk7HOo1wut7pLqflHTt2XKwwIxVprLKGMUVIBwu/tkqmEe2nXZxL2HLLli07GVPM5mxBIQBPwJYVJqwGzL5DJXfbcepqgBX36ZA0vBerEAv1HpAvQsIjuSNYQG9KdSb2YoVTLMDNn6QHkAdDXGm1zkLcN1ZlSI/o2IDr2l8Buknq3jzLQ8aEn5Dk/zCpX5O6qzbkJbA41DMSidSmAqcmdbwm65o0aZJ8+eWXYVPBF1980WzkyJFM8qQGkYvFSjRxsQU6+d6jffVC/X+8iwOk2rso0r+3oVrDhg0basxLYSoi6WuOeEmFz8nOhf+P10HUWoIR84LcmKapBARL1MIhsN1LrRLctf92+qNaSAS2/+r0uXjWFu4bKy3EuQbp7+2t94sZBBeShL+eCZ8D3K6s573iIWJV3ST+Fhha6zM7IgnIiIXV2xoNM7A4On3NmjWycuXK2lTk1LKO12RdYU0l4aRmB6xkXQkQEcDfR2FGWs54NQxuUQOEPyk3RC7aCOcSnnjfffed4Hdgd1brixgMafasJrAnib1F5Hz8XN/4ZB0o3XQQF2cJaOSksHp2ml5vC6leZcMi6acEr1AoETS8W2/MSrWQ7tXv8pwCa7h+1w/Eyz4+oI5rwDUk+ZJAd6IrxkPBLRycwncCPDPEO6h0SgowPlQtvMQVSmJeL/n4HnkJLFNugDV//nwZOnRoKip26uC0r1PfoV4bO27cuJmTJ09eUN++20RNNWIxBNiu0MFN8G2twmydVO+bWqSWyXSFxhT9vVFKVwbT0Wq59dZ/99I/++jP+6tVc5xafyP0fYg3zVOX6S9qXTykEGJV7za1DDE9qcBQrp9JHhPuZCsFXJECd5laUoUKoQnS8KB+VL/3G/o9JIn1E//3o/Q+YrENTBH6TCqJ+Wl8t4Vq5dU7b82AZUpV3333nWzfvr3BYh+he6+0Gz+x3dUscx6iEMLVmqyqUJfkGrXKblUtVwvnIaneGX+vWj+4U0t0wC3S12MuztH3+am+79n6/+SRxDJ5W6tl4neQAlRiURdkwAosURP3NwrZfWXngDsB/556X17XCSDVA0iL9V6OT/g5luevGwpeA5Yp1wpCi+hAi6kkQYluZW3w6aDW0YB6Xgvu4heSuQKBfI9YDfyX1AK8QWGMRcVK5M1Se+2q2hoxLhZM9kqA2CrxX43BgGUyYGWx4ULiFqZaijaisHtPUq8LlWrDsuqhlg/W4USF5N4NfF8WHx6SneNdwA/3vMGVJAxYJgNWZqwY4mMrJLVN3ECEOBgrcqHY1p+k4W7fEvdvclgIwKelQqsBy5RzYI0ZMyZsivAnSWvkqNTQSEYjzQB3y2/mPoP7RfFiSGFsfE+Sf0fH/YxFCtzMtBy9ZsAy5RxYLD2GUWvXrq1rfLGsTxB+jvjbfY7LROWD4SEFFqu2pF/EagbxnYldTUvXBzRp0kReffVVGzim3AErrBdOMh1JaSNGjKhNHY8++uhl0Wj0Gql7KwqrmmSSN2glDavPfWZd15VW9evXT9x3ZGWUFdZY5dDR7dq1e3Xo0KG7p+tzSktL5a233rKBYzJgpSqsLHI86tLTTz/dpVmzZvepi1ibe4j79FachVKv5sAhq1at8nVt6dL69euluLiY+uLknMX2Xz3swDnxs88+S+tncd9t4JgMWBnS888/L82bN8fdi512UtOePnKk/igN2/O3A1irV6/O6nd88sknARYpGRfpZZCH9USfPn1ab9261Tq6yYAVFsXt0m+vq2hsuEzck0du10p1CVuFEFiFDlgk256h1hV1uCY7YIkBy2TACpF++9vfxpcVYbsNO8YpzBd/kASboNk2Q52p4hACq7MD1oviVWNgvyLJo50MWCYDVriBFWsn6Qra+bqayBYY6lZVif/6VEECVm8HLKwqEl7XxlYGDVgmA1Z+ACuWBsDBDdREp7jeK3FB61ABa9WqVaPd5wLg/uLtQ9zHgGUyYOUXsGKxq2HiHen1ssJLwgasWbNmUS1jnlQfOV5gwDIZsPIDWPEHNjKwqfXFXjvKQ1PR4OgGWFmRbAPr+++/j0ycOJFqFlSpeEHiKq8asEwGrPADq7nsXPGB+BVbWhj01MJarquJB6UYz+I9i7INrG+++aZw8ODBwOoTSSiLY8AyGbDyyyXEkhqt7hQ5WmzL4cUU+aNyAwdyzBavNAuri9Sx+nFtFli2gfXhhx/u1qNHjz8kS3o1YJkMWPkHrNkKI/YdxhegZvWQiqcT9DVAjS0+Q6SWmlzZBta7777brUuXLpRxviLxWo488kgDlsmAlQfAisTlZd2sYKIsy8lhC7p//PHHHcvLy+efdtpp+ztJvC655BL56quvrKObDFh5YmF10GB1V926c1IYVwm3b98e+fbbbyVR1MK2Tm4yYIVIdRygeaQmWrJt5+6wAstkMmDlgTiLbsOGDTsO0KyhTVdQ4SL+XFMaDFgmkwEr+/rLX/4SefbZZ2sCVoGmMVyswOKg0oMNWCaTAStnqiWG1ULzr3rrqh8pDEcYsEwmA1YQgUXC6GsacGe1cKkmixqwTCYDVuCARc4Vp+RwgCklZTiwYg8DlslkwAoisDi2fW7cdp2F4lVwMGCZTAasQAELQLHheVRcVjt7CTsbsEwmA1bQgEWNd87rO1z/3Um8E2c6GrBMJgNW0IBFTffnpPqA0U6a4tDOgGUyGbCCBiwqLnCEe+yA1a66StjMgGUyhRxY3333XWTbtm3RPALWTI1ZxRpF75aLvxOiDVgmU5CB9fe//73JO++80yKPgAWszo/7N6cm3ykNPDHHgGUyBQBYnPYb1hN/kwCLDPenZedSMseqi1hiwDKZQg6sMCsJsPZ12ujUM+5nfXWV0Cwsk8mAFShgEXB/PSGFYVhCTMuAZTIZsAIBrJ+IdzJyiwRgzUsXsO6///5IWF1ok8mAFSxgcWjqjQmcOdvp2nQB67LLLtvtyy+/LLIOZjIZsBoCrAJNX7g8gTMTnK5LF7BWrFhRwHmB1sFMJgNWQ4BF3GqT04gEzoxzusxiWCaTAStIwDrA6U2nXgmcudCpwoBlMhmwggSsPrpCuFcCZ240YJlMBqygAWuieEX7ErfgcDbhaAOWyWTAChKwhimcEhsn5pxkwDKZDFhBAtZMBVYkjjGxlcMBBiyTyYAVJGBxlNelTkXinZQjuh3njiSBeAOWyWTAyhmwsKSoyHBKAmMo2vcrp/0MWCaTASsowAJMLzj1S2AMB09Q372rActkMmAFBViUQ37KqXsCYw4Vr9xMewOWyWTACgqwDlYLa/cExlAL6wnZeTO0ActkMmDlFFjHOG2QXU/GYZvOSo1xGbBMJgNWboHVunVrWDJJLazEgyYm6yphJB3AikQi8sADD1jnMpkMWKnrzTfflAMOOECaN2/O5uYqp8IExlClYWEyS6l9+/bSqVOnlNSlSxepqqqyzmUyGbBS19dffy1btmyR0tLSXzgOVSaxpG53ujgRWLiRjz/+uPzpT39KSW+99ZZs3brVOpfJZMCqvy666CI2OM9N4BJJo2uczkwEVqtWraJPPfVUiXUSk8mAlVVt27atYNy4cVhXFyVwqa3Ty+LVed8FWE8//XSxdRKTyYCVVX3zzTcFgwcPJpt9RgKX9nF6Vbw6WTs14le///3vrZOYTAas7Gr79u0FQ4cOfdhx6NwELh3vtNlpz2TAImBvncRkMmBlVZ988knrXr16vZYEWOdrqkNTA5bJZMAKhD7//PMWffv2fd5x6Kz4lCmnW51WJcvBMmCZTAasXLmEheoSxq8GttD41TXJEkANWCaTASsn+uqrr4oGDBjwuGa1x1pvpz/plh0DlslkwAqGtm3bVnjyySeT5T4rjklkvv+XU3MDlslkwAqMODZ+woQJy+K24LRyetHpqpr2EBqwTCYDVs5UUVEBrJ7T7HZOyHlDdj3uy4BlMhmwcq8bb7yxIhKJvO9YNNLp1+IdVx81YJlMBqzAaePGjYe2adPmz9Fo9EOnu51aUpGhJnXo0MGAZTIZsHKjTz/9tMntt99+wsKFC09zau8ktamyspKEU+skJlOA9P8Bl9QR0GlMJWoAAAAASUVORK5CYII=";
            AnnotationEmbeddedImage signature = annotationManager.AddEmbeddedImageAnnotFromBase64(BASE64_SIGNATURE_IMAGE, 5.38f, 7.9f, 1.85f, 0.86f);
            signature.CanRotate = false;
            signature.Tag = "signature";
            annotationManager.SaveAnnotationsToPage();
            customActionEventArgs.docuVieware.ReloadAnnotations();
        }

        /// <summary>
        /// Draw the annotation timestamp with custom parameters and custom content
        /// </summary>
        /// <param name="customActionEventArgs">The arguments received from the custom action handler</param>
        /// <param name="annotationManager">The annotation manager object</param>
        private static void AddTimestampAnnotation(CustomActionEventArgs customActionEventArgs, AnnotationManager annotationManager)
        {
            CleanAnnotation(annotationManager, "timestamp");
            AnnotationText timestamp = annotationManager.AddTextAnnot(0.2f, 0.2f, 3.0f, 0.2f, DateTime.Now.ToString("G"));
            timestamp.AutoSize = true;
            timestamp.Fill = false;
            timestamp.Stroke = false;
            timestamp.FontName = "Courier New";
            timestamp.ForeColor = Color.Red;
            timestamp.FontSize = 10;
            timestamp.CanEditText = false;
            timestamp.Tag = "timestamp";
            annotationManager.SaveAnnotationsToPage();
            customActionEventArgs.docuVieware.ReloadAnnotations();
        }

        /// <summary>
        /// This method makes sure annotations are not added twice on the same page
        /// </summary>
        /// <param name="annotationManager">The annotation manager object</param>
        /// <param name="tag">The annotation tag to clean</param>
        private static void CleanAnnotation(AnnotationManager annotationManager, string tag)
        {
            for (int i = 0; i < annotationManager.GetAnnotationCount(); i++)
            {
                Annotation annot = annotationManager.GetAnnotationFromIdx(i);
                if (annot.Tag == tag)
                {
                    annotationManager.DeleteAnnotation(i);
                }
            }
        }
    }
}