using System.Linq;
using ConversationEditor.Models;

namespace ConversationEditor.Mappers
{
    public static class NpcSettingsMapper
    {
        public static NpcSettingsModel Map(this PhobosData npcData)
        {
            var model = new NpcSettingsModel
            {
                Name = npcData.npc.config.name,
                Title = npcData.npc.config.title,
                Gender = npcData.npc.config.gender,
                MoveWidth = npcData.npc.config.move.width,
                MoveHeight = npcData.npc.config.move.height,
                HearWidth = npcData.npc.config.hear.width,
                HearHeight = npcData.npc.config.hear.height,
                Speed = npcData.npc.config.stats.speed,
                Talking = npcData.npc.talking.text,
                Leaving = npcData.npc.leaving.text,
                Attacked = npcData.npc.attacked.text
            };

            var prefabIds = npcData.npc.define.Select(x => x.id);
            foreach (var prefabId in prefabIds)
            {
                var defineSection = npcData.npc.define.First(x => x.id.Equals(prefabId));
                model.SetPrefabMatches(defineSection.id, defineSection.require);
            }
            
            return model;
        }

        public static PhobosData Map(this NpcSettingsModel npcSettings, PhobosData phobosData)
        {
            phobosData.npc.config.name = npcSettings.Name;
            phobosData.npc.config.title = npcSettings.Title;
            phobosData.npc.config.gender = npcSettings.Gender;
            phobosData.npc.config.move.width = (byte)npcSettings.MoveWidth;
            phobosData.npc.config.move.height = (byte)npcSettings.MoveHeight;
            phobosData.npc.config.hear.width = (byte)npcSettings.HearWidth;
            phobosData.npc.config.hear.height = (byte)npcSettings.HearHeight;
            phobosData.npc.config.stats.speed = (byte)npcSettings.Speed;

            phobosData.npc.talking.text = npcSettings.Talking;
            phobosData.npc.leaving.text = npcSettings.Leaving;
            phobosData.npc.attacked.text = npcSettings.Attacked;

            return phobosData;
        }
    }
}
