using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace ConversationEditor.XmlClasses
{
    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class PhobosDataRequire
    {
        /// <remarks/>
        [XmlElement("match")]
        public string[] match { get; set; }

        /// <remarks/>
        public PhobosDataIdX include { get; set; }

        /// <remarks/>
        public PhobosDataIdX quest { get; set; }
    }
}
