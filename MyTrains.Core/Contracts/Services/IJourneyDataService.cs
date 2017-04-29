using MyTrains.Core.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyTrains.Core.Contracts.Services
{
    public interface IJourneyDataService
    {
        Task<IEnumerable<Journey>> SearchJourney(int fromCity, int toCity, DateTime journeyDate, DateTime departureTime);

        Task<Journey> GetJourneyDetails(int journeyId);
    }
}
