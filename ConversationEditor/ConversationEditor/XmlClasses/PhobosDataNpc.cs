using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace ConversationEditor.XmlClasses
{
    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class PhobosDataNpc
    {
        /// <remarks/>
        [XmlAttribute]
        public byte root { get; set; }

        /// <remarks/>
        public PhobosDataNpcConfig config { get; set; }

        /// <remarks/>
        public PhobosDataText talking { get; set; }

        /// <remarks/>
        public PhobosDataText leaving { get; set; }

        /// <remarks/>
        public PhobosDataText attacked { get; set; }

        /// <remarks/>
        [XmlElement("define")]
        public PhobosDataDefine[] define { get; set; }

        /// <remarks/>
        [XmlElement("state")]
        public PhobosDataState[] state { get; set; }
    }
}
