using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace ConversationEditor.XmlClasses
{
    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class PhobosDataWidthHeight
    {
        /// <remarks/>
        [XmlAttribute]
        public byte width { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public byte height { get; set; }
    }
}
