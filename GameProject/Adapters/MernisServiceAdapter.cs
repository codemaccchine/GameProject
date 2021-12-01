using GameProject.Abstract;
using GameProject.Entites;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Adapters
{
    internal class MernisServiceAdapter : IUserCheckService
    {
        public bool CheckIfCitizen(User user)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(Convert.ToInt64(user.NationalityId), user.FirstName, user.LastName, user.DateOfBirth.Year).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
