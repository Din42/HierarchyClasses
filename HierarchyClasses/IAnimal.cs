using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HierarchyClasses
{
    internal interface IAnimal
    {
        string Name { get; set; }
        int Age {  get; set; }
        void Sound();
        void Info();
    }
}
