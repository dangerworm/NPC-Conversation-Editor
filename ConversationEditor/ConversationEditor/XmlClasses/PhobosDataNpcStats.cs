using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace ConversationEditor.XmlClasses
{
    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class PhobosDataNpcStats
    {
        /// <remarks/>
        [XmlAttribute]
        public byte level { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public byte experience { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public ushort health { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public byte speed { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public byte light { get; set; }
    }
}
