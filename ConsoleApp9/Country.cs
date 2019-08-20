using System.Collections.Generic;

namespace ConsoleApp9
{
    public class Country
    {
        private string _name;
        private List<Country> _countries;
        public Player Owner { get; set; }
        public int SoldierCount { get; set; }

        public Country(string name)
        {
            _countries = new List<Country>();
            _name = name;
        }

        public void AddBorderingLocation(Country country)
        {
            this._countries.Add(country);
            country._countries.Add(this);
        }
    }
}
