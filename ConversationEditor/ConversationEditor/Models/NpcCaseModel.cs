using System;
using System.Collections.Generic;

namespace ConversationEditor.Models
{
    public class NpcCaseModel : ModelBase
    {
        private string[] _prefabIds;

        private string _actionText;
        private string _itemId;
        private int _itemX;
        private string _questId;
        private int _questX;
        private string _tradeId;
        private string _stateId;

        public string[] PrefabIds
        {
            get { return _prefabIds; }
            set { SetValue(ref _prefabIds, value, nameof(PrefabIds)); }
        }

        public List<string> IncludeIds { get; }

        public List<string> Matches { get; }

        public string ActionText
        {
            get { return _actionText; }
            set { SetValue(ref _actionText, value, nameof(ActionText)); }
        }

        public string ItemId
        {
            get { return _itemId; }
            set { SetValue(ref _itemId, value, nameof(ItemId)); }
        }
        
        public int ItemX
        {
            get { return _itemX; }
            set { SetValue(ref _itemX, value, nameof(ItemX)); }
        }
        
        public string QuestId
        {
            get { return _questId; }
            set { SetValue(ref _questId, value, nameof(QuestId)); }
        }
        
        public int QuestX
        {
            get { return _questX; }
            set { SetValue(ref _questX, value, nameof(QuestX)); }
        }
        
        public string TradeId
        {
            get { return _tradeId; }
            set { SetValue(ref _tradeId, value, nameof(TradeId)); }
        }
        
        public string StateId
        {
            get { return _stateId; }
            set { SetValue(ref _stateId, value, nameof(StateId)); }
        }

        public NpcCaseModel(string[] prefabIds)
        {
            if (prefabIds == null)
            {
                throw new ArgumentNullException(nameof(prefabIds), @"Parameter cannot be null.");
            }

            _prefabIds = prefabIds;

            IncludeIds = new List<string>();
            Matches = new List<string>();
        }

        public void AddIncludeId(string includeId)
        {
            if (IncludeIds.Contains(includeId))
            {
                return;
            }

            IncludeIds.Add(includeId);
            IsDirty = true;
        }

        public void RemoveIncludeId(string includeId)
        {
            if (IncludeIds.Contains(includeId))
            {
                return;
            }

            IncludeIds.Remove(includeId);
            IsDirty = true;
        }

        public void AddMatch(string match)
        {
            if (!Matches.Contains(match))
            {
                return;
            }

            Matches.Add(match);
            IsDirty = true;
        }

        public void RemoveMatch(string match)
        {
            if (Matches.Contains(match))
            {
                return;
            }

            Matches.Remove(match);
            IsDirty = true;
        }
    }
}
