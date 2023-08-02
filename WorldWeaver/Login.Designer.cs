namespace WorldWeaver
{
    partial class Login
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
            this.usrnmLabel = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.passtxtBox = new System.Windows.Forms.TextBox();
            this.usertxtBox = new System.Windows.Forms.TextBox();
            this.enterBtn = new System.Windows.Forms.Button();
            this.haBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usrnmLabel
            // 
            this.usrnmLabel.AutoSize = true;
            this.usrnmLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usrnmLabel.Location = new System.Drawing.Point(93, 192);
            this.usrnmLabel.Name = "usrnmLabel";
            this.usrnmLabel.Size = new System.Drawing.Size(193, 29);
            this.usrnmLabel.TabIndex = 0;
            this.usrnmLabel.Text = "Enter Username:";
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passLabel.Location = new System.Drawing.Point(93, 300);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(189, 29);
            this.passLabel.TabIndex = 1;
            this.passLabel.Text = "Enter Password:";
            // 
            // passtxtBox
            // 
            this.passtxtBox.Location = new System.Drawing.Point(292, 304);
            this.passtxtBox.Name = "passtxtBox";
            this.passtxtBox.Size = new System.Drawing.Size(257, 26);
            this.passtxtBox.TabIndex = 2;
            this.passtxtBox.TextChanged += new System.EventHandler(this.passtxtBox_TextChanged);
            // 
            // usertxtBox
            // 
            this.usertxtBox.Location = new System.Drawing.Point(292, 196);
            this.usertxtBox.Name = "usertxtBox";
            this.usertxtBox.Size = new System.Drawing.Size(257, 26);
            this.usertxtBox.TabIndex = 3;
            // 
            // enterBtn
            // 
            this.enterBtn.Location = new System.Drawing.Point(417, 416);
            this.enterBtn.Name = "enterBtn";
            this.enterBtn.Size = new System.Drawing.Size(131, 38);
            this.enterBtn.TabIndex = 4;
            this.enterBtn.Text = "Enter";
            this.enterBtn.UseVisualStyleBackColor = true;
            this.enterBtn.Click += new System.EventHandler(this.enterBtn_Click);
            // 
            // haBtn
            // 
            this.haBtn.Location = new System.Drawing.Point(417, 504);
            this.haBtn.Name = "haBtn";
            this.haBtn.Size = new System.Drawing.Size(132, 43);
            this.haBtn.TabIndex = 5;
            this.haBtn.Text = "Main Menu";
            this.haBtn.UseVisualStyleBackColor = true;
            this.haBtn.Click += new System.EventHandler(this.haBtn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 671);
            this.Controls.Add(this.haBtn);
            this.Controls.Add(this.enterBtn);
            this.Controls.Add(this.usertxtBox);
            this.Controls.Add(this.passtxtBox);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.usrnmLabel);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usrnmLabel;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.TextBox passtxtBox;
        private System.Windows.Forms.TextBox usertxtBox;
        private System.Windows.Forms.Button enterBtn;
        private System.Windows.Forms.Button haBtn;
    }
}