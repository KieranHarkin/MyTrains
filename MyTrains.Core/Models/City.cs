﻿namespace MyTrains.Core.Models
{
    public class City
    {
        public int CityId { get; set; }
        public string CityName { get; set; }

        public override string ToString()
        {
            return CityName;
        }
    }
}
