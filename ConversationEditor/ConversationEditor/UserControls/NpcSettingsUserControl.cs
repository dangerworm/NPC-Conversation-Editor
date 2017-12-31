using System;
using System.Windows.Forms;
using ConversationEditor.Models;

namespace ConversationEditor.UserControls
{
    public partial class NpcSettingsUserControl : UserControl
    {
        public NpcSettingsModel NpcSettings;

        private string Key => (string)lstPrefabs.Items[lstPrefabs.SelectedIndex];

        public NpcSettingsUserControl(NpcSettingsModel npcSettings)
        {
            if (npcSettings == null)
            {
                throw new ArgumentNullException(nameof(npcSettings), @"Parameter cannot be null.");
            }

            InitializeComponent();

            NpcSettings = npcSettings;
            bdsNpcSettings.DataSource = NpcSettings;

            lstPrefabs.Items.AddRange(NpcSettings.PrefabIds);
        }

        private void lstPrefabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPrefabs.SelectedIndex == -1 && lstPrefabs.Items.Count > 0)
            {
                lstPrefabs.SelectedIndex = 0;
            }

            if (lstPrefabs.Items.Count > 0)
            {
                txtPrefabMatches.Text = NpcSettings.GetPrefabMatches(Key);
            }
        }

        private void btnAddPrefab_Click(object sender, EventArgs e)
        {
            if (!txtNewPrefab.Visible)
            {
                txtNewPrefab.Show();
                txtNewPrefab.Focus();
                return;
            }

            if (!string.IsNullOrWhiteSpace(txtNewPrefab.Text))
            {
                NpcSettings.SetPrefabMatches(txtNewPrefab.Text, new string[0]);

                if (!lstPrefabs.Items.Contains(txtNewPrefab.Text))
                {
                    lstPrefabs.Items.Add(txtNewPrefab.Text);
                    lstPrefabs.SelectedIndex = lstPrefabs.Items.Count - 1;
                }
            }

            txtNewPrefab.Text = string.Empty;
            txtNewPrefab.Hide();
        }

        private void btnRemovePrefab_Click(object sender, EventArgs e)
        {
            NpcSettings.RemovePrefabMatches(Key);
            lstPrefabs.Items.Remove(Key);
        }

        private void txtPrefabMatches_Leave(object sender, EventArgs e)
        {
            NpcSettings.SetPrefabMatches(Key, txtPrefabMatches.Text);
        }

        private void btnAddCase_Click(object sender, EventArgs e)
        {
            var caseModel = new NpcCaseModel(NpcSettings.PrefabIds);
            var caseForm = new Case(caseModel);
            caseForm.Show();
        }
    }
}
