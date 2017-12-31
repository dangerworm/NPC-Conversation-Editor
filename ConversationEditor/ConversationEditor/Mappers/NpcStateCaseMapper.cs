using System;
using System.Linq;
using ConversationEditor.Models;
using ConversationEditor.XmlClasses;

namespace ConversationEditor.Mappers
{
    public static class NpcStateCaseMapper
    {
        public static NpcCaseModel Map(this PhobosDataCase npcStateCase,
            string[] prefabIds)
        {
            if (prefabIds == null)
            {
                throw new ArgumentNullException(nameof(prefabIds), @"Parameter cannot be null.");
            }

            NpcCaseModel model;
            if (npcStateCase.actions == null)
            {
                model = new NpcCaseModel(prefabIds);
            }
            else
            {
                model = new NpcCaseModel(prefabIds)
                {
                    ActionText = npcStateCase.actions.text,
                    ItemId = npcStateCase.actions.item?.id ?? "",
                    ItemX = npcStateCase.actions.item?.x ?? 0,
                    QuestId = npcStateCase.actions.quest?.id ?? "",
                    QuestX = npcStateCase.actions.quest?.x ?? 0,
                    TradeId = npcStateCase.actions.trade?.id ?? "",
                    StateId = npcStateCase.actions.state?.id ?? "",
                };
            }

            if (!string.IsNullOrWhiteSpace(npcStateCase.require?.include?.id))
            {
                model.AddIncludeId(npcStateCase.require.include.id);
            }

            if (npcStateCase.require?.match != null)
            {
                foreach (var match in npcStateCase.require.match)
                {
                    model.AddMatch(match);
                }
            }

            return model;
        }

        public static void Map(this NpcCaseModel model,
            ref PhobosDataCase npcStateCase)
        {
            npcStateCase.actions.text = model.ActionText;
            npcStateCase.actions.item.id = model.ItemId;
            npcStateCase.actions.item.x = (byte)model.ItemX;
            npcStateCase.actions.quest.id = model.QuestId;
            npcStateCase.actions.quest.x = (byte)model.QuestX;
            npcStateCase.actions.trade.id = model.TradeId;
            npcStateCase.actions.state.id = model.StateId;

            npcStateCase.require.include.id = model.IncludeIds.First();
            npcStateCase.require.match = model.Matches.ToArray();
        }
    }
}
