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

        public string FamilyName()
        {
            return dad.familyName;
        }

        public void RandomFamily()
        {
            //TODO: Random family name generator
            string familyName = "Smith";
            dad = new Person();

            mom = new Person();

            for(int i = 0; i <= randomWeightedNumberOfChildren(); i++)
            {
                Person c = new Person();
                AddChild(c);
            }
            SetFamilyName(familyName);
        }

        public void SetFamilyName(string familyName)
        {
            dad.familyName = familyName;
            mom.familyName = familyName;
            foreach (Person c in children)
            {
                c.familyName = familyName;
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

