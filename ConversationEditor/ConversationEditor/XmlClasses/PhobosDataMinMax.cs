using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace ConversationEditor.XmlClasses
{
    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class PhobosDataMinMax
    {
        /// <remarks/>
        [XmlAttribute]
        public byte min { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public byte max { get; set; }
    }
}
