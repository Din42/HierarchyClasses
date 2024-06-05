using System;


namespace HierarchyClasses
{
    abstract class Animal : IAnimal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public abstract void Sound();        
    }
}
