using System;

namespace HierarchyClasses
{ // класс для птиц
    internal class Bird : Animal
    {
        public int Wings { get; set; }
        public int Tail { get; set; }

        public override void Sound()
        {
            Console.WriteLine("Чирикает");
        }
        public override void Info()
        {
            Console.WriteLine($"Имя {Name}, лет {Age}, клюв {Wings}, хвостов {Tail}");
        }
        protected override string GetInfo()
        {
            return $"Имя: {Name}\nВозраст: {Age}\nКлюв: {Wings}\nХвост: {Tail}";
        }
    }
}
