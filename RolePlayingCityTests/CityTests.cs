using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace RolePlayingCityTests
{
    using RolePlayingCityDevelopment;
    public class CityTests
    {
        [Fact]
        public void CityIsNotNull()
        {
            var city = new City(Size.City);
            Assert.NotNull(city);
        }
    }
}
