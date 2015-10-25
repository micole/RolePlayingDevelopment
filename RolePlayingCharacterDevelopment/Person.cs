
using System;
using System.IO;

namespace RolePlayingCharacterDevelopment
{

    public enum Gender
    {
        Unknown,
        Male,
        Female,
        Other
    }

    public class Person
    {
        public string firstName { get; set; }
        public string familyName { get; set; }
        public string description { get; set; }
        //public Profession profession { get; set; }
        public Job job { get; set; }
        public Race race { get; set; }
        public ClassType classType { get; set; }
        public Gender gender { get; set; }


        public Person()
        {
            //TODO: Fix to actually use real names. For now this random string is fine
            firstName = Path.GetRandomFileName().Replace(".","");
            familyName = Path.GetRandomFileName().Replace(".","");

            //TODO: Create description based off data like: X and Y
            //Examples: Drowsy and Fanatic
            // Jumpy and Fat
            // Tall and Particularly Long Hair
            //More examples here: http://www.mathemagician.net/town.html

            //TODO: Based on the class, they can have specific jobs

            job = new Job();
            race = Race.Unknown;
            classType = ClassType.Unknown;
        }

        public Person(Gender g)
        {
            //TODO: when names implemented, make the name appropriate
        }

        public Person(Person dad, Person mom)
        {
            firstName = Path.GetRandomFileName().Replace(".", "");
            familyName = dad.familyName;
            
        }

        private Race calculateRace(Race d, Race m)
        {
            if((d == Race.Human && m == Race.Elf) || (m == Race.Human && d == Race.Elf))
            {
                return Race.Halfelf;
            }
            //TODO: figure out other matchups
            //For now return father race
            return d;
            
        }

        

    }
}
