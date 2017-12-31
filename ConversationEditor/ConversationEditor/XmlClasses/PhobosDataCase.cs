using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace ConversationEditor.XmlClasses
{
    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class PhobosDataCase
    {
        /// <remarks/>
        public PhobosDataRequire require { get; set; }

        /// <remarks/>
        public PhobosDataActions actions { get; set; }
    }
}
