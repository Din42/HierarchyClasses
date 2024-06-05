using System;

namespace HierarchyClasses
{//интерфейс для общих характеристик 
    internal interface IAnimal
    {
        string Name { get; set; }
        int Age {  get; set; }
        void Sound();
        void Info();
    }

    internal interface IOutput
    {
        void OutputFile();
    } 
}
