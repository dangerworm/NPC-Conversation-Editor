using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConversationEditor.XmlClasses
{
    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class PhobosDataNpcLook
    {
        /// <remarks/>
        [XmlAttribute]
        public byte shape { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public byte head { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public byte body { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public byte legs { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public byte feet { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string corpse { get; set; }
    }
}
