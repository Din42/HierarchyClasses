using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HierarchyClasses
{
    internal class Animal : IAnimal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public abstract void Sound();        
    }
}
