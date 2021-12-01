using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void Add()
        {
            Console.WriteLine("Kampanya eklendi.");
        }

        public void Delete()
        {
            Console.WriteLine("Kampanya silindi.");
        }

        public void Update()
        {
            Console.WriteLine("Kampanya güncellendi.");
        }
    }
}
