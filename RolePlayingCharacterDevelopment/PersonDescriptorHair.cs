using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RolePlayingCharacterDevelopment
{

    class PersonDescriptorHair : IPersonDescriptor
    {
        private IList<string> hairColor { get; set; }
        private IList<string> hairLength { get; set; }
        private IList<string> hairAdjective { get; set; }

        public PersonDescriptorHair()
        {
            hairColor = new List<string>() { "brown", "black" };
            hairLength = new List<string>() { "", "short", "long" };
            hairAdjective = new List<string>() { "", "frizzy", "curly", "straight" };
            
        }

        public string GetDescription()
        {
            Random r = new Random();
            string hair = hairLength[r.Next(hairLength.Count)];
            hair += " " + hairAdjective[r.Next(hairAdjective.Count)];
            hair += " " + hairColor[r.Next(hairColor.Count)];
            hair += " hair";
            return hair.Trim();
        }
    }
}
