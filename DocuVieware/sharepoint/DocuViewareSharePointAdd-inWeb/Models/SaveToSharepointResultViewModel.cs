using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DocuViewareSharePointAdd_inWeb.Models
{
    public class SaveToSharepointResultViewModel
    {
        public HttpValidationStatus Status { get; set; }
        public string Message { get; set; }
    }
}