using System;
using System.Data;
using System.Linq;
using DVLDDataAccessLayer;


namespace DVLDBusinessLayer
{
    public class clsCountries
    {
        public static DataTable GetAllCountries()
        {
            return clsCountriesData.GetAllCountries();
        }
    }
}
