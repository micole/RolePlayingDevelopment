using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RolePlayingCharacterDevelopment
{
    class PersonDescriptorPersonality : IPersonDescriptor
    {
        private IList<string> personality { get; set; }

        public PersonDescriptorPersonality()
        {
            personality = new List<string>() { "Forgiving", "Observant", "Overbearing",
                                               "Drunkard", "Cowardly", "Careless" };
        }

        public string GetDescription()
        {
            Random r = new Random();
            return personality[r.Next(personality.Count)];
        }
    }
}
