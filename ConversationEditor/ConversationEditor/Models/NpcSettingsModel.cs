using System;
using System.Collections.Generic;
using System.Linq;

namespace ConversationEditor.Models
{
    public class NpcSettingsModel
    {
        private string[] _talking;
        private string[] _leaving;
        private string[] _attacked;
        private readonly Dictionary<string, List<string>> _prefabs;

        public string Name { get; set; }
        public string Title { get; set; }
        public string Gender { get; set; }

        public int MoveWidth { get; set; }
        public int MoveHeight { get; set; }

        public int HearWidth { get; set; }
        public int HearHeight { get; set; }

        public int Speed { get; set; }

        public string PcTitleMale { get; set; }
        public string PcTitleFemale { get; set; }

        public string Talking
        {
            get { return string.Join(Environment.NewLine, _talking); }
            set { _talking = value.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries); }
        }

        public string Leaving
        {
            get { return string.Join(Environment.NewLine, _leaving); }
            set { _leaving = value.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries); }
        }

        public string Attacked
        {
            get { return string.Join(Environment.NewLine, _attacked); }
            set { _attacked = value.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries); }
        }

        public string[] PrefabIds => _prefabs.Keys.ToArray();

        public string GetPrefabMatches(string key)
        {
            return string.Join(Environment.NewLine, _prefabs[key]);
        }

        public void SetPrefabMatches(string key, string matches)
        {
            var values = new List<string>(matches.Split(Environment.NewLine.ToCharArray()));

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

        public NpcSettingsModel()
        {
            _talking = new string[0];
            _leaving = new string[0];
            _attacked = new string[0];
            _prefabs = new Dictionary<string, List<string>>();
        }
    }
}
