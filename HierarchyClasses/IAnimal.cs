using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HierarchyClasses
{//интерфейс для общих характеристик 
    internal interface IAnimal
    {
        string Name { get; set; }
        int Age {  get; set; }
        void Sound();
        void Info();
    }
}
