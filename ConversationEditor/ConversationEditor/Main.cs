using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using ConversationEditor.Mappers;
using ConversationEditor.Models;
using ConversationEditor.UserControls;
using ConversationEditor.XmlClasses;

namespace ConversationEditor
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            ofdOpen.DefaultExt = "xml";
            //ofdOpen.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ofdOpen.InitialDirectory = Directory.GetCurrentDirectory();
            ofdOpen.Filter = "XML Files|*.xml|Text Files|*.txt|All Files|*.*";
        }
        
        private void tsmNew_Click(object sender, EventArgs e)
        {
            CreateNewTabPage();
        }

        private void tsmOpen_Click(object sender, EventArgs e)
        {
            if (!SelectFileToOpen())
            {
                return;
            }

            var xmlReader = XmlReader.Create(ofdOpen.FileName);
            var serializer = new XmlSerializer(typeof(PhobosData));
            var npcData = (PhobosData)serializer.Deserialize(xmlReader);
            var npcSettings = npcData.Map();

            CreateNewTabPage(npcSettings);
        }

        private void tsmSave_Click(object sender, EventArgs e)
        {

        }

        private void tsmCloseTab_Click(object sender, EventArgs e)
        {

        }

        private void tsmExit_Click(object sender, EventArgs e)
        {
            foreach (TabPage tabPage in tbcNpcTabs.TabPages)
            {
                CheckSavedStatus(tabPage);
            }

            Close();
        }

        private void CreateNewTabPage(NpcSettingsModel npcSettings = null)
        {
            if (npcSettings == null)
            {
                npcSettings = new NpcSettingsModel();
            }

            var tabPage = new TabPage();
            var addPage = true;

            foreach (TabPage page in tbcNpcTabs.TabPages)
            {
                var userControl = page.Controls[0] as NpcSettingsUserControl;
                if (userControl == null || userControl.NpcSettings.Name != npcSettings.Name)
                {
                    continue;
                }

                var overwriteResult = MessageBox.Show(
                    $@"This will overwrite the current settings for {npcSettings.Name}. Do you want to continue?",
                    @"Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (overwriteResult == DialogResult.No)
                {
                    return;
                }

                tabPage = page;
                tabPage.Controls.Clear();
                addPage = false;
                break;
            }

            var npcSettingsControl = new NpcSettingsUserControl(npcSettings);
            tabPage.Controls.Add(npcSettingsControl);

            if (addPage)
            {
                tabPage.DataBindings.Add(new Binding("Text", npcSettings, "name"));
                tbcNpcTabs.TabPages.Add(tabPage);
            }
        }

        private bool SelectFileToOpen()
        {
            var openResult = ofdOpen.ShowDialog();
            if (openResult == DialogResult.Cancel)
            {
                return false;
            }

            var filename = ofdOpen.FileName;
            if (!File.Exists(filename))
            {
                ShowError("The file does not exist. Please try again.");
                return false;
            }

            return true;
        }

        private void CheckSavedStatus(Control tabPage)
        {
            var userControl = tabPage.Controls[0] as NpcSettingsUserControl;
            if (userControl == null || !userControl.NpcSettings.IsDirty)
            {
                return;
            }

            tabPage.Show();

            var saveResult = sfdSave.ShowDialog();
            if (saveResult == DialogResult.Cancel)
            {
                return;
            }
        }

        private static void ShowError(string message)
        {
            MessageBox.Show(message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
