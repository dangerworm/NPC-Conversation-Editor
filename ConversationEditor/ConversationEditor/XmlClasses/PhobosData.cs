using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace ConversationEditor.XmlClasses
{
    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot("phobos-data", Namespace = "", IsNullable = false)]
    public class PhobosData
    {
        /// <remarks/>
        public PhobosDataNpc npc { get; set; }

        /// <remarks/>
        [XmlArrayItem("track", IsNullable = false)]
        public PhobosDataTrack[] tracking { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public decimal format { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string id { get; set; }
    }
}
