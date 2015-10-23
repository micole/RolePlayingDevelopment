using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RolePlayingCityDevelopment
{
    public enum CitySize
    {
        Village,
        Town,
        City,
        Capital
    }

    public enum Wealth
    {
        Poor,
        LowerClass,
        MiddleClass,
        UpperClass,
        Royal
    }

    public class City
    {
        public string description { get; set; }
        public IList<Neighborhood> neighborhoods { get; set; }
        public Wealth cityWealth { get; set; }

        public City(CitySize citySize)
        {
            neighborhoods = new List<Neighborhood>();
            Random r = new Random();

            int numberOfNeighborhoods = 0;
            switch (citySize)
            {
                case CitySize.Village:
                    numberOfNeighborhoods = 1;
                    break;
                case CitySize.Town:
                    numberOfNeighborhoods = 3;
                    break;
                case CitySize.City:
                    numberOfNeighborhoods = 5;
                    break;
                case CitySize.Capital:
                    numberOfNeighborhoods = 7;
                    break;
            }

            for (int i = 0; i < numberOfNeighborhoods; i++)
            {
                neighborhoods.Add(new Neighborhood(Wealth.LowerClass));
            }

        }
    }

    
}
