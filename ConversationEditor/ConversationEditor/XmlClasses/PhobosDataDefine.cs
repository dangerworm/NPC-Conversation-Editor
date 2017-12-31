using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace ConversationEditor.XmlClasses
{
    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class PhobosDataDefine
    {
        /// <remarks/>
        [XmlAttribute]
        public string id { get; set; }

        /// <remarks/>
        [XmlArrayItem("match", IsNullable = false)]
        public string[] require { get; set; }
    }
}
