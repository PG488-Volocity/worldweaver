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
            ((System.ComponentModel.ISupportInitialize)(this.worldweaverDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.worldweaverDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCampaigns
            // 
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
            this.listViewPlayers.HideSelection = false;
            this.listViewPlayers.Location = new System.Drawing.Point(84, 182);
            this.listViewPlayers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listViewPlayers.Name = "listViewPlayers";
            this.listViewPlayers.Size = new System.Drawing.Size(1562, 143);
            this.listViewPlayers.TabIndex = 3;
            this.listViewPlayers.UseCompatibleStateImageBehavior = false;
            this.listViewPlayers.SelectedIndexChanged += new System.EventHandler(this.listViewPlayers_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(519, 80);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CampaignPlayersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1666, 1221);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listViewPlayers);
            this.Controls.Add(this.cmbCampaigns);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CampaignPlayersForm";
            this.Text = "CampaignPlayersForm";
            this.Load += new System.EventHandler(this.CampaignPlayersForm_Load);
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
    }
}