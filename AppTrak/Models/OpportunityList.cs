using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Xml.Serialization;
using AppTrak.Helpers;

namespace AppTrak.Models
{
    [Serializable]
    [XmlInclude(typeof(Opportunity))]
    [XmlInclude(typeof(Contact))]
    [XmlType("Opportunities")]
    public class OpportunityList : List<Opportunity>
    {
        public void Save()
        {
            var fileName = FileHelper.AssemblyDirectory + @"\Cache\Opportunities.xml";
            using (var writer = new StreamWriter(fileName))
            {
                var serializer = new XmlSerializer(GetType());
                serializer.Serialize(writer, this);
            }
        }
    }
}
