using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace ConversationEditor.XmlClasses
{
    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class PhobosDataNpcConfig
    {
        /// <remarks/>
        [XmlAttribute]
        public string name { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string title { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string gender { get; set; }

        /// <remarks/>
        public PhobosDataNpcLook look { get; set; }

        /// <remarks/>
        public PhobosDataNpcStats stats { get; set; }

        /// <remarks/>
        public PhobosDataWidthHeight move { get; set; }

        /// <remarks/>
        public PhobosDataWidthHeight hear { get; set; }

        /// <remarks/>
        public PhobosDataMinMax attack { get; set; }

        /// <remarks/>
        public PhobosDataMinMax defense { get; set; }

        /// <remarks/>
        public PhobosDataMinMax armor { get; set; }
    }
}
