using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWorkOne
{
    class MailAddress
    {
        string organisationName;
        string countryName;
        string cityName;
        string streetName;
        int houseNumber;
        int mailIndex;

        public string OrganisationName
        {
            get
            {
                return organisationName;
            }
            set
            {
                if (value == null || value.Length == 0)
                    throw new Exception("Неподходящее название компании");
                else
                    organisationName = value;
            }
        }
        public string CountryName
        {
            get
            {
                return countryName;
            }
            set
            {
                if (value == null || value.Length == 0)
                    throw new Exception("Неподходящее название страны");
                else
                    countryName = value;
            }
        }
        public string CityName
        {
            get
            {
                return cityName;
            }
            set
            {
                if (value == null || value.Length == 0)
                    throw new Exception("Неподходящее название города");
                else
                    cityName = value;
            }
        }
        public string StreetName
        {
            get
            {
                return streetName;
            }
            set
            {
                if (value == null || value.Length == 0)
                    throw new Exception("Неподходящее название улицы");
                else
                    streetName = value;
            }
        }

        public string HouseNumber
        {
            get
            {
                return houseNumber;
            }
            set
            {
                if (value = 0)
                    throw new Exception("Неподходящее значение ");
                else
                    houseNumber = value;
            }
        }

        public string Index
        {
            get
            {
                return mailIndex;
            }
            set
            {
                if (value <= 0 )
                    throw new Exception("Неподходящее значение");
                else
                    mailIndex = value;
            }
        }

    }
}
