using System;
using System.Collections.Generic;
using CsvHelper.Configuration.Attributes;
using System;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace APBD_2.Classes
{
    //bo bedziemy serialziwoac do XML
    [Serializable]
    public class Student
    {
        //atrybuty
        // atrybut index jest wykozystywany przez  biblioteke CsvReader
        [Index(0)]
        [JsonPropertyName("Imie")]
        [XmlElement(ElementName = "Imie")]
        //properties(wlasciwosci) short cut to use prop
        public string firstName { get; set; }
        [Index(1)]
        [XmlAttribute("Nazwisko")]
        public string lastName { get; set; }
        [Index(2)]
        public string Studia { get; set; }
        [Index(3)]
        public string Mode { get; set; }
        [Index(4)]
        public string IndexNumber { get; set; }
        [Index(5)]
        public string dob { get; set; }
        [Index(6)]
        public string email { get; set; }
        [Index(7)]
        public string motherFirstName { get; set; }
        [Index(8)]
        public string fatherFirstName { get; set; }
        
    }
}
