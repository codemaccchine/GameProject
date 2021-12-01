using GameProject.Abstract;
using GameProject.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class UserManager : IUserService
    {
        IUserCheckService _userCheckService;
        public UserManager(IUserCheckService userCheckService)
        {
            _userCheckService = userCheckService;
        }
        public void Add(User user)
        {
            if (_userCheckService.CheckIfCitizen(user))
            {
                Console.WriteLine($"{user.FirstName} isimli kullanıcı eklendi."); 
            }
            else
            {
                Console.WriteLine("Kullanıcı doğrulanamadı. Ekleme işlemi başarısız.");
            }
        }

        public void Delete()
        {
            Console.WriteLine("Kullanıcı silindi."); ;
        }

        public void Update()
        {
            Console.WriteLine("Kullanıcı güncellendi."); ;
        }
    }
}
