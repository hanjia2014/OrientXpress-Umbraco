using System;

namespace OrientXpress_Umbraco.Models
{
    public class EventViewModel
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }

        public string TruncateContent
        {
            get
            {
                var maxLength = 100;
                //trim the string to the maximum length
                var trimmedString = Content.Substring(0, maxLength);
                //re-trim if we are in the middle of a word
                trimmedString = trimmedString.Substring(0, Math.Min(trimmedString.Length, trimmedString.LastIndexOf(" ")));
                return trimmedString + "...";
            }
        }
    }
}