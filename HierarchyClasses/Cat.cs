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
            Console.WriteLine("Мяукает");
        }
        public override void Info()
        {
            Console.WriteLine($"Имя {Name}, лет {Age}, ушей {Ears}, лап {Paws}, хвостов {Tail}");
        }
    }
}
