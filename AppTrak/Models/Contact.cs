using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace AppTrak.Models
{
    [XmlType("Contact")]
    public class Contact : IEquatable<Contact>
    {
        [DisplayName(@"Name")]
        public string ContactName { get; set; }
        [DisplayName(@"Position")]
        public string ContactPosition { get; set; }
        [DisplayName(@"Phone")]
        public string ContactPhone { get; set; }
        [DisplayName(@"Email")]
        public string ContactEmail { get; set; }
        public bool Equals(Contact other)
        {
            return ContactName == other.ContactName &&
                   ContactPosition == other.ContactPosition &&
                   ContactPhone == other.ContactPhone &&
                   ContactEmail == other.ContactEmail;
        }

        public override string ToString()
        {
            return
                $"ContactName: {ContactName} | ContactPosition: {ContactPosition} | ContactPhone: {ContactPhone} | ContactEmail: {ContactEmail}";
        }
    }
}
