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
            this.cmbCampaigns = new System.Windows.Forms.ComboBox();
            this.worldweaverDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.worldweaverDataSet = new WorldWeaver.worldweaverDataSet();
            this.listViewPlayers = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.listViewNPCs = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.worldweaverDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.worldweaverDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCampaigns
            // 
            this.cmbCampaigns.FormattingEnabled = true;
            this.cmbCampaigns.Location = new System.Drawing.Point(186, 52);
            this.cmbCampaigns.Name = "cmbCampaigns";
            this.cmbCampaigns.Size = new System.Drawing.Size(121, 21);
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
            this.listViewPlayers.HideSelection = false;
            this.listViewPlayers.Location = new System.Drawing.Point(56, 131);
            this.listViewPlayers.Name = "listViewPlayers";
            this.listViewPlayers.Size = new System.Drawing.Size(1043, 181);
            this.listViewPlayers.TabIndex = 3;
            this.listViewPlayers.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(346, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listViewNPCs
            // 
            this.listViewNPCs.HideSelection = false;
            this.listViewNPCs.Location = new System.Drawing.Point(56, 337);
            this.listViewNPCs.Name = "listViewNPCs";
            this.listViewNPCs.Size = new System.Drawing.Size(1043, 198);
            this.listViewNPCs.TabIndex = 5;
            this.listViewNPCs.UseCompatibleStateImageBehavior = false;
            // 
            // CampaignPlayersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 610);
            this.Controls.Add(this.listViewNPCs);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listViewPlayers);
            this.Controls.Add(this.cmbCampaigns);
            this.Name = "CampaignPlayersForm";
            this.Text = "CampaignPlayersForm";
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
    }
}