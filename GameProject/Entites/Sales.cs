using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Entites
{
    public class Sales : IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int CampaignId { get; set; }
        public DateTime SellBy { get; set; }
        public double SalePrice { get; set; }
    }
}
