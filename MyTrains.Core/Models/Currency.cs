namespace MyTrains.Core.Models
{
    public class Currency
    {
        public int CurrencyId { get; set; }
        public string CurrencyName { get; set; }
        public string CurrencySymbol { get; set; }

        public override string ToString()
        {
            return $"{CurrencyName} ({CurrencySymbol})";
        }

    }
}
