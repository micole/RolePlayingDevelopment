using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RolePlayingCityDevelopment
{
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
                buildings.Add(new Building());
            }
        }
    }
}
