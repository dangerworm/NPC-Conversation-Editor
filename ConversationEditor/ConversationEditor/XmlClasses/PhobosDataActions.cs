using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace ConversationEditor.XmlClasses
{
    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class PhobosDataActions
    {
        /// <remarks/>
        [XmlArrayItem("case", IsNullable = false)]
        public PhobosDataCase[] select { get; set; }

        /// <remarks/>
        public string text { get; set; }

        /// <remarks/>
        public PhobosDataIdX item { get; set; }

        /// <remarks/>
        public PhobosDataIdX quest { get; set; }

        /// <remarks/>
        public PhobosDataIdX trade { get; set; }

        /// <remarks/>
        public PhobosDataIdX state { get; set; }
    }
}
