﻿namespace WorldWeaver
{
    partial class Form1
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
            this.lbl_mapName = new System.Windows.Forms.Label();
            this.txt_mapName = new System.Windows.Forms.TextBox();
            this.btn_mapFilePicker = new System.Windows.Forms.Button();
            this.lbl_mapFilePicker = new System.Windows.Forms.Label();
            this.img_uploadPreview = new System.Windows.Forms.PictureBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.btn_mapNameOkay = new System.Windows.Forms.Button();
            this.btn_navMainMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.img_uploadPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_mapName
            // 
            this.lbl_mapName.AutoSize = true;
            this.lbl_mapName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbl_mapName.Location = new System.Drawing.Point(32, 74);
            this.lbl_mapName.Name = "lbl_mapName";
            this.lbl_mapName.Size = new System.Drawing.Size(145, 31);
            this.lbl_mapName.TabIndex = 0;
            this.lbl_mapName.Text = "Map Name";
            this.lbl_mapName.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_mapName
            // 
            this.txt_mapName.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txt_mapName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_mapName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txt_mapName.Location = new System.Drawing.Point(183, 67);
            this.txt_mapName.Name = "txt_mapName";
            this.txt_mapName.Size = new System.Drawing.Size(397, 38);
            this.txt_mapName.TabIndex = 1;
            // 
            // btn_mapFilePicker
            // 
            this.btn_mapFilePicker.BackColor = System.Drawing.Color.Maroon;
            this.btn_mapFilePicker.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_mapFilePicker.Location = new System.Drawing.Point(211, 118);
            this.btn_mapFilePicker.Name = "btn_mapFilePicker";
            this.btn_mapFilePicker.Size = new System.Drawing.Size(150, 38);
            this.btn_mapFilePicker.TabIndex = 3;
            this.btn_mapFilePicker.Text = "Browse...";
            this.btn_mapFilePicker.UseVisualStyleBackColor = false;
            this.btn_mapFilePicker.Click += new System.EventHandler(this.btn_mapFilePicker_Click_1);
            // 
            // lbl_mapFilePicker
            // 
            this.lbl_mapFilePicker.AutoSize = true;
            this.lbl_mapFilePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbl_mapFilePicker.Location = new System.Drawing.Point(32, 118);
            this.lbl_mapFilePicker.Name = "lbl_mapFilePicker";
            this.lbl_mapFilePicker.Size = new System.Drawing.Size(182, 31);
            this.lbl_mapFilePicker.TabIndex = 2;
            this.lbl_mapFilePicker.Text = "Upload Image";
            this.lbl_mapFilePicker.Click += new System.EventHandler(this.lbl_mapFilePicker_Click);
            // 
            // img_uploadPreview
            // 
            this.img_uploadPreview.Location = new System.Drawing.Point(376, 118);
            this.img_uploadPreview.Name = "img_uploadPreview";
            this.img_uploadPreview.Size = new System.Drawing.Size(281, 283);
            this.img_uploadPreview.TabIndex = 5;
            this.img_uploadPreview.TabStop = false;
            // 
            // btn_submit
            // 
            this.btn_submit.BackColor = System.Drawing.Color.Maroon;
            this.btn_submit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_submit.Location = new System.Drawing.Point(211, 363);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(150, 38);
            this.btn_submit.TabIndex = 7;
            this.btn_submit.Text = "SUBMIT";
            this.btn_submit.UseVisualStyleBackColor = false;
            this.btn_submit.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_mapNameOkay
            // 
            this.btn_mapNameOkay.BackColor = System.Drawing.Color.Maroon;
            this.btn_mapNameOkay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_mapNameOkay.Location = new System.Drawing.Point(587, 67);
            this.btn_mapNameOkay.Name = "btn_mapNameOkay";
            this.btn_mapNameOkay.Size = new System.Drawing.Size(70, 38);
            this.btn_mapNameOkay.TabIndex = 8;
            this.btn_mapNameOkay.Text = "Next";
            this.btn_mapNameOkay.UseVisualStyleBackColor = false;
            this.btn_mapNameOkay.Click += new System.EventHandler(this.btn_mapNameOkay_Click);
            // 
            // btn_navMainMenu
            // 
            this.btn_navMainMenu.BackColor = System.Drawing.Color.Maroon;
            this.btn_navMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_navMainMenu.Location = new System.Drawing.Point(38, 13);
            this.btn_navMainMenu.Name = "btn_navMainMenu";
            this.btn_navMainMenu.Size = new System.Drawing.Size(75, 23);
            this.btn_navMainMenu.TabIndex = 9;
            this.btn_navMainMenu.Text = "Main Menu";
            this.btn_navMainMenu.UseVisualStyleBackColor = false;
            this.btn_navMainMenu.Click += new System.EventHandler(this.btn_navMainMenu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_navMainMenu);
            this.Controls.Add(this.btn_mapNameOkay);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.img_uploadPreview);
            this.Controls.Add(this.btn_mapFilePicker);
            this.Controls.Add(this.lbl_mapFilePicker);
            this.Controls.Add(this.txt_mapName);
            this.Controls.Add(this.lbl_mapName);
            this.Name = "Form1";
            this.Text = "Map";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img_uploadPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_mapName;
        private System.Windows.Forms.TextBox txt_mapName;
        private System.Windows.Forms.Button btn_mapFilePicker;
        private System.Windows.Forms.Label lbl_mapFilePicker;
        private System.Windows.Forms.PictureBox img_uploadPreview;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Button btn_mapNameOkay;
        private System.Windows.Forms.Button btn_navMainMenu;
    }
}

