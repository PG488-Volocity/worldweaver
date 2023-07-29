using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorldWeaver.Models; 


namespace WorldWeaver
{
    public partial class OpenCampaignForm : Form
    {
        private CampaignManager campaignManager;

        public OpenCampaignForm()
        {
            InitializeComponent();

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
    }
}
