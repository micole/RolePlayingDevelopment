using System;
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

        public void RandomFamily()
        {
            //TODO: Random family name generator
            string familyName = "Smith";
            dad = new Person();
            dad.familyName = familyName;

            mom = new Person();
            mom.familyName = familyName;

            for(int i = 0; i <= randomWeightedNumberOfChildren(); i++)
            {
                Person c = new Person();
                c.familyName = familyName;
                AddChild(c);
            }
        }

        public void AddChild(Person c)
        {
            children.Add(c);
        }

        public override string ToString()
        {
            string r = "";
            r = dad.firstName + " & " + mom.firstName + " " + mom.familyName;
            if (children.Count > 0)
            {
                r = r + ", Children:";
                foreach(Person c in children)
                {
                    r = r + " " + c.firstName + ",";
                }
                r = r.TrimEnd(',');
            }
            return r;
        }

        private int randomWeightedNumberOfChildren()
        {
            Random r = new Random();
            Double d = r.NextDouble();
            if(d < 0.15)
            {
                return 0;
            }
            else if(d < 0.35)
            {
                return 1;
            }
            else if(d < 0.60)
            {
                return 2;
            }
            else if(d < 0.75)
            {
                return 3;
            }
            else if(d < 0.90)
            {
                return 4;
            }
            else if(d < 0.95)
            {
                return 5;
            }
            else
            {
                return 6;
            }
        }
    }
}

