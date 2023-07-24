using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorldWeaver
{
    public partial class grid_prototype : Form
    {
        private Point initialPosition;
        private int cellWidth;
        private int cellHeight;
        private decimal previousNumTokensValue = 0; // Store the previous value of numTokens

        public grid_prototype()
        {
            InitializeComponent();

            // Attach event handlers for the necessary mouse events
            userControl11.MouseDown += UserControl_MouseDown;
            userControl11.MouseMove += UserControl_MouseMove;
            userControl11.MouseUp += UserControl_MouseUp;

            // Center the TableLayoutPanel on the form
            tableLayoutPanel1.Left = (this.ClientSize.Width - tableLayoutPanel1.Width) / 2;
            tableLayoutPanel1.Top = (this.ClientSize.Height - tableLayoutPanel1.Height) / 2;

            // Calculate the size of each cell in the TableLayoutPanel
            cellWidth = tableLayoutPanel1.Width / tableLayoutPanel1.ColumnCount;
            cellHeight = tableLayoutPanel1.Height / tableLayoutPanel1.RowCount;

            numTokens.ValueChanged += numTokens_ValueChanged; // Event handler to update token count
        }

        private void numTokens_ValueChanged(object sender, EventArgs e)
        {
            if (numTokens.Value > previousNumTokensValue) // If the new value is greater than the old one
            {
                var newToken = new UserControl1(); // Create a new token

                newToken.Size = userControl11.Size; // Copy size from userControl11
                newToken.Location = new Point(userControl11.Location.X, userControl11.Location.Y + userControl11.Height + 10); // Position the new token below the existing one
                newToken.BackColor = userControl11.BackColor; // Copy back color from userControl11
                // Copy any other properties from userControl11 that you need...

                // Attach the same mouse event handlers
                newToken.MouseDown += UserControl_MouseDown;
                newToken.MouseMove += UserControl_MouseMove;
                newToken.MouseUp += UserControl_MouseUp;

                // Add the new token to the form
                this.Controls.Add(newToken);
                newToken.BringToFront();
            }

            // Update the stored previous value of numTokens
            previousNumTokensValue = numTokens.Value;
        }

        //pick up token at initial position
        private void UserControl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                initialPosition = e.Location;
            }
        }

        //drag token when mouse moves
        private void UserControl_MouseMove(object sender, MouseEventArgs e)
        {
            UserControl1 token = sender as UserControl1;
            if (token != null && e.Button == MouseButtons.Left)
            {
                if (initialPosition != Point.Empty)
                {
                    int dx = e.Location.X - initialPosition.X;
                    int dy = e.Location.Y - initialPosition.Y;
                    token.Left += dx;
                    token.Top += dy;
                }
            }
        }


        //snap token to nearest position on mouse up
        private void UserControl_MouseUp(object sender, MouseEventArgs e)
        {
            UserControl1 token = sender as UserControl1;
            if (token != null && e.Button == MouseButtons.Left)
            {
                initialPosition = Point.Empty;

                // Calculate the nearest cell based on the UserControl's center point
                int nearestCellX = (token.Left + token.Width / 2 - tableLayoutPanel1.Left) / cellWidth;
                int nearestCellY = (token.Top + token.Height / 2 - tableLayoutPanel1.Top) / cellHeight;

                // Calculate the new position for the UserControl based on the nearest cell
                int newLeft = tableLayoutPanel1.Left + nearestCellX * cellWidth + (cellWidth - token.Width) / 2;
                int newTop = tableLayoutPanel1.Top + nearestCellY * cellHeight + (cellHeight - token.Height) / 2;

                token.Left = newLeft;
                token.Top = newTop;
            }
        }

        private void diceRoller_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void btnRoll_Click(object sender, EventArgs e)
        {
            int sides = int.Parse(diceRoller.Text);
            int result;

            if (sides > 0)
            {
                Random random = new Random();
                result = random.Next(1, sides + 1);
            }
            else
            {
                // invalid input handler
                MessageBox.Show("Invalid number of sides. Please enter a positive integer.");
                return;
            }

            // showes roll 
            MessageBox.Show($"You rolled a {result}!");
        }
    }
}
