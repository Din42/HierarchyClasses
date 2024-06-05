using System;

namespace HierarchyClasses
{ //класс для кошек
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
        protected override string GetInfo()
        {
            return $"Имя: {Name}\nВозраст: {Age}\nУшей: {Ears}\nЛап: {Paws}\nХвостов: {Tail}";
        }
    }
}
