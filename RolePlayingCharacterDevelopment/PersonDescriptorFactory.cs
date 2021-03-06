﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RolePlayingCharacterDevelopment
{
    public class PersonDescriptorFactory
    {
        private static IEnumerable<IPersonDescriptor> descriptors { get; set; }

        public PersonDescriptorFactory()
        {
            descriptors = from t in Assembly.GetExecutingAssembly().GetTypes()
                            where t.GetInterfaces().Contains(typeof(IPersonDescriptor))
                                    && t.GetConstructor(Type.EmptyTypes) != null
                            select Activator.CreateInstance(t) as IPersonDescriptor;

        }

        public string GenerateDescription()
        {
            Random r = new Random();

            var desc1 = (IPersonDescriptor)descriptors.ElementAt(r.Next(descriptors.Count()));
            var desc2 = (IPersonDescriptor)descriptors.ElementAt(r.Next(descriptors.Count()));
            while (desc1.GetType().Equals(desc2.GetType()))
            {
                desc2 = (IPersonDescriptor)descriptors.ElementAt(r.Next(descriptors.Count()));
            }
            return desc1.GetDescription() + " and " + desc2.GetDescription();
        }
    }
}
