using MyTrains.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyTrains.Core.Contracts.Repository
{
    public interface ICityRepository
    {
        Task<List<City>> GetAllCities();

        Task<City> GetCityById(int cityId);
    }
}
