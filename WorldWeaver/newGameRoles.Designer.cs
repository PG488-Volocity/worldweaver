﻿
namespace WorldWeaver
{
    partial class RolesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RolesForm));
            this.butDM = new System.Windows.Forms.Button();
            this.BtlPlayer = new System.Windows.Forms.Button();
            this.lblslect = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // butDM
            // 
            this.butDM.BackColor = System.Drawing.Color.Maroon;
            this.butDM.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butDM.Location = new System.Drawing.Point(60, 84);
            this.butDM.Name = "butDM";
            this.butDM.Size = new System.Drawing.Size(81, 41);
            this.butDM.TabIndex = 0;
            this.butDM.Text = "NPC";
            this.butDM.UseVisualStyleBackColor = false;
            this.butDM.Click += new System.EventHandler(this.butDM_Click);
            // 
            // BtlPlayer
            // 
            this.BtlPlayer.AutoSize = true;
            this.BtlPlayer.BackColor = System.Drawing.Color.Maroon;
            this.BtlPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtlPlayer.Location = new System.Drawing.Point(160, 84);
            this.BtlPlayer.Name = "BtlPlayer";
            this.BtlPlayer.Size = new System.Drawing.Size(75, 41);
            this.BtlPlayer.TabIndex = 1;
            this.BtlPlayer.Text = "Player ";
            this.BtlPlayer.UseVisualStyleBackColor = false;
            this.BtlPlayer.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblslect
            // 
            this.lblslect.AutoSize = true;
            this.lblslect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblslect.Location = new System.Drawing.Point(56, 31);
            this.lblslect.Name = "lblslect";
            this.lblslect.Size = new System.Drawing.Size(179, 20);
            this.lblslect.TabIndex = 2;
            this.lblslect.Text = "Select a Character Type";
            // 
            // RolesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(294, 216);
            this.Controls.Add(this.lblslect);
            this.Controls.Add(this.BtlPlayer);
            this.Controls.Add(this.butDM);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RolesForm";
            this.Text = "Roles";
            this.Load += new System.EventHandler(this.RolesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butDM;
        private System.Windows.Forms.Button BtlPlayer;
        private System.Windows.Forms.Label lblslect;
    }
}