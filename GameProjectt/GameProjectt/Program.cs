using System;

namespace GameProjectt
{
    class Program
    {
        static void Main(string[] args)
        {


            //gamermanager gamermanager = new gamermanager(new uservalidationmanager());
            //gamermanager.add(new gamer { ıd = 1, birthyear = 1985, firstname = "öznur",
            //    lastname = "gür",ıdentitynumber = 12345   });

            Gamer gamer = new Gamer { Id = 1,BirthYear = 1985 , FirstName = "Öznur",LastName = "Gür",IdentityNumber = 12345};
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(gamer);
               

            Game game = new Game { GameName = "GTA", GameCost = 50, GameRating = 8 };
            GameManager gameManager = new GameManager();
            gameManager.Add(game);

            GameOwnerManager gameOwnerManager = new GameOwnerManager();
            gameOwnerManager.OwnGame(game,gamer);

            Campaign campaign = new Campaign { CampaignName = "BUY MORE" };
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.BuyWithCampaign(gamer,game,campaign);
        }
    }
}
