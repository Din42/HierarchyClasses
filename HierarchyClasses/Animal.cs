using System;


namespace HierarchyClasses
{// абстрактный класс для животный
    abstract class Animal : IAnimal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public abstract void Sound();  
        public abstract void Info();
    }
}
