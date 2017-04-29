using MyTrains.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyTrains.Core.Contracts.Repository
{
    public interface ISavedJourneyRepository
    {
        Task<IEnumerable<SavedJourney>> GetSavedJourneyForUser(int userId);

        Task AddSavedJourney(int userId, int journeyId, int numberOfTravellers);
    }
}
