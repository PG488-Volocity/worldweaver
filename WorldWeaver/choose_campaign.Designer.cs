namespace WorldWeaver
{
    partial class choose_campaign
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.campaignsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.worldweaverDataSet = new WorldWeaver.worldweaverDataSet();
            this.campaignsTableAdapter = new WorldWeaver.worldweaverDataSetTableAdapters.campaignsTableAdapter();
            this.nxtBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.campaignsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.worldweaverDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 144);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose Campaign:";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.campaignsBindingSource, "campaign_id", true));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(219, 144);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(133, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // campaignsBindingSource
            // 
            this.campaignsBindingSource.DataMember = "campaigns";
            this.campaignsBindingSource.DataSource = this.worldweaverDataSet;
            // 
            // worldweaverDataSet
            // 
            this.worldweaverDataSet.DataSetName = "worldweaverDataSet";
            this.worldweaverDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // campaignsTableAdapter
            // 
            this.campaignsTableAdapter.ClearBeforeFill = true;
            // 
            // nxtBtn
            // 
            this.nxtBtn.BackColor = System.Drawing.Color.Maroon;
            this.nxtBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.nxtBtn.Location = new System.Drawing.Point(385, 289);
            this.nxtBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nxtBtn.Name = "nxtBtn";
            this.nxtBtn.Size = new System.Drawing.Size(97, 27);
            this.nxtBtn.TabIndex = 3;
            this.nxtBtn.Text = "Next";
            this.nxtBtn.UseVisualStyleBackColor = false;
            this.nxtBtn.Click += new System.EventHandler(this.nxtBtn_Click);
            // 
            // choose_campaign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(603, 384);
            this.Controls.Add(this.nxtBtn);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "choose_campaign";
            this.Text = "choose_campaign";
            this.Load += new System.EventHandler(this.choose_campaign_Load);
            ((System.ComponentModel.ISupportInitialize)(this.campaignsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.worldweaverDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private worldweaverDataSet worldweaverDataSet;
        private System.Windows.Forms.BindingSource campaignsBindingSource;
        private worldweaverDataSetTableAdapters.campaignsTableAdapter campaignsTableAdapter;
        private System.Windows.Forms.Button nxtBtn;
    }
}