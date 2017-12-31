using System;
using System.Windows.Forms;
using ConversationEditor.Models;

namespace ConversationEditor.UserControls
{
    public partial class NpcSettingsUserControl : UserControl
    {
        public NpcSettingsModel NpcSettings;

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
                var key = (string)lstPrefabs.Items[lstPrefabs.SelectedIndex];
                txtPrefabMatches.Text = NpcSettings.GetPrefabMatches(key);
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
            var key = (string)lstPrefabs.Items[lstPrefabs.SelectedIndex];
            NpcSettings.RemovePrefabMatches(key);
            lstPrefabs.Items.Remove(key);
        }
    }
}
