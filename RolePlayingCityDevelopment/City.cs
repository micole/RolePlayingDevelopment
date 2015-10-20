using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RolePlayingCityDevelopment
{
    public enum Size
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

        public City(Size citySize)
        {
            neighborhoods = new List<Neighborhood>();
            Random r = new Random();

            int numberOfNeighborhoods = 0;
            switch (citySize)
            {
                case Size.Village:
                    numberOfNeighborhoods = 1;
                    break;
                case Size.Town:
                    numberOfNeighborhoods = 3;
                    break;
                case Size.City:
                    numberOfNeighborhoods = 5;
                    break;
                case Size.Capital:
                    numberOfNeighborhoods = 7;
                    break;
            }

            for (int i = 0; i < numberOfNeighborhoods; i++)
            {
                neighborhoods.Add(new Neighborhood(Wealth.LowerClass));
            }

        }
    }

    public class Neighborhood
    {
        public string name { get; set; }
        public IList<Building> buildings { get; }
        public Wealth neighborhoodWealth { get; }

        public Neighborhood(Wealth nWealth)
        {
            buildings = new List<Building>();
            Random r = new Random();
            var numberOfBuildings = r.Next(6, 15);
            for (int i = 0; i < numberOfBuildings; i++)
            {
                
            }
        }
    }
}
