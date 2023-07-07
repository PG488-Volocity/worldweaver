﻿using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WorldWeaver
{
    public partial class upload_token : Form
    {
        private string selectedFilePath;

        public upload_token()
        {
            InitializeComponent();

            // Disable the submit button and hide the file picker and label
            btn_submit.Enabled = false;
            lbl_tokenFilePicker.Visible = false;
            btn_tokenFilePicker.Visible = false;
        }

        private void btn_tokenNext_Click(object sender, EventArgs e)
        {
            // Validate if token name is entered
            if (string.IsNullOrEmpty(txt_tokenName.Text))
            {
                MessageBox.Show("Please enter a token name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Show the file picker and label
            lbl_tokenFilePicker.Visible = true;
            btn_tokenFilePicker.Visible = true;
        }

        private void btn_tokenFilePicker_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpeg;*.jpg;*.png";
            openFileDialog.Title = "Select an Image File";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the selected file path
                selectedFilePath = openFileDialog.FileName;

                // Load the selected image into the PictureBox
                Image selectedImage = Image.FromFile(selectedFilePath);

                // Resize the image to fit within the PictureBox
                img_tokenPreview.SizeMode = PictureBoxSizeMode.StretchImage;
                img_tokenPreview.Image = selectedImage;

                // Disable the submit button
                btn_submit.Enabled = false;
            }
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (img_tokenPreview.Image == null || string.IsNullOrEmpty(txt_tokenName.Text))
            {
                MessageBox.Show("Both a token name and an image must be selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Save the token information to the database

                // Show a success message
                MessageBox.Show("Token saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving token: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}