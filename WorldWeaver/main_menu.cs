﻿using System;
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
    public partial class main_menu : Form
    {
        public main_menu()
        {
            InitializeComponent();
        }

        private void btn_mapUpload_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 mapUploadForm = new Form1();
            mapUploadForm.Show();
        }

        private void BtnNewGame_Click(object sender, EventArgs e)
        //note, new game is a previous iteration. The button now links to creating character types
        {
            
            RolesForm RolesForm = new RolesForm();
            RolesForm.Show();
                this.Hide();
            
        }

        private void btnLoadGame_Click(object sender, EventArgs e)
        {

            LoadGame loadGame = new LoadGame();
            loadGame.Show();
            this.Hide();
        }

        private void btn_navToken_Click(object sender, EventArgs e)
        {
            upload_token uploadTokenForm = new upload_token();
            uploadTokenForm.Show();
            this.Hide();
        }

        private void main_menu_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_createCampaign_Click(object sender, EventArgs e)
        {
            create_campaign createCampaignForm = new create_campaign();
            createCampaignForm.Show();
            this.Hide();
        }

        private void btn_navGridProto_Click(object sender, EventArgs e)
        {
            grid_prototype grid_Prototype = new grid_prototype();
            grid_Prototype.Show();
            this.Hide();
        }

        private void infoBtn_Click(object sender, EventArgs e)
        {
            
            

            CampaignPlayersForm campaignPlayers = new CampaignPlayersForm();
            campaignPlayers.Show();
            
            


        }

        

        private void btnNavOpenCampaign_Click(object sender, EventArgs e)
        {
            OpenCampaignForm openSavedCampaign = new OpenCampaignForm();
            openSavedCampaign.Show();
            this.Hide();
        }
    }
}
