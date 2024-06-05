using System;

namespace HierarchyClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat {Name = "Мурсик", Age = 2, Ears = 2, Paws = 4, Tail = 1 };
            Bird bird = new Bird { Name = "Чижик", Age = 1, Tail = 2, Wings = 1 };

            cat.Sound();
            bird.Sound();
        }
    }
}
