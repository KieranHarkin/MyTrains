using MyTrains.Core.Models;
using System.Collections.Generic;

namespace MyTrains.Core.Contracts.Repository
{
    public interface ISettingsRepository
    {
        List<Currency> GetAvailableCurrencies();
        Currency GetCurrencyById(int currencyId);
        string GetAboutContent();
    }
}
