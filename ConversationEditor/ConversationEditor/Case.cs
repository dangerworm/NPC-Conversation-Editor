using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ConversationEditor.Models;

namespace ConversationEditor
{
    public partial class Case : Form
    {
        private const string INCLUDE_PREFIX = "include: ";
        private const string MATCH_PREFIX = "match: ";

        private readonly string[] _allIncludeIds;

        public NpcCaseModel NpcStateCaseModel { get; set; }

        public Case(NpcCaseModel caseModel)
        {
            if (caseModel == null)
            {
                throw new ArgumentNullException(nameof(caseModel), @"Parameter cannot be null.");
            }

            InitializeComponent();

            NpcStateCaseModel = caseModel;
            _allIncludeIds = caseModel.PrefabIds;

            UpdateLists();
        }

        private void btnAddPrefab_Click(object sender, EventArgs e)
        {
            var selectedItem = (string)cmbPrefabs.SelectedItem;
            NpcStateCaseModel.AddIncludeId(selectedItem);
            UpdateLists();
        }

        private void btnAddMatch_Click(object sender, EventArgs e)
        {
            NpcStateCaseModel.AddMatch(txtMatch.Text);
            txtMatch.Clear();
            UpdateLists();
        }

        private void btnRemoveRequirement_Click(object sender, EventArgs e)
        {
            if (lstRequirements.SelectedIndex < 0)
            {
                return;
            }

            var selectedItem = (string)lstRequirements.SelectedItem;
            var itemText = string.Empty;
            if (selectedItem.StartsWith(INCLUDE_PREFIX))
            {
                itemText = selectedItem.Substring(INCLUDE_PREFIX.Length);
                NpcStateCaseModel.RemoveIncludeId(itemText);
            }
            else if (selectedItem.StartsWith(MATCH_PREFIX))
            {
                itemText = selectedItem.Substring(MATCH_PREFIX.Length);
                NpcStateCaseModel.RemoveMatch(itemText);
            }

            UpdateLists();
        }

        private void UpdateLists()
        {
            UpdatePrefabs();
            UpdateRequirements();
        }

        private void UpdatePrefabs()
        {
            var prefabs = new string[_allIncludeIds.Length];
            _allIncludeIds.CopyTo(prefabs, 0);
            var availablePrefabs = new List<string>(prefabs);

            foreach (var includeId in NpcStateCaseModel.IncludeIds)
            {
                availablePrefabs.Remove(includeId);
            }

            cmbPrefabs.BeginUpdate();
            
            cmbPrefabs.Items.Clear();
            cmbPrefabs.Items.AddRange(availablePrefabs.ToArray());

            cmbPrefabs.EndUpdate();
        }

        private void UpdateRequirements()
        {
            lstRequirements.BeginUpdate();

            lstRequirements.Items.Clear();

            foreach (var includeId in NpcStateCaseModel.IncludeIds)
            {
                lstRequirements.Items.Add(INCLUDE_PREFIX + includeId);
            }

            foreach (var match in NpcStateCaseModel.Matches)
            {
                lstRequirements.Items.Add(MATCH_PREFIX + match);
            }

            lstRequirements.EndUpdate();
        }
    }
}
