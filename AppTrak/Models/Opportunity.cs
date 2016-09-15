using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml.Serialization;
using AppTrak.Helpers;

namespace AppTrak.Models
{
    [Serializable]
    [XmlType("Opportunity")]
    [XmlInclude(typeof(Contact))]
    public class Opportunity : IEquatable<Opportunity>
    {
        [DisplayName(@"Date")]
        public DateTime ApplicationDate { get; set; }
        [DisplayName(@"Company")]
        public string CompanyName { get; set; }
        [DisplayName(@"Status")]
        public string FollowUpStatus { get; set; }
        [DisplayName(@"Position")]
        public string Position { get; set; }
        [DisplayName(@"Link")]
        public string WebLink { get; set; }
        [DisplayName(@"Contacts")]
        public List<Contact> Contacts { get; set; }
        public bool Equals(Opportunity other)
        {
            return CompanyName == other.CompanyName &&
                   WebLink == other.WebLink &&
                   Position == other.Position;
        }
    }
}