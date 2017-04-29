using MyTrains.Core.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyTrains.Core.Contracts.Repository
{
    public interface IJourneyRepository
    {
        Task<IEnumerable<Journey>> SearchJourney(int fromCity, int toCity, DateTime journeyDate, DateTime departureDate);

        Task<Journey> GetJourneyDetails(int jounreyId);
    }
}
