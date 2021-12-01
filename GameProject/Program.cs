// See https://aka.ms/new-console-template for more information

using GameProject.Adapters;
using GameProject.Concrete;
using GameProject.Entites;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GameProject // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            UserManager userManager = new UserManager(new MernisServiceAdapter());
            UserManager userManager2 = new UserManager(new UserCheckManager());

            User user1 = new User
            {
                Id = 1,
                FirstName = "Cahit",
                LastName = "Arslan",
                NationalityId = "34125567856",
                DateOfBirth = new DateTime(1993, 3, 1)
            };

            userManager.Add(user1);
            userManager2.Add(user1);

            userManager.Update();
            userManager.Delete();



            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add();
            campaignManager.Update();
            campaignManager.Delete();



            SalesManager salesManager = new SalesManager();
            salesManager.Add(new User { Id = 2, FirstName = "Ahmet", LastName = "Kara", DateOfBirth = new DateTime(1997, 2, 15), NationalityId = "12354322154" }, new Campaign { Id = 1, CampaignName = "1 alana 1 bedava", CampaignPrice = 150 });

            salesManager.Update(new Sales { Id = 1, CampaignId = 1, UserId = 2, SalePrice = 156, SellBy = DateTime.Now }, new Campaign { Id = 2, CampaignName = "3 ü bir arada", CampaignPrice = 230 });

            salesManager.Delete(new Sales { Id = 2, UserId = 1, CampaignId = 2, SalePrice = 230, SellBy = DateTime.Now });


            Console.ReadLine();
        }
    }
}
