using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace ConversationEditor.XmlClasses
{
    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class PhobosDataTrack
    {
        /// <remarks/>
        [XmlAttribute]
        public string id { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string name { get; set; }
    }
}
