using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldWeaver.Models
{
    public class Campaign
    {
        public int CampaignId { get; set; }
        public string CampaignName { get; set; }
        public string CampaignMap { get; set; }
        public int CampaignPlayerCount { get; set; }

        
        public List<Player> Players { get; set; }

       
    }
}
