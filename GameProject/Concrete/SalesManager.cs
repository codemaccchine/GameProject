using GameProject.Abstract;
using GameProject.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class SalesManager : ISalesService
    {
        public void Add(User user, Campaign campaign)
        {
            Console.WriteLine($"{user.FirstName} isimli müşteri, {campaign.CampaignName} isimli kampanya üzerinden satın alma işlemi yaptı.");
        }

        public void Delete(Sales sales)
        {
            Console.WriteLine($"{sales.Id} numaralı satış bilgisi silindi.");
        }

        public void Update(Sales sales, Campaign campaign)
        {
            Console.WriteLine($"{sales.Id} numaralı satış bilgisinin kampanya ismi {campaign.CampaignName} olarak güncellendi.");
        }
    }
}
