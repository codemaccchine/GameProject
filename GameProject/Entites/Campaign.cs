using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Entites
{
    public class Campaign : IEntity
    {
        public int Id { get; set; }
        public string CampaignName { get; set; }
        public double CampaignPrice { get; set; }
    }
}
