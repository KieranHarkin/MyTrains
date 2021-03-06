﻿
using System.Collections.Generic;
using System.Threading.Tasks;
using MyTrains.Core.Models;

namespace MyTrains.Core.Contracts.Services
{
    public interface ICityDataService
    {
        Task<List<City>> GetAllCities();

        Task<City> GetCityById(int cityId);
    }
}