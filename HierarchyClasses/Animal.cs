using System;

namespace HierarchyClasses
{
    public abstract class  Animal : IAnimal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public abstract void Sound();        
    }
}
