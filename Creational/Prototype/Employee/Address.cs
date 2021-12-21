using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Creational.Prototype.Employee
{
    class Address
    {
        private float Longitude ;
        private float Latitude ;
        private string StreetName ;
        private string City ;
        private string Country ;
        private int BuildingNumber ;
        private int ZipCode ;

        public Address(float longitude, float latitude, string streetName, string city, string country, int buildingNumber, int zipCode)
        {
            Longitude = longitude;
            Latitude = latitude;
            StreetName = streetName;
            City = city;
            Country = country;
            BuildingNumber = buildingNumber;
            ZipCode = zipCode;
        }
        public float SetLongitude(float longitude) => Longitude = longitude;
        public float GetLongitude() => Longitude;
        public float SetLatitude(float latitude) => Latitude = latitude;
        public float GetLatitude() => Latitude;
        public string SetStreetName(string streetName) => StreetName = streetName;
        public string GetStreetName() => StreetName;
        public string SetCity(string city) => City = city;
        public string GetCity() => City;
        public string SetCountry(string country) => Country = country;
        public string GetCountry() => Country;
        public int SetBuildingNumber(int buildingNumber) => BuildingNumber = buildingNumber;
        public int GetBuildingNumber() => BuildingNumber;
        public int SetZipCode(int zipCode) => ZipCode = zipCode;
        public int GetZipCode() => ZipCode;

    }
}
