namespace WorldWeaver
{
    partial class main_menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_menu));
            this.btn_mapUpload = new System.Windows.Forms.Button();
            this.BtnNewGame = new System.Windows.Forms.Button();
            this.lblintro = new System.Windows.Forms.Label();
            this.btn_navToken = new System.Windows.Forms.Button();
            this.btn_createCampaign = new System.Windows.Forms.Button();
            this.infoBtn = new System.Windows.Forms.Button();
            this.btnNavOpenCampaign = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_mapUpload
            // 
            this.btn_mapUpload.BackColor = System.Drawing.Color.Maroon;
            this.btn_mapUpload.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_mapUpload.Location = new System.Drawing.Point(12, 177);
            this.btn_mapUpload.Name = "btn_mapUpload";
            this.btn_mapUpload.Size = new System.Drawing.Size(131, 50);
            this.btn_mapUpload.TabIndex = 0;
            this.btn_mapUpload.Text = "Upload a Map";
            this.btn_mapUpload.UseVisualStyleBackColor = false;
            this.btn_mapUpload.Click += new System.EventHandler(this.btn_mapUpload_Click);
            // 
            // BtnNewGame
            // 
            this.BtnNewGame.BackColor = System.Drawing.Color.Maroon;
            this.BtnNewGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnNewGame.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnNewGame.Location = new System.Drawing.Point(334, 108);
            this.BtnNewGame.Name = "BtnNewGame";
            this.BtnNewGame.Size = new System.Drawing.Size(131, 50);
            this.BtnNewGame.TabIndex = 2;
            this.BtnNewGame.Text = "Create a Character";
            this.BtnNewGame.UseVisualStyleBackColor = false;
            this.BtnNewGame.Click += new System.EventHandler(this.BtnNewGame_Click);
            // 
            // lblintro
            // 
            this.lblintro.AutoSize = true;
            this.lblintro.Enabled = false;
            this.lblintro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblintro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblintro.ForeColor = System.Drawing.Color.Black;
            this.lblintro.Location = new System.Drawing.Point(105, 60);
            this.lblintro.Name = "lblintro";
            this.lblintro.Size = new System.Drawing.Size(259, 24);
            this.lblintro.TabIndex = 3;
            this.lblintro.Text = "Welcome to WorldWeaver ";
            this.lblintro.UseMnemonic = false;
            // 
            // btn_navToken
            // 
            this.btn_navToken.BackColor = System.Drawing.Color.Maroon;
            this.btn_navToken.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_navToken.Location = new System.Drawing.Point(173, 177);
            this.btn_navToken.Name = "btn_navToken";
            this.btn_navToken.Size = new System.Drawing.Size(131, 50);
            this.btn_navToken.TabIndex = 4;
            this.btn_navToken.Text = "Upload a Token";
            this.btn_navToken.UseVisualStyleBackColor = false;
            this.btn_navToken.Click += new System.EventHandler(this.btn_navToken_Click);
            // 
            // btn_createCampaign
            // 
            this.btn_createCampaign.BackColor = System.Drawing.Color.Maroon;
            this.btn_createCampaign.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_createCampaign.Location = new System.Drawing.Point(12, 108);
            this.btn_createCampaign.Name = "btn_createCampaign";
            this.btn_createCampaign.Size = new System.Drawing.Size(131, 50);
            this.btn_createCampaign.TabIndex = 5;
            this.btn_createCampaign.Text = "Create a Campaign";
            this.btn_createCampaign.UseVisualStyleBackColor = false;
            this.btn_createCampaign.Click += new System.EventHandler(this.btn_createCampaign_Click);
            // 
            // infoBtn
            // 
            this.infoBtn.BackColor = System.Drawing.Color.Maroon;
            this.infoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.infoBtn.Location = new System.Drawing.Point(173, 108);
            this.infoBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.infoBtn.Name = "infoBtn";
            this.infoBtn.Size = new System.Drawing.Size(131, 50);
            this.infoBtn.TabIndex = 7;
            this.infoBtn.Text = "DM Info Sheet";
            this.infoBtn.UseVisualStyleBackColor = false;
            this.infoBtn.Click += new System.EventHandler(this.infoBtn_Click);
            // 
            // btnNavOpenCampaign
            // 
            this.btnNavOpenCampaign.BackColor = System.Drawing.Color.Maroon;
            this.btnNavOpenCampaign.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNavOpenCampaign.Location = new System.Drawing.Point(334, 177);
            this.btnNavOpenCampaign.Name = "btnNavOpenCampaign";
            this.btnNavOpenCampaign.Size = new System.Drawing.Size(131, 50);
            this.btnNavOpenCampaign.TabIndex = 9;
            this.btnNavOpenCampaign.Text = "Open Saved Campaign";
            this.btnNavOpenCampaign.UseVisualStyleBackColor = false;
            this.btnNavOpenCampaign.Click += new System.EventHandler(this.btnNavOpenCampaign_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(493, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 276);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // main_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(722, 317);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnNavOpenCampaign);
            this.Controls.Add(this.infoBtn);
            this.Controls.Add(this.btn_createCampaign);
            this.Controls.Add(this.btn_navToken);
            this.Controls.Add(this.lblintro);
            this.Controls.Add(this.BtnNewGame);
            this.Controls.Add(this.btn_mapUpload);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "main_menu";
            this.Text = "main_menu";
            this.Load += new System.EventHandler(this.main_menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_mapUpload;
        private System.Windows.Forms.Button BtnNewGame;
        private System.Windows.Forms.Label lblintro;
        private System.Windows.Forms.Button btn_navToken;
        private System.Windows.Forms.Button btn_createCampaign;
        private System.Windows.Forms.Button infoBtn;
        private System.Windows.Forms.Button btnNavOpenCampaign;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}