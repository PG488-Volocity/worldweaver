using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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
        private bool isDragging = false;
        private Point firstPoint = Point.Empty;
        private Control activeControl;
        string connectionString = ConfigurationManager.ConnectionStrings["MyDatabaseConnectionString"].ConnectionString;

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

            // player movement 
            picboxPlayer1.MouseDown += new MouseEventHandler(PictureBox_MouseDown);
            picboxPlayer1.MouseMove += new MouseEventHandler(PictureBox_MouseMove);
            picboxPlayer1.MouseUp += new MouseEventHandler(PictureBox_MouseUp);

            picboxPlayer2.MouseDown += new MouseEventHandler(PictureBox_MouseDown);
            picboxPlayer2.MouseMove += new MouseEventHandler(PictureBox_MouseMove);
            picboxPlayer2.MouseUp += new MouseEventHandler(PictureBox_MouseUp);

            picboxPlayer3.MouseDown += new MouseEventHandler(PictureBox_MouseDown);
            picboxPlayer3.MouseMove += new MouseEventHandler(PictureBox_MouseMove);
            picboxPlayer3.MouseUp += new MouseEventHandler(PictureBox_MouseUp);

            picboxPlayer4.MouseDown += new MouseEventHandler(PictureBox_MouseDown);
            picboxPlayer4.MouseMove += new MouseEventHandler(PictureBox_MouseMove);
            picboxPlayer4.MouseUp += new MouseEventHandler(PictureBox_MouseUp);

            picboxPlayer5.MouseDown += new MouseEventHandler(PictureBox_MouseDown);
            picboxPlayer5.MouseMove += new MouseEventHandler(PictureBox_MouseMove);
            picboxPlayer5.MouseUp += new MouseEventHandler(PictureBox_MouseUp);

            picboxPlayer6.MouseDown += new MouseEventHandler(PictureBox_MouseDown);
            picboxPlayer6.MouseMove += new MouseEventHandler(PictureBox_MouseMove);
            picboxPlayer6.MouseUp += new MouseEventHandler(PictureBox_MouseUp);
            //...npc movement 

            picbox_NPC1.MouseDown += new MouseEventHandler(PictureBox_MouseDown);
            picbox_NPC1.MouseMove += new MouseEventHandler(PictureBox_MouseMove);
            picbox_NPC1.MouseUp += new MouseEventHandler(PictureBox_MouseUp);

            picbox_NPC2.MouseDown += new MouseEventHandler(PictureBox_MouseDown);
            picbox_NPC2.MouseMove += new MouseEventHandler(PictureBox_MouseMove);
            picbox_NPC2.MouseUp += new MouseEventHandler(PictureBox_MouseUp);

            picbox_NPC3.MouseDown += new MouseEventHandler(PictureBox_MouseDown);
            picbox_NPC3.MouseMove += new MouseEventHandler(PictureBox_MouseMove);
            picbox_NPC3.MouseUp += new MouseEventHandler(PictureBox_MouseUp);

            picbox_NPC4.MouseDown += new MouseEventHandler(PictureBox_MouseDown);
            picbox_NPC4.MouseMove += new MouseEventHandler(PictureBox_MouseMove);
            picbox_NPC4.MouseUp += new MouseEventHandler(PictureBox_MouseUp);

            picbox_NPC5.MouseDown += new MouseEventHandler(PictureBox_MouseDown);
            picbox_NPC5.MouseMove += new MouseEventHandler(PictureBox_MouseMove);
            picbox_NPC5.MouseUp += new MouseEventHandler(PictureBox_MouseUp);

            picbox_NPC6.MouseDown += new MouseEventHandler(PictureBox_MouseDown);
            picbox_NPC6.MouseMove += new MouseEventHandler(PictureBox_MouseMove);
            picbox_NPC6.MouseUp += new MouseEventHandler(PictureBox_MouseUp);

            picbox_NPC7.MouseDown += new MouseEventHandler(PictureBox_MouseDown);
            picbox_NPC7.MouseMove += new MouseEventHandler(PictureBox_MouseMove);
            picbox_NPC7.MouseUp += new MouseEventHandler(PictureBox_MouseUp);

            picbox_NPC8.MouseDown += new MouseEventHandler(PictureBox_MouseDown);
            picbox_NPC8.MouseMove += new MouseEventHandler(PictureBox_MouseMove);
            picbox_NPC8.MouseUp += new MouseEventHandler(PictureBox_MouseUp);

            picbox_NPC9.MouseDown += new MouseEventHandler(PictureBox_MouseDown);
            picbox_NPC9.MouseMove += new MouseEventHandler(PictureBox_MouseMove);
            picbox_NPC9.MouseUp += new MouseEventHandler(PictureBox_MouseUp);

            picbox_NPC10.MouseDown += new MouseEventHandler(PictureBox_MouseDown);
            picbox_NPC10.MouseMove += new MouseEventHandler(PictureBox_MouseMove);
            picbox_NPC10.MouseUp += new MouseEventHandler(PictureBox_MouseUp);

            picbox_NPC11.MouseDown += new MouseEventHandler(PictureBox_MouseDown);
            picbox_NPC11.MouseMove += new MouseEventHandler(PictureBox_MouseMove);
            picbox_NPC11.MouseUp += new MouseEventHandler(PictureBox_MouseUp);

            picbox_NPC12.MouseDown += new MouseEventHandler(PictureBox_MouseDown);
            picbox_NPC12.MouseMove += new MouseEventHandler(PictureBox_MouseMove);
            picbox_NPC12.MouseUp += new MouseEventHandler(PictureBox_MouseUp);
            //... Repeat this for each NPC PictureBox

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

        private void PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            activeControl = sender as Control;
            isDragging = true;  // proves dragging
            var control = sender as Control;
            firstPoint = control.PointToClient(Control.MousePosition);
        }

        private void PictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                var control = sender as Control;
                Point temp = control.PointToClient(Control.MousePosition);
                Point res = new Point(temp.X - firstPoint.X, temp.Y - firstPoint.Y);
                control.Left += res.X;
                control.Top += res.Y;
            }
        }

        private void PictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;  // disproves dragging
            activeControl = null;
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

                    // Step 4: Load the NPC tokens and display them in the PictureBoxes
                    List<NPC> npcs = campaignManager.GetFirst12NPCs();
                    LoadNPCTokens(npcs);
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

        private void LoadNPCTokens(List<NPC> npcs)
        {
            // Clear existing NPC tokens in the PictureBoxes
            ClearNPCTokens();

            // Fetch and display the NPC tokens in the PictureBoxes
            for (int i = 0; i < npcs.Count; i++)
            {
                PictureBox pictureBox = GetPictureBoxForNPC(i + 1);
                if (pictureBox != null)
                {
                    int tokenId = npcs[i].TokenId;
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

        private void ClearNPCTokens()
        {
            picbox_NPC1.Image = null;
            picbox_NPC2.Image = null;
            picbox_NPC3.Image = null;
            picbox_NPC4.Image = null;
            picbox_NPC5.Image = null;
            picbox_NPC6.Image = null;
            picbox_NPC7.Image = null;
            picbox_NPC8.Image = null;
            picbox_NPC9.Image = null;
            picbox_NPC10.Image = null;
            picbox_NPC11.Image = null;
            picbox_NPC12.Image = null;
        }

        private PictureBox GetPictureBoxForNPC(int npcIndex)
        {
            string pictureBoxName = $"picbox_NPC{npcIndex}";
            var pictureBox = Controls.Find(pictureBoxName, true).FirstOrDefault() as PictureBox;
            return pictureBox;
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

        private void OpenCampaignForm_Load(object sender, EventArgs e)
        {

        }
    }
}
