using System;

namespace HierarchyClasses
{
    internal class Cat : Animal
    {
        public int Eats { get; set; }
        public int Pows { get; set; }
        public int Tail {  get; set; }

        public override void Sound()
        {
            Console.WriteLine("Мяу");
        }
    }
}
