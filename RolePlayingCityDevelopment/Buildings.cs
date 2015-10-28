using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RolePlayingCityDevelopment
{
    public enum BuildingType
    {
        Other,
        Shop,
        Religious,
        Government,
        Guild,
        House,
        Resturant,
        Inn
    }


    public class Building
    {
        public string name { get; set; }
        public BuildingType buildingType { get; set; }
        public string description { get; }

        public Building()
        {
            Random r = new Random();
            name = "Random " + r.Next().ToString();
        }
    }

}
