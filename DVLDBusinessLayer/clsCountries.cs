using DVLDDataAccessLayer;
using System;
using System.Data;
using System.Linq;
using static DVLDBusinessLayer.clsPeople;


namespace DVLDBusinessLayer
{
    public class clsCountries
    {
        public int CountryID { set; get; }
        public string CountryName { set; get; }

        private clsCountries(int CountryID, string CountryName)
        {
            this.CountryID = CountryID;
            this.CountryName = CountryName;
        }

        public static DataTable GetAllCountries()
        {
            return clsCountriesData.GetAllCountries();
        }

        public static clsCountries Find(int CountryID)
        {
            string CountryName = "";

            if (clsCountriesData.GetCountryInfoByID(CountryID, ref CountryName))

                return new clsCountries(CountryID, CountryName);
            else
                return null;
        }

        public static clsCountries Find(string CountryName)
        {
            int CountryID = -1;

            if (clsCountriesData.GetCountryInfoByName(CountryName, ref CountryID))

                return new clsCountries(CountryID, CountryName);
            else
                return null;
        }
    }
}
