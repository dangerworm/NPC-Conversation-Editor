using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace ConversationEditor
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

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class PhobosDataNpc
    {
        /// <remarks/>
        public PhobosDataNpcConfig config { get; set; }

        /// <remarks/>
        public PhobosDataNpcTalking talking { get; set; }

        /// <remarks/>
        public PhobosDataNpcLeaving leaving { get; set; }

        /// <remarks/>
        public PhobosDataNpcAttacked attacked { get; set; }

        /// <remarks/>
        [XmlElement("define")]
        public PhobosDataNpcDefine[] define { get; set; }

        /// <remarks/>
        [XmlElement("state")]
        public PhobosDataNpcState[] state { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public byte root { get; set; }
    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class PhobosDataNpcConfig
    {
        /// <remarks/>
        public PhobosDataNpcConfigLook look { get; set; }

        /// <remarks/>
        public PhobosDataNpcConfigStats stats { get; set; }

        /// <remarks/>
        public PhobosDataNpcConfigMove move { get; set; }

        /// <remarks/>
        public PhobosDataNpcConfigHear hear { get; set; }

        /// <remarks/>
        public PhobosDataNpcConfigAttack attack { get; set; }

        /// <remarks/>
        public PhobosDataNpcConfigDefense defense { get; set; }

        /// <remarks/>
        public PhobosDataNpcConfigArmor armor { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string name { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string title { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string gender { get; set; }
    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class PhobosDataNpcConfigLook
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

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class PhobosDataNpcConfigStats
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

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class PhobosDataNpcConfigMove
    {
        /// <remarks/>
        [XmlAttribute]
        public byte width { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public byte height { get; set; }
    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class PhobosDataNpcConfigHear
    {

        /// <remarks/>
        [XmlAttribute]
        public byte width { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public byte height { get; set; }
    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class PhobosDataNpcConfigAttack
    {

        /// <remarks/>
        [XmlAttribute]
        public byte min { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public byte max { get; set; }
    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class PhobosDataNpcConfigDefense
    {


        /// <remarks/>
        [XmlAttribute]
        public byte min { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public byte max { get; set; }
    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class PhobosDataNpcConfigArmor
    {
        /// <remarks/>
        [XmlAttribute]
        public byte min { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public byte max { get; set; }
    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class PhobosDataNpcTalking
    {
        /// <remarks/>
        public string text { get; set; }
    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class PhobosDataNpcLeaving
    {
        /// <remarks/>
        public string text { get; set; }
    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class PhobosDataNpcAttacked
    {
        /// <remarks/>
        public string text { get; set; }
    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class PhobosDataNpcDefine
    {
        /// <remarks/>
        [XmlArrayItem("match", IsNullable = false)]
        public string[] require { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string id { get; set; }
    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class PhobosDataNpcState
    {
        /// <remarks/>
        [XmlElement("case")]
        public PhobosDataNpcStateCase[] @case { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string id { get; set; }
    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class PhobosDataNpcStateCase
    {
        /// <remarks/>
        public PhobosDataNpcStateCaseRequire require { get; set; }

        /// <remarks/>
        public PhobosDataNpcStateCaseActions actions { get; set; }
    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class PhobosDataNpcStateCaseRequire
    {
        /// <remarks/>
        [XmlElement("match")]
        public string[] match { get; set; }

        /// <remarks/>
        public PhobosDataNpcStateCaseRequireInclude include { get; set; }
    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class PhobosDataNpcStateCaseRequireInclude
    {
        /// <remarks/>
        [XmlAttribute]
        public string id { get; set; }
    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class PhobosDataNpcStateCaseActions
    {
        /// <remarks/>
        [XmlArrayItem("case", IsNullable = false)]
        public PhobosDataNpcStateCaseActionsCase[] select { get; set; }

        /// <remarks/>
        public string text { get; set; }

        /// <remarks/>
        public PhobosDataNpcStateCaseActionsItem item { get; set; }

        /// <remarks/>
        public PhobosDataNpcStateCaseActionsQuest quest { get; set; }

        /// <remarks/>
        public PhobosDataNpcStateCaseActionsTrade trade { get; set; }

        /// <remarks/>
        public PhobosDataNpcStateCaseActionsState state { get; set; }
    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class PhobosDataNpcStateCaseActionsCase
    {
        /// <remarks/>
        public PhobosDataNpcStateCaseActionsCaseRequire require { get; set; }

        /// <remarks/>
        public PhobosDataNpcStateCaseActionsCaseActions actions { get; set; }
    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class PhobosDataNpcStateCaseActionsCaseRequire
    {
        /// <remarks/>
        public PhobosDataNpcStateCaseActionsCaseRequireQuest quest { get; set; }
    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class PhobosDataNpcStateCaseActionsCaseRequireQuest
    {
        /// <remarks/>
        [XmlAttribute]
        public string id { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public byte x { get; set; }
    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class PhobosDataNpcStateCaseActionsCaseActions
    {
        /// <remarks/>
        public string text { get; set; }

        /// <remarks/>
        public PhobosDataNpcStateCaseActionsCaseActionsState state { get; set; }
    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class PhobosDataNpcStateCaseActionsCaseActionsState
    {
        /// <remarks/>
        [XmlAttribute]
        public string id { get; set; }
    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class PhobosDataNpcStateCaseActionsItem
    {
        /// <remarks/>
        [XmlAttribute]
        public string id { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public byte x { get; set; }
    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class PhobosDataNpcStateCaseActionsQuest
    {
        /// <remarks/>
        [XmlAttribute]
        public string id { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public byte x { get; set; }
    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class PhobosDataNpcStateCaseActionsTrade
    {
        /// <remarks/>
        [XmlAttribute]
        public string id { get; set; }
    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class PhobosDataNpcStateCaseActionsState
    {
        /// <remarks/>
        [XmlAttribute]
        public string id { get; set; }
    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class PhobosDataTrack
    {
        /// <remarks/>
        [XmlAttribute]
        public string id { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string name { get; set; }
    }
}
