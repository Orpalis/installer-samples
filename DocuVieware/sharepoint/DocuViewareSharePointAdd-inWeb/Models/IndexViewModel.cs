using System;
using System.Collections.Generic;

namespace DocuViewareSharePointAdd_inWeb.Models
{
    public class IndexViewModel
    {
        public string Title { get; set; }

        public IList<DocumentItem> Documents { get; set; }
    }

    public class DocumentItem
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Url { get; set; }
    }
}