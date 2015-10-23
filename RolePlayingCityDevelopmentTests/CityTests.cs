using Xunit;

namespace RolePlayingCityDevelopment.Tests
{
    using RolePlayingCityDevelopment;
    public class CityTests
    {
        [Fact]
        public void CityIsNotNull()
        {
            var city = new City(CitySize.City);
            Assert.NotNull(city);
        }
    }
}