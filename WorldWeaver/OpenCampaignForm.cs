using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorldWeaver;
using WorldWeaver.Models; 


namespace WorldWeaver
{
    public partial class OpenCampaignForm : Form
    {
        private CampaignManager campaignManager;

        public OpenCampaignForm()
        {
            InitializeComponent();

            picboxMap.SizeMode = PictureBoxSizeMode.Zoom;
            // Replace "PictureBoxSizeMode.Zoom" with "PictureBoxSizeMode.AutoSize"
            picboxPlayer1.SizeMode = PictureBoxSizeMode.AutoSize;
            picboxPlayer2.SizeMode = PictureBoxSizeMode.AutoSize;
            picboxPlayer3.SizeMode = PictureBoxSizeMode.AutoSize;
            picboxPlayer4.SizeMode = PictureBoxSizeMode.AutoSize;
            picboxPlayer5.SizeMode = PictureBoxSizeMode.AutoSize;
            picboxPlayer6.SizeMode = PictureBoxSizeMode.AutoSize;


            campaignManager = new CampaignManager();
            LoadCampaignNames();
        }

        private void LoadCampaignNames()
        {
            try
            {
                List<Campaign> campaigns = campaignManager.GetAllCampaigns();

                cmbCampaigns.DisplayMember = "CampaignName";
                cmbCampaigns.ValueMember = "CampaignId";
                cmbCampaigns.DataSource = campaigns;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading campaigns: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            // Check if an item is selected in the cmbCampaigns ComboBox
            if (cmbCampaigns.SelectedItem is Campaign selectedCampaign)
            {
                try
                {
                    // Step 1: Use the selected campaign's map name to fetch the map file path
                    string mapName = selectedCampaign.CampaignMap;
                    string mapImagePath = campaignManager.GetMapImagePath(mapName);

                    // Step 2: Load and display the map image in the PictureBox
                    if (!string.IsNullOrEmpty(mapImagePath))
                    {
                        picboxMap.Image = Image.FromFile(mapImagePath);
                    }
                    else
                    {
                        picboxMap.Image = null;
                        MessageBox.Show("Map image not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    // Step 3: Load the player tokens for the selected campaign and display them in the PictureBoxes
                    List<Player> players = campaignManager.GetPlayersForCampaign(selectedCampaign.CampaignId);
                    LoadPlayerTokens(players);
                }
                catch (Exception ex)
                {
                    // Handle any exceptions if necessary
                    MessageBox.Show("An error occurred while loading the map image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // If no campaign is selected, display a message
                MessageBox.Show("Please select a campaign to open.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LoadPlayerTokens(List<Player> players)
        {
            // Clear existing player tokens in the PictureBoxes
            ClearPlayerTokens();

            // Fetch and display the player tokens in the PictureBoxes
            for (int i = 0; i < players.Count; i++)
            {
                PictureBox pictureBox = GetPictureBoxForPlayer(i + 1);
                if (pictureBox != null)
                {
                    int tokenId = players[i].TokenId;
                    string tokenImagePath = campaignManager.GetTokenImagePath(tokenId);

                    // Set the token information as the tooltip of the PictureBox
                    pictureBox.Tag = $"Token ID: {tokenId}\nImage Path: {tokenImagePath}";

                    if (!string.IsNullOrEmpty(tokenImagePath))
                    {
                        // Load the token image from file
                        Image tokenImage = Image.FromFile(tokenImagePath);

                        // Resize the image to fit within the PictureBox while maintaining aspect ratio
                        pictureBox.Image = ResizeImage(tokenImage, 35, 35);
                    }
                    else
                    {
                        pictureBox.Image = null;
                    }
                }
            }
        }

        // Helper method to resize an image while maintaining aspect ratio
        private Image ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }




        private void ClearPlayerTokens()
        {
            picboxPlayer1.Image = null;
            picboxPlayer2.Image = null;
            picboxPlayer3.Image = null;
            picboxPlayer4.Image = null;
            picboxPlayer5.Image = null;
            picboxPlayer6.Image = null;
        }
        private PictureBox GetPictureBoxForPlayer(int playerIndex)
        {
            string pictureBoxName = $"picboxPlayer{playerIndex}";
            var pictureBox = Controls.Find(pictureBoxName, true).FirstOrDefault() as PictureBox;
            return pictureBox;
        }

    }
}
