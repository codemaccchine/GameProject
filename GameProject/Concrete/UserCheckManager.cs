using GameProject.Abstract;
using GameProject.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class UserCheckManager : IUserCheckService
    {
        public bool CheckIfCitizen(User user)
        {
            return true;
        }
    }
}
