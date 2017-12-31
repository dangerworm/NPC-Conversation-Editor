using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using ConversationEditor.Mappers;
using ConversationEditor.Models;
using ConversationEditor.UserControls;

namespace ConversationEditor
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            ofdOpen.DefaultExt = "xml";
            ofdOpen.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
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

        private void CreateNewTabPage(NpcSettingsModel npcSettings = null)
        {
            if (npcSettings == null)
            {
                npcSettings = new NpcSettingsModel();
            }

            var tabPage = new TabPage();
            var npcSettingsControl = new NpcSettingsUserControl(npcSettings);
            var fileName = Path.GetFileNameWithoutExtension(ofdOpen.FileName) ?? new Guid().ToString();
            tabPage.Name = $"tpg{fileName.Replace(" ", "-")}";
            tabPage.DataBindings.Add(new Binding("Text", npcSettings, "name"));
            tabPage.Controls.Add(npcSettingsControl);

            tbcNpcTabs.TabPages.Add(tabPage);
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

        private static void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
