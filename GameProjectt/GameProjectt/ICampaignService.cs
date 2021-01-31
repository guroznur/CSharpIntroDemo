using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectt
{
    interface ICampaignService
    {
        void BuyWithCampaign(Gamer gamer, Game game,Campaign campaign);
    }
}
