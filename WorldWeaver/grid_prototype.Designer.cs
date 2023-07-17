namespace WorldWeaver
{
    partial class grid_prototype
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnRoll = new System.Windows.Forms.Button();
            this.userControl11 = new WorldWeaver.UserControl1();
            this.diceRoller = new System.Windows.Forms.TextBox();
            this.lblDR = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(109, 29);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(600, 400);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnRoll
            // 
            this.btnRoll.Location = new System.Drawing.Point(13, 243);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(75, 23);
            this.btnRoll.TabIndex = 2;
            this.btnRoll.Text = "Roll";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // userControl11
            // 
            this.userControl11.AutoSize = true;
            this.userControl11.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.userControl11.Location = new System.Drawing.Point(370, 435);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(69, 44);
            this.userControl11.TabIndex = 1;
            // 
            // diceRoller
            // 
            this.diceRoller.Location = new System.Drawing.Point(13, 217);
            this.diceRoller.Name = "diceRoller";
            this.diceRoller.Size = new System.Drawing.Size(90, 20);
            this.diceRoller.TabIndex = 3;
            this.diceRoller.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.diceRoller_KeyPress);
            // 
            // lblDR
            // 
            this.lblDR.AutoSize = true;
            this.lblDR.Location = new System.Drawing.Point(13, 198);
            this.lblDR.Name = "lblDR";
            this.lblDR.Size = new System.Drawing.Size(52, 13);
            this.lblDR.TabIndex = 4;
            this.lblDR.Text = "dice roller";
            // 
            // grid_prototype
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 487);
            this.Controls.Add(this.lblDR);
            this.Controls.Add(this.diceRoller);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "grid_prototype";
            this.Text = "grid_prototype";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private UserControl1 userControl11;
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.TextBox diceRoller;
        private System.Windows.Forms.Label lblDR;
    }
}