using System;

namespace University_Housing_Management_Project.Helpers.Pdf
{
    
    [AttributeUsage(AttributeTargets.Property)]
    public class PdfDisplayNameAttribute : Attribute
    {
        public string DisplayName { get; }

        public PdfDisplayNameAttribute(string displayName)
        {
            DisplayName = displayName;
        }
    }
}
