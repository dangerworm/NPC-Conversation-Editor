namespace ConversationEditor.UserControls
{
    partial class NpcSettingsUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblAttacked = new System.Windows.Forms.Label();
            this.lblLeaving = new System.Windows.Forms.Label();
            this.lblTalking = new System.Windows.Forms.Label();
            this.txtPcTitleFemale = new System.Windows.Forms.TextBox();
            this.txtPcTitleMale = new System.Windows.Forms.TextBox();
            this.lblFemale = new System.Windows.Forms.Label();
            this.lblMale = new System.Windows.Forms.Label();
            this.lblPcTitles = new System.Windows.Forms.Label();
            this.nudHearHeight = new System.Windows.Forms.NumericUpDown();
            this.nudHearWidth = new System.Windows.Forms.NumericUpDown();
            this.nudMoveSpeed = new System.Windows.Forms.NumericUpDown();
            this.nudMoveHeight = new System.Windows.Forms.NumericUpDown();
            this.nudMoveWidth = new System.Windows.Forms.NumericUpDown();
            this.trvStateTree = new System.Windows.Forms.TreeView();
            this.lblHear = new System.Windows.Forms.Label();
            this.lblMove = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.txtAttacked = new System.Windows.Forms.TextBox();
            this.txtLeaving = new System.Windows.Forms.TextBox();
            this.txtTalking = new System.Windows.Forms.TextBox();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.grpPrefabs = new System.Windows.Forms.GroupBox();
            this.lstPrefabs = new System.Windows.Forms.ListBox();
            this.txtPrefabMatches = new System.Windows.Forms.TextBox();
            this.btnAddPrefab = new System.Windows.Forms.Button();
            this.btnRemovePrefab = new System.Windows.Forms.Button();
            this.txtNewPrefab = new System.Windows.Forms.TextBox();
            this.bdsNpcSettings = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudHearHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHearWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMoveSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMoveHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMoveWidth)).BeginInit();
            this.grpPrefabs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNpcSettings)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAttacked
            // 
            this.lblAttacked.AutoSize = true;
            this.lblAttacked.Location = new System.Drawing.Point(544, 89);
            this.lblAttacked.Name = "lblAttacked";
            this.lblAttacked.Size = new System.Drawing.Size(53, 13);
            this.lblAttacked.TabIndex = 60;
            this.lblAttacked.Text = "Attacked:";
            // 
            // lblLeaving
            // 
            this.lblLeaving.AutoSize = true;
            this.lblLeaving.Location = new System.Drawing.Point(272, 89);
            this.lblLeaving.Name = "lblLeaving";
            this.lblLeaving.Size = new System.Drawing.Size(48, 13);
            this.lblLeaving.TabIndex = 59;
            this.lblLeaving.Text = "Leaving:";
            // 
            // lblTalking
            // 
            this.lblTalking.AutoSize = true;
            this.lblTalking.Location = new System.Drawing.Point(3, 89);
            this.lblTalking.Name = "lblTalking";
            this.lblTalking.Size = new System.Drawing.Size(45, 13);
            this.lblTalking.TabIndex = 58;
            this.lblTalking.Text = "Talking:";
            // 
            // txtPcTitleFemale
            // 
            this.txtPcTitleFemale.Location = new System.Drawing.Point(167, 50);
            this.txtPcTitleFemale.Name = "txtPcTitleFemale";
            this.txtPcTitleFemale.Size = new System.Drawing.Size(100, 20);
            this.txtPcTitleFemale.TabIndex = 57;
            // 
            // txtPcTitleMale
            // 
            this.txtPcTitleMale.Location = new System.Drawing.Point(61, 50);
            this.txtPcTitleMale.Name = "txtPcTitleMale";
            this.txtPcTitleMale.Size = new System.Drawing.Size(100, 20);
            this.txtPcTitleMale.TabIndex = 56;
            // 
            // lblFemale
            // 
            this.lblFemale.AutoSize = true;
            this.lblFemale.Location = new System.Drawing.Point(164, 34);
            this.lblFemale.Name = "lblFemale";
            this.lblFemale.Size = new System.Drawing.Size(41, 13);
            this.lblFemale.TabIndex = 55;
            this.lblFemale.Text = "Female";
            // 
            // lblMale
            // 
            this.lblMale.AutoSize = true;
            this.lblMale.Location = new System.Drawing.Point(58, 34);
            this.lblMale.Name = "lblMale";
            this.lblMale.Size = new System.Drawing.Size(30, 13);
            this.lblMale.TabIndex = 54;
            this.lblMale.Text = "Male";
            // 
            // lblPcTitles
            // 
            this.lblPcTitles.AutoSize = true;
            this.lblPcTitles.Location = new System.Drawing.Point(3, 53);
            this.lblPcTitles.Name = "lblPcTitles";
            this.lblPcTitles.Size = new System.Drawing.Size(52, 13);
            this.lblPcTitles.TabIndex = 53;
            this.lblPcTitles.Text = "PC Titles:";
            // 
            // nudHearHeight
            // 
            this.nudHearHeight.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bdsNpcSettings, "HearHeight", true));
            this.nudHearHeight.Location = new System.Drawing.Point(693, 51);
            this.nudHearHeight.Name = "nudHearHeight";
            this.nudHearHeight.Size = new System.Drawing.Size(52, 20);
            this.nudHearHeight.TabIndex = 52;
            // 
            // nudHearWidth
            // 
            this.nudHearWidth.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bdsNpcSettings, "HearWidth", true));
            this.nudHearWidth.Location = new System.Drawing.Point(626, 51);
            this.nudHearWidth.Name = "nudHearWidth";
            this.nudHearWidth.Size = new System.Drawing.Size(52, 20);
            this.nudHearWidth.TabIndex = 51;
            // 
            // nudMoveSpeed
            // 
            this.nudMoveSpeed.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bdsNpcSettings, "Speed", true));
            this.nudMoveSpeed.Location = new System.Drawing.Point(761, 24);
            this.nudMoveSpeed.Name = "nudMoveSpeed";
            this.nudMoveSpeed.Size = new System.Drawing.Size(52, 20);
            this.nudMoveSpeed.TabIndex = 50;
            // 
            // nudMoveHeight
            // 
            this.nudMoveHeight.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bdsNpcSettings, "MoveHeight", true));
            this.nudMoveHeight.Location = new System.Drawing.Point(693, 24);
            this.nudMoveHeight.Name = "nudMoveHeight";
            this.nudMoveHeight.Size = new System.Drawing.Size(52, 20);
            this.nudMoveHeight.TabIndex = 49;
            // 
            // nudMoveWidth
            // 
            this.nudMoveWidth.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bdsNpcSettings, "MoveWidth", true));
            this.nudMoveWidth.Location = new System.Drawing.Point(626, 24);
            this.nudMoveWidth.Name = "nudMoveWidth";
            this.nudMoveWidth.Size = new System.Drawing.Size(52, 20);
            this.nudMoveWidth.TabIndex = 48;
            // 
            // trvStateTree
            // 
            this.trvStateTree.Location = new System.Drawing.Point(3, 211);
            this.trvStateTree.Name = "trvStateTree";
            this.trvStateTree.Size = new System.Drawing.Size(391, 403);
            this.trvStateTree.TabIndex = 47;
            // 
            // lblHear
            // 
            this.lblHear.AutoSize = true;
            this.lblHear.Location = new System.Drawing.Point(583, 53);
            this.lblHear.Name = "lblHear";
            this.lblHear.Size = new System.Drawing.Size(33, 13);
            this.lblHear.TabIndex = 46;
            this.lblHear.Text = "Hear:";
            // 
            // lblMove
            // 
            this.lblMove.AutoSize = true;
            this.lblMove.Location = new System.Drawing.Point(583, 26);
            this.lblMove.Name = "lblMove";
            this.lblMove.Size = new System.Drawing.Size(37, 13);
            this.lblMove.TabIndex = 45;
            this.lblMove.Text = "Move:";
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(758, 8);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(38, 13);
            this.lblSpeed.TabIndex = 44;
            this.lblSpeed.Text = "Speed";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(690, 8);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(38, 13);
            this.lblHeight.TabIndex = 43;
            this.lblHeight.Text = "Height";
            // 
            // txtAttacked
            // 
            this.txtAttacked.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNpcSettings, "Attacked", true));
            this.txtAttacked.Location = new System.Drawing.Point(547, 105);
            this.txtAttacked.Multiline = true;
            this.txtAttacked.Name = "txtAttacked";
            this.txtAttacked.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAttacked.Size = new System.Drawing.Size(266, 100);
            this.txtAttacked.TabIndex = 42;
            // 
            // txtLeaving
            // 
            this.txtLeaving.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNpcSettings, "Leaving", true));
            this.txtLeaving.Location = new System.Drawing.Point(275, 105);
            this.txtLeaving.Multiline = true;
            this.txtLeaving.Name = "txtLeaving";
            this.txtLeaving.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLeaving.Size = new System.Drawing.Size(266, 100);
            this.txtLeaving.TabIndex = 41;
            // 
            // txtTalking
            // 
            this.txtTalking.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNpcSettings, "Talking", true));
            this.txtTalking.Location = new System.Drawing.Point(3, 105);
            this.txtTalking.Multiline = true;
            this.txtTalking.Name = "txtTalking";
            this.txtTalking.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTalking.Size = new System.Drawing.Size(266, 100);
            this.txtTalking.TabIndex = 40;
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(623, 8);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(35, 13);
            this.lblWidth.TabIndex = 39;
            this.lblWidth.Text = "Width";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(431, 8);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(45, 13);
            this.lblGender.TabIndex = 38;
            this.lblGender.Text = "Gender:";
            // 
            // cmbGender
            // 
            this.cmbGender.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNpcSettings, "Gender", true));
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "male",
            "female",
            "other"});
            this.cmbGender.Location = new System.Drawing.Point(482, 5);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(60, 21);
            this.cmbGender.TabIndex = 37;
            // 
            // txtTitle
            // 
            this.txtTitle.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNpcSettings, "Title", true));
            this.txtTitle.Location = new System.Drawing.Point(205, 5);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(220, 20);
            this.txtTitle.TabIndex = 36;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(169, 8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(30, 13);
            this.lblTitle.TabIndex = 35;
            this.lblTitle.Text = "Title:";
            // 
            // txtName
            // 
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNpcSettings, "Name", true));
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(3, 3);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(160, 22);
            this.txtName.TabIndex = 34;
            // 
            // grpPrefabs
            // 
            this.grpPrefabs.Controls.Add(this.txtNewPrefab);
            this.grpPrefabs.Controls.Add(this.btnRemovePrefab);
            this.grpPrefabs.Controls.Add(this.btnAddPrefab);
            this.grpPrefabs.Controls.Add(this.txtPrefabMatches);
            this.grpPrefabs.Controls.Add(this.lstPrefabs);
            this.grpPrefabs.Location = new System.Drawing.Point(547, 211);
            this.grpPrefabs.Name = "grpPrefabs";
            this.grpPrefabs.Size = new System.Drawing.Size(266, 403);
            this.grpPrefabs.TabIndex = 61;
            this.grpPrefabs.TabStop = false;
            this.grpPrefabs.Text = "PreFabs";
            // 
            // lstPrefabs
            // 
            this.lstPrefabs.FormattingEnabled = true;
            this.lstPrefabs.Location = new System.Drawing.Point(6, 19);
            this.lstPrefabs.Name = "lstPrefabs";
            this.lstPrefabs.Size = new System.Drawing.Size(254, 95);
            this.lstPrefabs.TabIndex = 1;
            this.lstPrefabs.SelectedIndexChanged += new System.EventHandler(this.lstPrefabs_SelectedIndexChanged);
            // 
            // txtPrefabMatches
            // 
            this.txtPrefabMatches.Location = new System.Drawing.Point(6, 149);
            this.txtPrefabMatches.Multiline = true;
            this.txtPrefabMatches.Name = "txtPrefabMatches";
            this.txtPrefabMatches.Size = new System.Drawing.Size(254, 248);
            this.txtPrefabMatches.TabIndex = 3;
            // 
            // btnAddPrefab
            // 
            this.btnAddPrefab.Location = new System.Drawing.Point(6, 120);
            this.btnAddPrefab.Name = "btnAddPrefab";
            this.btnAddPrefab.Size = new System.Drawing.Size(75, 23);
            this.btnAddPrefab.TabIndex = 4;
            this.btnAddPrefab.Text = "Add New";
            this.btnAddPrefab.UseVisualStyleBackColor = true;
            this.btnAddPrefab.Click += new System.EventHandler(this.btnAddPrefab_Click);
            // 
            // btnRemovePrefab
            // 
            this.btnRemovePrefab.Location = new System.Drawing.Point(185, 120);
            this.btnRemovePrefab.Name = "btnRemovePrefab";
            this.btnRemovePrefab.Size = new System.Drawing.Size(75, 23);
            this.btnRemovePrefab.TabIndex = 5;
            this.btnRemovePrefab.Text = "Remove";
            this.btnRemovePrefab.UseVisualStyleBackColor = true;
            this.btnRemovePrefab.Click += new System.EventHandler(this.btnRemovePrefab_Click);
            // 
            // txtNewPrefab
            // 
            this.txtNewPrefab.Location = new System.Drawing.Point(7, 144);
            this.txtNewPrefab.Name = "txtNewPrefab";
            this.txtNewPrefab.Size = new System.Drawing.Size(173, 20);
            this.txtNewPrefab.TabIndex = 6;
            this.txtNewPrefab.Visible = false;
            // 
            // bdsNpcSettings
            // 
            this.bdsNpcSettings.DataSource = typeof(ConversationEditor.Models.NpcSettingsModel);
            // 
            // NpcSettingsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpPrefabs);
            this.Controls.Add(this.lblAttacked);
            this.Controls.Add(this.lblLeaving);
            this.Controls.Add(this.lblTalking);
            this.Controls.Add(this.txtPcTitleFemale);
            this.Controls.Add(this.txtPcTitleMale);
            this.Controls.Add(this.lblFemale);
            this.Controls.Add(this.lblMale);
            this.Controls.Add(this.lblPcTitles);
            this.Controls.Add(this.nudHearHeight);
            this.Controls.Add(this.nudHearWidth);
            this.Controls.Add(this.nudMoveSpeed);
            this.Controls.Add(this.nudMoveHeight);
            this.Controls.Add(this.nudMoveWidth);
            this.Controls.Add(this.trvStateTree);
            this.Controls.Add(this.lblHear);
            this.Controls.Add(this.lblMove);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.txtAttacked);
            this.Controls.Add(this.txtLeaving);
            this.Controls.Add(this.txtTalking);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtName);
            this.Name = "NpcSettingsUserControl";
            this.Size = new System.Drawing.Size(817, 617);
            ((System.ComponentModel.ISupportInitialize)(this.nudHearHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHearWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMoveSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMoveHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMoveWidth)).EndInit();
            this.grpPrefabs.ResumeLayout(false);
            this.grpPrefabs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNpcSettings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAttacked;
        private System.Windows.Forms.Label lblLeaving;
        private System.Windows.Forms.Label lblTalking;
        private System.Windows.Forms.TextBox txtPcTitleFemale;
        private System.Windows.Forms.TextBox txtPcTitleMale;
        private System.Windows.Forms.Label lblFemale;
        private System.Windows.Forms.Label lblMale;
        private System.Windows.Forms.Label lblPcTitles;
        private System.Windows.Forms.NumericUpDown nudHearHeight;
        private System.Windows.Forms.NumericUpDown nudHearWidth;
        private System.Windows.Forms.NumericUpDown nudMoveSpeed;
        private System.Windows.Forms.NumericUpDown nudMoveHeight;
        private System.Windows.Forms.NumericUpDown nudMoveWidth;
        private System.Windows.Forms.TreeView trvStateTree;
        private System.Windows.Forms.Label lblHear;
        private System.Windows.Forms.Label lblMove;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox txtAttacked;
        private System.Windows.Forms.TextBox txtLeaving;
        private System.Windows.Forms.TextBox txtTalking;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.BindingSource bdsNpcSettings;
        private System.Windows.Forms.GroupBox grpPrefabs;
        private System.Windows.Forms.TextBox txtPrefabMatches;
        private System.Windows.Forms.ListBox lstPrefabs;
        private System.Windows.Forms.Button btnRemovePrefab;
        private System.Windows.Forms.Button btnAddPrefab;
        private System.Windows.Forms.TextBox txtNewPrefab;
    }
}
