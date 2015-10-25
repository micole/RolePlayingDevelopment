using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace RolePlayingCharacterDevelopmentTests
{
    using RolePlayingCharacterDevelopment;
    public class PersonDescriptorFactoryTests
    {
        [Fact]
        public void PersonDescriptorFactoryReturnsDescription()
        {
            var pdf = new PersonDescriptorFactory();
            var str = pdf.GenerateDescription();
            Assert.NotEmpty(str);
        }
    }
}
