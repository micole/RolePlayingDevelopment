using System.Collections;
using System.Collections.Generic;

namespace RolePlayingCharacterDevelopment
{
    public class Family
    {
        public Person dad { get; set; }
        public Person mom { get; set; }
        public IList<Person> children { get; }

        public Family()
        {
            children = new List<Person>();

        }

        public void AddChild(Person c)
        {
            children.Add(c);
        }
    }
}

