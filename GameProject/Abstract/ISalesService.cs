using GameProject.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Abstract
{
    public interface ISalesService
    {
        void Add(User user, Campaign campaign);
        void Delete(Sales sales);
        void Update(Sales sales, Campaign campaign);
    }
}
