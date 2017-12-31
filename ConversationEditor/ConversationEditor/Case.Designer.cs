namespace ConversationEditor
{
    partial class Case
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cmbPrefabs = new System.Windows.Forms.ComboBox();
            this.grpRequirements = new System.Windows.Forms.GroupBox();
            this.btnRemoveRequirement = new System.Windows.Forms.Button();
            this.btnAddMatch = new System.Windows.Forms.Button();
            this.btnAddPrefab = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMatch = new System.Windows.Forms.TextBox();
            this.lblPrefabs = new System.Windows.Forms.Label();
            this.lstRequirements = new System.Windows.Forms.ListBox();
            this.grpActions = new System.Windows.Forms.GroupBox();
            this.txtStateId = new System.Windows.Forms.TextBox();
            this.lblState = new System.Windows.Forms.Label();
            this.txtTradeId = new System.Windows.Forms.TextBox();
            this.lblTrade = new System.Windows.Forms.Label();
            this.nudQuestX = new System.Windows.Forms.NumericUpDown();
            this.txtQuestId = new System.Windows.Forms.TextBox();
            this.lblQuest = new System.Windows.Forms.Label();
            this.lblItemX = new System.Windows.Forms.Label();
            this.nudItemX = new System.Windows.Forms.NumericUpDown();
            this.lblItemId = new System.Windows.Forms.Label();
            this.txtItemId = new System.Windows.Forms.TextBox();
            this.lblItem = new System.Windows.Forms.Label();
            this.txtText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bdsNpcStateCase = new System.Windows.Forms.BindingSource(this.components);
            this.grpRequirements.SuspendLayout();
            this.grpActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuestX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudItemX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNpcStateCase)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbPrefabs
            // 
            this.cmbPrefabs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrefabs.FormattingEnabled = true;
            this.cmbPrefabs.Location = new System.Drawing.Point(58, 21);
            this.cmbPrefabs.Name = "cmbPrefabs";
            this.cmbPrefabs.Size = new System.Drawing.Size(160, 21);
            this.cmbPrefabs.TabIndex = 1;
            // 
            // grpRequirements
            // 
            this.grpRequirements.Controls.Add(this.btnRemoveRequirement);
            this.grpRequirements.Controls.Add(this.btnAddMatch);
            this.grpRequirements.Controls.Add(this.btnAddPrefab);
            this.grpRequirements.Controls.Add(this.label1);
            this.grpRequirements.Controls.Add(this.txtMatch);
            this.grpRequirements.Controls.Add(this.lblPrefabs);
            this.grpRequirements.Controls.Add(this.lstRequirements);
            this.grpRequirements.Controls.Add(this.cmbPrefabs);
            this.grpRequirements.Location = new System.Drawing.Point(12, 9);
            this.grpRequirements.Name = "grpRequirements";
            this.grpRequirements.Size = new System.Drawing.Size(560, 189);
            this.grpRequirements.TabIndex = 2;
            this.grpRequirements.TabStop = false;
            this.grpRequirements.Text = "Requirements";
            // 
            // btnRemoveRequirement
            // 
            this.btnRemoveRequirement.Location = new System.Drawing.Point(324, 159);
            this.btnRemoveRequirement.Name = "btnRemoveRequirement";
            this.btnRemoveRequirement.Size = new System.Drawing.Size(230, 23);
            this.btnRemoveRequirement.TabIndex = 8;
            this.btnRemoveRequirement.Text = "Remove Selected Requirement";
            this.btnRemoveRequirement.UseVisualStyleBackColor = true;
            this.btnRemoveRequirement.Click += new System.EventHandler(this.btnRemoveRequirement_Click);
            // 
            // btnAddMatch
            // 
            this.btnAddMatch.Location = new System.Drawing.Point(224, 46);
            this.btnAddMatch.Name = "btnAddMatch";
            this.btnAddMatch.Size = new System.Drawing.Size(75, 23);
            this.btnAddMatch.TabIndex = 7;
            this.btnAddMatch.Text = "Add Match";
            this.btnAddMatch.UseVisualStyleBackColor = true;
            this.btnAddMatch.Click += new System.EventHandler(this.btnAddMatch_Click);
            // 
            // btnAddPrefab
            // 
            this.btnAddPrefab.Location = new System.Drawing.Point(224, 19);
            this.btnAddPrefab.Name = "btnAddPrefab";
            this.btnAddPrefab.Size = new System.Drawing.Size(75, 23);
            this.btnAddPrefab.TabIndex = 6;
            this.btnAddPrefab.Text = "Add Prefab";
            this.btnAddPrefab.UseVisualStyleBackColor = true;
            this.btnAddPrefab.Click += new System.EventHandler(this.btnAddPrefab_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Match:";
            // 
            // txtMatch
            // 
            this.txtMatch.Location = new System.Drawing.Point(58, 48);
            this.txtMatch.Name = "txtMatch";
            this.txtMatch.Size = new System.Drawing.Size(160, 20);
            this.txtMatch.TabIndex = 4;
            // 
            // lblPrefabs
            // 
            this.lblPrefabs.AutoSize = true;
            this.lblPrefabs.Location = new System.Drawing.Point(11, 24);
            this.lblPrefabs.Name = "lblPrefabs";
            this.lblPrefabs.Size = new System.Drawing.Size(41, 13);
            this.lblPrefabs.TabIndex = 3;
            this.lblPrefabs.Text = "Prefab:";
            // 
            // lstRequirements
            // 
            this.lstRequirements.FormattingEnabled = true;
            this.lstRequirements.Location = new System.Drawing.Point(324, 19);
            this.lstRequirements.Name = "lstRequirements";
            this.lstRequirements.Size = new System.Drawing.Size(230, 134);
            this.lstRequirements.TabIndex = 2;
            // 
            // grpActions
            // 
            this.grpActions.Controls.Add(this.txtStateId);
            this.grpActions.Controls.Add(this.lblState);
            this.grpActions.Controls.Add(this.txtTradeId);
            this.grpActions.Controls.Add(this.lblTrade);
            this.grpActions.Controls.Add(this.nudQuestX);
            this.grpActions.Controls.Add(this.txtQuestId);
            this.grpActions.Controls.Add(this.lblQuest);
            this.grpActions.Controls.Add(this.lblItemX);
            this.grpActions.Controls.Add(this.nudItemX);
            this.grpActions.Controls.Add(this.lblItemId);
            this.grpActions.Controls.Add(this.txtItemId);
            this.grpActions.Controls.Add(this.lblItem);
            this.grpActions.Controls.Add(this.txtText);
            this.grpActions.Controls.Add(this.label2);
            this.grpActions.Location = new System.Drawing.Point(12, 207);
            this.grpActions.Name = "grpActions";
            this.grpActions.Size = new System.Drawing.Size(560, 230);
            this.grpActions.TabIndex = 3;
            this.grpActions.TabStop = false;
            this.grpActions.Text = "Actions";
            // 
            // txtStateId
            // 
            this.txtStateId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNpcStateCase, "StateId", true));
            this.txtStateId.Location = new System.Drawing.Point(58, 197);
            this.txtStateId.Name = "txtStateId";
            this.txtStateId.Size = new System.Drawing.Size(424, 20);
            this.txtStateId.TabIndex = 24;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(17, 200);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(35, 13);
            this.lblState.TabIndex = 23;
            this.lblState.Text = "State:";
            // 
            // txtTradeId
            // 
            this.txtTradeId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNpcStateCase, "TradeId", true));
            this.txtTradeId.Location = new System.Drawing.Point(58, 171);
            this.txtTradeId.Name = "txtTradeId";
            this.txtTradeId.Size = new System.Drawing.Size(424, 20);
            this.txtTradeId.TabIndex = 22;
            // 
            // lblTrade
            // 
            this.lblTrade.AutoSize = true;
            this.lblTrade.Location = new System.Drawing.Point(14, 174);
            this.lblTrade.Name = "lblTrade";
            this.lblTrade.Size = new System.Drawing.Size(38, 13);
            this.lblTrade.TabIndex = 21;
            this.lblTrade.Text = "Trade:";
            // 
            // nudQuestX
            // 
            this.nudQuestX.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bdsNpcStateCase, "QuestX", true));
            this.nudQuestX.Location = new System.Drawing.Point(488, 146);
            this.nudQuestX.Name = "nudQuestX";
            this.nudQuestX.Size = new System.Drawing.Size(60, 20);
            this.nudQuestX.TabIndex = 20;
            // 
            // txtQuestId
            // 
            this.txtQuestId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNpcStateCase, "QuestId", true));
            this.txtQuestId.Location = new System.Drawing.Point(58, 145);
            this.txtQuestId.Name = "txtQuestId";
            this.txtQuestId.Size = new System.Drawing.Size(424, 20);
            this.txtQuestId.TabIndex = 18;
            // 
            // lblQuest
            // 
            this.lblQuest.AutoSize = true;
            this.lblQuest.Location = new System.Drawing.Point(14, 148);
            this.lblQuest.Name = "lblQuest";
            this.lblQuest.Size = new System.Drawing.Size(38, 13);
            this.lblQuest.TabIndex = 17;
            this.lblQuest.Text = "Quest:";
            // 
            // lblItemX
            // 
            this.lblItemX.AutoSize = true;
            this.lblItemX.Location = new System.Drawing.Point(485, 103);
            this.lblItemX.Name = "lblItemX";
            this.lblItemX.Size = new System.Drawing.Size(14, 13);
            this.lblItemX.TabIndex = 16;
            this.lblItemX.Text = "X";
            // 
            // nudItemX
            // 
            this.nudItemX.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bdsNpcStateCase, "ItemX", true));
            this.nudItemX.Location = new System.Drawing.Point(488, 120);
            this.nudItemX.Name = "nudItemX";
            this.nudItemX.Size = new System.Drawing.Size(60, 20);
            this.nudItemX.TabIndex = 15;
            // 
            // lblItemId
            // 
            this.lblItemId.AutoSize = true;
            this.lblItemId.Location = new System.Drawing.Point(55, 103);
            this.lblItemId.Name = "lblItemId";
            this.lblItemId.Size = new System.Drawing.Size(18, 13);
            this.lblItemId.TabIndex = 14;
            this.lblItemId.Text = "ID";
            // 
            // txtItemId
            // 
            this.txtItemId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNpcStateCase, "ItemId", true));
            this.txtItemId.Location = new System.Drawing.Point(58, 119);
            this.txtItemId.Name = "txtItemId";
            this.txtItemId.Size = new System.Drawing.Size(424, 20);
            this.txtItemId.TabIndex = 13;
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(22, 122);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(30, 13);
            this.lblItem.TabIndex = 12;
            this.lblItem.Text = "Item:";
            // 
            // txtText
            // 
            this.txtText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNpcStateCase, "ActionText", true));
            this.txtText.Location = new System.Drawing.Point(58, 19);
            this.txtText.Multiline = true;
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(490, 72);
            this.txtText.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Text:";
            // 
            // bdsNpcStateCase
            // 
            this.bdsNpcStateCase.DataSource = typeof(ConversationEditor.Models.NpcCaseModel);
            // 
            // Case
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 448);
            this.Controls.Add(this.grpActions);
            this.Controls.Add(this.grpRequirements);
            this.Name = "Case";
            this.Text = "Case";
            this.grpRequirements.ResumeLayout(false);
            this.grpRequirements.PerformLayout();
            this.grpActions.ResumeLayout(false);
            this.grpActions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuestX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudItemX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNpcStateCase)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPrefabs;
        private System.Windows.Forms.GroupBox grpRequirements;
        private System.Windows.Forms.Button btnRemoveRequirement;
        private System.Windows.Forms.Button btnAddMatch;
        private System.Windows.Forms.Button btnAddPrefab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMatch;
        private System.Windows.Forms.Label lblPrefabs;
        private System.Windows.Forms.ListBox lstRequirements;
        private System.Windows.Forms.GroupBox grpActions;
        private System.Windows.Forms.TextBox txtStateId;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.TextBox txtTradeId;
        private System.Windows.Forms.Label lblTrade;
        private System.Windows.Forms.NumericUpDown nudQuestX;
        private System.Windows.Forms.TextBox txtQuestId;
        private System.Windows.Forms.Label lblQuest;
        private System.Windows.Forms.Label lblItemX;
        private System.Windows.Forms.NumericUpDown nudItemX;
        private System.Windows.Forms.Label lblItemId;
        private System.Windows.Forms.TextBox txtItemId;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource bdsNpcStateCase;
    }
}