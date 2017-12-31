using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace ConversationEditor.XmlClasses
{
    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class PhobosDataState
    {
        /// <remarks/>
        [XmlElement("case")]
        public PhobosDataCase[] @case { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string id { get; set; }
    }
}
