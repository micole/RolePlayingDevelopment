using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace RolePlayingCharacterDevelopmentTests
{
    using RolePlayingCharacterDevelopment;
    public class FamilyTests
    {
        [Fact]
        public void FamilyIsNotNull()
        {
            var family = new Family();
            family.dad = new Person();
            family.mom = new Person();
            family.AddChild(new Person());
            Assert.NotNull(family);
        }

        [Fact]
        public void RandomFamilyHasSameLastName()
        {
            var family = new Family();
            family.RandomFamily();

            string familyName = family.dad.familyName;
            Assert.Equal(familyName, family.mom.familyName);
            foreach(Person c in family.children)
            {
                Assert.Equal(familyName, c.familyName);
            }
        }
    }
}
