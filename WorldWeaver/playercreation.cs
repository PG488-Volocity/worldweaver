using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlTypes;
using System.Data.Sql;

namespace WorldWeaver
{
    public partial class playercreation : Form
    {
        public playercreation()
        {
            InitializeComponent();
        }

        private void ClearForm()
        {
            ClearControls(this);
        }

        private void ClearControls(Control parentControl)
        {
            foreach (Control control in parentControl.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Text = string.Empty;
                }
                else if (control is RichTextBox richTextBox)
                {
                    richTextBox.Clear();
                }
                else if (control.HasChildren)
                {
                    ClearControls(control);
                }
            }
        }

        private void playercreation_Load(object sender, EventArgs e)
        {
            // Populate the cmb_tokenSelect combo box with token names from the database
            string connectionString = ConfigurationManager.ConnectionStrings["MyDatabaseConnectionString"].ConnectionString;
            string selectQuery = "SELECT token_name FROM tokens";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(selectQuery, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cmb_tokenSelect.Items.Add(reader["token_name"].ToString());
                        }
                    }
                }
            }
        }

        private void schara_Click(object sender, EventArgs e)
        {

            if (cmb_tokenSelect.SelectedItem == null)
            {
                MessageBox.Show("Please select a token for the player!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //No error for notes as they are optional
            else if (string.IsNullOrEmpty(pnameBox.Text))
            {
                MessageBox.Show("Please enter your name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (string.IsNullOrEmpty(raceBox.Text))
            {
                MessageBox.Show("Please enter your race!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (string.IsNullOrEmpty(lvlBox.Text))
            {
                MessageBox.Show("Please enter your level, even if it's very low!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (string.IsNullOrEmpty(clsBox.Text))
            {
                MessageBox.Show("Please enter your class!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (string.IsNullOrEmpty(hpBox.Text))
            {
                MessageBox.Show("You can't go in without any health points!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (string.IsNullOrEmpty(strBox.Text))
            {
                MessageBox.Show("Please fill out the strength box. Even the weakest creatures have some form of strength!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (string.IsNullOrEmpty(dexBox.Text))
            {
                MessageBox.Show("Unless you're dexterity is absolutely zero, please fill out the Dexterity box!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (string.IsNullOrEmpty(conBox.Text))
            {
                MessageBox.Show("Please fill out the constitution box", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (string.IsNullOrEmpty(inteBox.Text))
            {
                MessageBox.Show("If you made it this far, you should be intelligent enough to fill out the Intelligence box!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (string.IsNullOrEmpty(wisBox.Text))
            {
                MessageBox.Show("It would be wise to fill out the Wisdom box.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (string.IsNullOrEmpty(chaBox.Text))
            {
                MessageBox.Show("I may not have enough charisma to fill this out, but you might, please do!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (string.IsNullOrEmpty(pbBox.Text))
            {
                MessageBox.Show("Please fill out the Proficiency Bonus box!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (string.IsNullOrEmpty(wsBox.Text))
            {
                MessageBox.Show("Please fill out the Walking Speed box!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (string.IsNullOrEmpty(initBox.Text))
            {
                MessageBox.Show("Take the initiative and fill out the Initiative box, please!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (string.IsNullOrEmpty(acBox.Text))
            {
                MessageBox.Show("Unless you're completely naked, please fill out the armor class!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            else
            {
                string connectionString = ConfigurationManager.ConnectionStrings["MyDatabaseConnectionString"].ConnectionString;

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("INSERT INTO player (name, race, level, class, notes_to_dm, hit_points, strength, dexterity, constitution, intelligence, wisdom, charisma, proficiency_bonus, walking_speed, initiative, armor_class, token_id) VALUES (@playerName, @race, @level, @clas, @notes, @hp, @strength, @dexterity, @constitution, @intelligence, @wisdom, @charisma, @proficiencyBonus, @walkingSpeed, @initiative, @armorClass, @tokenId)", conn))
                    {
                        //Character info
                        cmd.Parameters.Add("@playerName", SqlDbType.NVarChar, 255).Value = pnameBox.Text;
                        cmd.Parameters.Add("@race", SqlDbType.NVarChar, 255).Value = raceBox.Text;
                        cmd.Parameters.Add("@level", SqlDbType.Int).Value = lvlBox.Text;
                        cmd.Parameters.Add("@clas", SqlDbType.NVarChar, 255).Value = clsBox.Text;
                        cmd.Parameters.Add("@notes", SqlDbType.NVarChar, 255).Value = notesBox.Text;

                        //Character stats
                        cmd.Parameters.Add("@hp", SqlDbType.Int).Value = hpBox.Text;
                        cmd.Parameters.Add("@strength", SqlDbType.Int).Value = strBox.Text;
                        cmd.Parameters.Add("@dexterity", SqlDbType.Int).Value = dexBox.Text;
                        cmd.Parameters.Add("@constitution", SqlDbType.Int).Value = conBox.Text;
                        cmd.Parameters.Add("@intelligence", SqlDbType.Int).Value = inteBox.Text;
                        cmd.Parameters.Add("@wisdom", SqlDbType.Int).Value = wisBox.Text;
                        cmd.Parameters.Add("@charisma", SqlDbType.Int).Value = chaBox.Text;
                        cmd.Parameters.Add("@proficiencyBonus", SqlDbType.Int).Value = pbBox.Text;
                        cmd.Parameters.Add("@walkingSpeed", SqlDbType.Int).Value = wsBox.Text;
                        cmd.Parameters.Add("@initiative", SqlDbType.Int).Value = initBox.Text;
                        cmd.Parameters.Add("@armorClass", SqlDbType.Int).Value = acBox.Text;

                        // Token ID - get the selected token name and find its corresponding ID in the tokens table
                        int tokenId = 0;
                        string selectedTokenName = cmb_tokenSelect.SelectedItem.ToString();
                        string selectTokenQuery = "SELECT token_id FROM tokens WHERE token_name = @tokenName";

                        using (SqlCommand tokenCmd = new SqlCommand(selectTokenQuery, conn))
                        {
                            tokenCmd.Parameters.Add("@tokenName", SqlDbType.NVarChar, 255).Value = selectedTokenName;
                            var tokenResult = tokenCmd.ExecuteScalar();
                            if (tokenResult != null)
                            {
                                tokenId = Convert.ToInt32(tokenResult);
                            }
                        }

                        cmd.Parameters.Add("@tokenId", SqlDbType.Int).Value = tokenId;

                        cmd.ExecuteNonQuery();
                    }
                }
                var result = MessageBox.Show("Character saved! Create another?", "Success!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    ClearForm();
                }
                else if (result == DialogResult.No)
                {
                    worldform worldform = new worldform();
                    worldform.Show();
                    this.Hide();
                }
            }
        }

        private void pnameBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void raceBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void lvlBox_TextChanged(object sender, EventArgs e)
        {

        }
        //textbox prevents strings from being entered
        private void lvlBox_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void hpBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void hpBox_KeyPress_2(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void strBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void strBox_KeyPress_3(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dexBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dexBox_KeyPress_4(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void conBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void conBox_KeyPress_5(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void inteBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void inteBox_KeyPress_6(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void wisBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void wisBox_KeyPress_7(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void chaBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void chaBox_KeyPress_8(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void pbBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pbBox_KeyPress_9(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void wsBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void wsBox_KeyPress_10(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void initBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void initBox_KeyPress_11(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void acBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void acBox_KeyPress_12(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_tokennav_Click(object sender, EventArgs e)
        {
            // Display a confirmation dialog
            var result = MessageBox.Show("This will take you to create a new token, and you will lose any changes to this form. Continue?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            // Check the user's response
            if (result == DialogResult.Yes)
            {
                // Close the current form (NPCForm)
                this.Close();

                // Open the upload_token form
                upload_token uploadTokenForm = new upload_token();
                uploadTokenForm.Show();
            }
            else if (result == DialogResult.No)
            {
                // User chose not to proceed, so do nothing and let them continue working on the current form (NPCForm)
            }
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            {
                main_menu main_menu = new main_menu();
                main_menu.Show();
                this.Hide();
            }
        }
    }
}
