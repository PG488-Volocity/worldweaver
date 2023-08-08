namespace WorldWeaver
{
    partial class CampaignPlayersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CampaignPlayersForm));
            this.cmbCampaigns = new System.Windows.Forms.ComboBox();
            this.worldweaverDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.worldweaverDataSet = new WorldWeaver.worldweaverDataSet();
            this.listViewPlayers = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.listViewNPCs = new System.Windows.Forms.ListView();
            this.mnmenuBtn = new System.Windows.Forms.Button();
            this.btnMain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.worldweaverDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.worldweaverDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCampaigns
            // 
            this.cmbCampaigns.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmbCampaigns.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbCampaigns.FormattingEnabled = true;
            this.cmbCampaigns.Location = new System.Drawing.Point(279, 80);
            this.cmbCampaigns.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbCampaigns.Name = "cmbCampaigns";
            this.cmbCampaigns.Size = new System.Drawing.Size(180, 28);
            this.cmbCampaigns.TabIndex = 0;
            // 
            // worldweaverDataSetBindingSource
            // 
            this.worldweaverDataSetBindingSource.DataSource = this.worldweaverDataSet;
            this.worldweaverDataSetBindingSource.Position = 0;
            // 
            // worldweaverDataSet
            // 
            this.worldweaverDataSet.DataSetName = "worldweaverDataSet";
            this.worldweaverDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listViewPlayers
            // 
            this.listViewPlayers.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.listViewPlayers.HideSelection = false;
            this.listViewPlayers.Location = new System.Drawing.Point(84, 202);
            this.listViewPlayers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listViewPlayers.Name = "listViewPlayers";
            this.listViewPlayers.Size = new System.Drawing.Size(1562, 276);
            this.listViewPlayers.TabIndex = 3;
            this.listViewPlayers.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(519, 80);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "Load Players";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listViewNPCs
            // 
            this.listViewNPCs.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.listViewNPCs.HideSelection = false;
            this.listViewNPCs.Location = new System.Drawing.Point(84, 518);
            this.listViewNPCs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listViewNPCs.Name = "listViewNPCs";
            this.listViewNPCs.Size = new System.Drawing.Size(1562, 302);
            this.listViewNPCs.TabIndex = 5;
            this.listViewNPCs.UseCompatibleStateImageBehavior = false;
            this.listViewNPCs.SelectedIndexChanged += new System.EventHandler(this.listViewNPCs_SelectedIndexChanged);
            // 
            // mnmenuBtn
            // 
            this.mnmenuBtn.Location = new System.Drawing.Point(1512, 931);
            this.mnmenuBtn.Name = "mnmenuBtn";
            this.mnmenuBtn.Size = new System.Drawing.Size(134, 43);
            this.mnmenuBtn.TabIndex = 6;
            this.mnmenuBtn.Text = "Main Menu";
            this.mnmenuBtn.UseVisualStyleBackColor = true;
            this.mnmenuBtn.Click += new System.EventHandler(this.mnmenuBtn_Click);
            // 
            // btnMain
            // 
            this.btnMain.BackColor = System.Drawing.Color.Maroon;
            this.btnMain.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMain.Location = new System.Drawing.Point(84, 80);
            this.btnMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(112, 32);
            this.btnMain.TabIndex = 7;
            this.btnMain.Text = "Main Menu";
            this.btnMain.UseVisualStyleBackColor = false;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // CampaignPlayersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1714, 996);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.mnmenuBtn);
            this.Controls.Add(this.listViewNPCs);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listViewPlayers);
            this.Controls.Add(this.cmbCampaigns);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CampaignPlayersForm";
            this.Text = "Campaign Players Form";
            this.Load += new System.EventHandler(this.CampaignPlayersForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.worldweaverDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.worldweaverDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCampaigns;
        private System.Windows.Forms.BindingSource worldweaverDataSetBindingSource;
        private worldweaverDataSet worldweaverDataSet;
        private System.Windows.Forms.ListView listViewPlayers;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listViewNPCs;
        private System.Windows.Forms.Button mnmenuBtn;
        private System.Windows.Forms.Button btnMain;
    }
}