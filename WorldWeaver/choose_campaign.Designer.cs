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
            this.worldweaverDataSet = new WorldWeaver.worldweaverDataSet();
            this.campaignsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.campaignsTableAdapter = new WorldWeaver.worldweaverDataSetTableAdapters.campaignsTableAdapter();
            this.nxtBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.worldweaverDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.campaignsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose Campaign:";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.campaignsBindingSource, "campaign_id", true));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(329, 222);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(197, 28);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // worldweaverDataSet
            // 
            this.worldweaverDataSet.DataSetName = "worldweaverDataSet";
            this.worldweaverDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // campaignsBindingSource
            // 
            this.campaignsBindingSource.DataMember = "campaigns";
            this.campaignsBindingSource.DataSource = this.worldweaverDataSet;
            // 
            // campaignsTableAdapter
            // 
            this.campaignsTableAdapter.ClearBeforeFill = true;
            // 
            // nxtBtn
            // 
            this.nxtBtn.Location = new System.Drawing.Point(577, 444);
            this.nxtBtn.Name = "nxtBtn";
            this.nxtBtn.Size = new System.Drawing.Size(145, 41);
            this.nxtBtn.TabIndex = 3;
            this.nxtBtn.Text = "Next";
            this.nxtBtn.UseVisualStyleBackColor = true;
            this.nxtBtn.Click += new System.EventHandler(this.nxtBtn_Click);
            // 
            // choose_campaign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 591);
            this.Controls.Add(this.nxtBtn);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "choose_campaign";
            this.Text = "choose_campaign";
            this.Load += new System.EventHandler(this.choose_campaign_Load);
            ((System.ComponentModel.ISupportInitialize)(this.worldweaverDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.campaignsBindingSource)).EndInit();
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