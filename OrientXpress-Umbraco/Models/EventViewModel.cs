using System;
using System.Globalization;
using Umbraco.Core.Models;
using Umbraco.Web.Models;

namespace OrientXpress_Umbraco.Models
{
    public class EventViewModel
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
    }
}