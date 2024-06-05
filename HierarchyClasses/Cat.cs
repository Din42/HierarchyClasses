using System;

namespace HierarchyClasses
{
    internal class Cat : Animal
    {
        public int Ears { get; set; }
        public int Paws { get; set; }
        public int Tail { get; set; }

        public override void Sound()
        {
            Console.WriteLine("Мяу");
        }
    }
}
