using System;
using System.Collections.Generic;
using System.Linq;

namespace ConversationEditor.Models
{
    public class NpcSettingsModel : ModelBase
    {
        private readonly Dictionary<string, List<string>> _prefabs;
        private readonly Dictionary<string, List<NpcCaseModel>> _stateCases;

        private string _name;
        private string _title;
        private string _gender;
        private int _moveWidth;
        private int _moveHeight;
        private int _hearWidth;
        private int _hearHeight;
        private int _speed;
        private string _pcTitleMale;
        private string _pcTitleFemale;
        private string[] _talking;
        private string[] _leaving;
        private string[] _attacked;
        
        public string Name
        {
            get { return _name; }
            set { SetValue(ref _name, value, nameof(Name)); }
        }

        public string Title
        {
            get { return _title; }
            set { SetValue(ref _title, value, nameof(Title)); }
        }

        public string Gender
        {
            get { return _gender; }
            set { SetValue(ref _gender, value, nameof(Gender)); }
        }

        public int MoveWidth
        {
            get { return _moveWidth; }
            set { SetValue(ref _moveWidth, value, nameof(MoveWidth)); }
        }

        public int MoveHeight
        {
            get { return _moveHeight; }
            set { SetValue(ref _moveHeight, value, nameof(MoveHeight)); }
        }

        public int HearWidth
        {
            get { return _hearWidth; }
            set { SetValue(ref _hearWidth, value, nameof(HearWidth)); }
        }

        public int HearHeight
        {
            get { return _hearHeight; }
            set { SetValue(ref _hearHeight, value, nameof(HearHeight)); }
        }

        public int Speed
        {
            get { return _speed; }
            set { SetValue(ref _speed, value, nameof(Speed)); }
        }

        public string PcTitleMale
        {
            get { return _pcTitleMale; }
            set { SetValue(ref _pcTitleMale, value, nameof(PcTitleMale)); }
        }

        public string PcTitleFemale
        {
            get { return _pcTitleFemale; }
            set { SetValue(ref _pcTitleFemale, value, nameof(PcTitleFemale)); }
        }

        public string Talking
        {
            get { return string.Join(Environment.NewLine, _talking); }
            set
            {
                var items = value.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries); 
                SetValue(ref _talking, items, nameof(Talking)); 
            }
        }

        public string Leaving
        {
            get { return string.Join(Environment.NewLine, _leaving); }
            set
            {
                var items = value.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                SetValue(ref _leaving, items, nameof(Leaving));
            }
        }

        public string Attacked
        {
            get { return string.Join(Environment.NewLine, _attacked); }
            set
            {
                var items = value.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries); 
                SetValue(ref _attacked, items, nameof(Attacked));
            }
        }

        public string[] PrefabIds => _prefabs.Keys.ToArray();

        public NpcSettingsModel()
        {
            _talking = new string[0];
            _leaving = new string[0];
            _attacked = new string[0];
            _prefabs = new Dictionary<string, List<string>>();
            _stateCases = new Dictionary<string, List<NpcCaseModel>>();
        }

        public string GetPrefabMatches(string key)
        {
            return string.Join(Environment.NewLine, _prefabs[key]);
        }

        public void SetPrefabMatches(string key, string matches)
        {
            var values = new List<string>(matches.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries));

            if (_prefabs.ContainsKey(key))
            {
                _prefabs[key] = values;
                return;
            }

            _prefabs.Add(key, values);
        }

        public void SetPrefabMatches(string key, string[] matches)
        {
            var values = new List<string>(matches);

            if (_prefabs.ContainsKey(key))
            {
                _prefabs[key] = values;
                return;
            }

            _prefabs.Add(key, values);
        }

        public void RemovePrefabMatches(string key)
        {
            if (_prefabs.ContainsKey(key))
            {
                _prefabs.Remove(key);
            }
        }

        public void AddStateCase(string id, NpcCaseModel caseModel)
        {
            if (!_stateCases.ContainsKey(id))
            {
                _stateCases.Add(id, new List<NpcCaseModel>());
            }

            _stateCases[id].Add(caseModel);
        }
    }
}
