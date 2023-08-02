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
            this.btn_mapUpload = new System.Windows.Forms.Button();
            this.btnLoadGame = new System.Windows.Forms.Button();
            this.BtnNewGame = new System.Windows.Forms.Button();
            this.lblintro = new System.Windows.Forms.Label();
            this.btn_navToken = new System.Windows.Forms.Button();
            this.btn_createCampaign = new System.Windows.Forms.Button();
            this.btn_navGridProto = new System.Windows.Forms.Button();
            this.infoBtn = new System.Windows.Forms.Button();
            this.btnNavOpenCampaign = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_mapUpload
            // 
            this.btn_mapUpload.Location = new System.Drawing.Point(274, 280);
            this.btn_mapUpload.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_mapUpload.Name = "btn_mapUpload";
            this.btn_mapUpload.Size = new System.Drawing.Size(196, 77);
            this.btn_mapUpload.TabIndex = 0;
            this.btn_mapUpload.Text = "Upload a Map";
            this.btn_mapUpload.UseVisualStyleBackColor = true;
            this.btn_mapUpload.Click += new System.EventHandler(this.btn_mapUpload_Click);
            // 
            // btnLoadGame
            // 
            this.btnLoadGame.Location = new System.Drawing.Point(516, 174);
            this.btnLoadGame.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLoadGame.Name = "btnLoadGame";
            this.btnLoadGame.Size = new System.Drawing.Size(196, 77);
            this.btnLoadGame.TabIndex = 1;
            this.btnLoadGame.Text = "Load Campaign ";
            this.btnLoadGame.UseVisualStyleBackColor = true;
            this.btnLoadGame.Click += new System.EventHandler(this.btnLoadGame_Click);
            // 
            // BtnNewGame
            // 
            this.BtnNewGame.Location = new System.Drawing.Point(758, 174);
            this.BtnNewGame.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnNewGame.Name = "BtnNewGame";
            this.BtnNewGame.Size = new System.Drawing.Size(196, 77);
            this.BtnNewGame.TabIndex = 2;
            this.BtnNewGame.Text = "Create a Character";
            this.BtnNewGame.UseVisualStyleBackColor = true;
            this.BtnNewGame.Click += new System.EventHandler(this.BtnNewGame_Click);
            // 
            // lblintro
            // 
            this.lblintro.AutoSize = true;
            this.lblintro.Enabled = false;
            this.lblintro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblintro.Location = new System.Drawing.Point(495, 105);
            this.lblintro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblintro.Name = "lblintro";
            this.lblintro.Size = new System.Drawing.Size(196, 20);
            this.lblintro.TabIndex = 3;
            this.lblintro.Text = "Welcome to WorldWeaver ";
            this.lblintro.UseMnemonic = false;
            // 
            // btn_navToken
            // 
            this.btn_navToken.Location = new System.Drawing.Point(516, 280);
            this.btn_navToken.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_navToken.Name = "btn_navToken";
            this.btn_navToken.Size = new System.Drawing.Size(196, 77);
            this.btn_navToken.TabIndex = 4;
            this.btn_navToken.Text = "Upload a Token";
            this.btn_navToken.UseVisualStyleBackColor = true;
            this.btn_navToken.Click += new System.EventHandler(this.btn_navToken_Click);
            // 
            // btn_createCampaign
            // 
            this.btn_createCampaign.Location = new System.Drawing.Point(274, 174);
            this.btn_createCampaign.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_createCampaign.Name = "btn_createCampaign";
            this.btn_createCampaign.Size = new System.Drawing.Size(196, 77);
            this.btn_createCampaign.TabIndex = 5;
            this.btn_createCampaign.Text = "Create a Campaign";
            this.btn_createCampaign.UseVisualStyleBackColor = true;
            this.btn_createCampaign.Click += new System.EventHandler(this.btn_createCampaign_Click);
            // 
            // btn_navGridProto
            // 
            this.btn_navGridProto.Location = new System.Drawing.Point(502, 578);
            this.btn_navGridProto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_navGridProto.Name = "btn_navGridProto";
            this.btn_navGridProto.Size = new System.Drawing.Size(196, 77);
            this.btn_navGridProto.TabIndex = 6;
            this.btn_navGridProto.Text = "Grid Prototype";
            this.btn_navGridProto.UseVisualStyleBackColor = true;
            this.btn_navGridProto.Click += new System.EventHandler(this.btn_navGridProto_Click);
            // 
            // infoBtn
            // 
            this.infoBtn.Location = new System.Drawing.Point(220, 578);
            this.infoBtn.Name = "infoBtn";
            this.infoBtn.Size = new System.Drawing.Size(196, 77);
            this.infoBtn.TabIndex = 7;
            this.infoBtn.Text = "DM Info Sheet";
            this.infoBtn.UseVisualStyleBackColor = true;
            this.infoBtn.Click += new System.EventHandler(this.infoBtn_Click);
            // 
            // btnNavOpenCampaign
            // 
            this.btnNavOpenCampaign.Location = new System.Drawing.Point(758, 280);
            this.btnNavOpenCampaign.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNavOpenCampaign.Name = "btnNavOpenCampaign";
            this.btnNavOpenCampaign.Size = new System.Drawing.Size(196, 77);
            this.btnNavOpenCampaign.TabIndex = 9;
            this.btnNavOpenCampaign.Text = "Open Saved Campaign";
            this.btnNavOpenCampaign.UseVisualStyleBackColor = true;
            this.btnNavOpenCampaign.Click += new System.EventHandler(this.btnNavOpenCampaign_Click);
            // 
            // main_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1406, 692);
            this.Controls.Add(this.btnNavOpenCampaign);
            this.Controls.Add(this.infoBtn);
            this.Controls.Add(this.btn_navGridProto);
            this.Controls.Add(this.btn_createCampaign);
            this.Controls.Add(this.btn_navToken);
            this.Controls.Add(this.lblintro);
            this.Controls.Add(this.BtnNewGame);
            this.Controls.Add(this.btnLoadGame);
            this.Controls.Add(this.btn_mapUpload);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "main_menu";
            this.Text = "main_menu";
            this.Load += new System.EventHandler(this.main_menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_mapUpload;
        private System.Windows.Forms.Button btnLoadGame;
        private System.Windows.Forms.Button BtnNewGame;
        private System.Windows.Forms.Label lblintro;
        private System.Windows.Forms.Button btn_navToken;
        private System.Windows.Forms.Button btn_createCampaign;
        private System.Windows.Forms.Button btn_navGridProto;
        private System.Windows.Forms.Button infoBtn;
        private System.Windows.Forms.Button btnNavOpenCampaign;
    }
}