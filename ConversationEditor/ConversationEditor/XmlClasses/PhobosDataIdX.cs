using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace ConversationEditor.XmlClasses
{
    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class PhobosDataIdX
    {
        /// <remarks/>
        [XmlAttribute]
        public string id { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public byte x { get; set; }
    }
}
