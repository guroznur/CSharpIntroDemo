using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectt
{
    class CampaignManager : ICampaignService
    {
        public void BuyWithCampaign(Gamer gamer, Game game, Campaign campaign)
        {
            Console.WriteLine(gamer.FirstName + " " + "isimli oyuncu" + " "+ game.GameName  + " " +
                "oyununu" + " " +  campaign.CampaignName +" "+ "kampanyasıyla satın aldı.");
        }
    }
}
