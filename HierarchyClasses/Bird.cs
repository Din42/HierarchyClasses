﻿using System;

namespace HierarchyClasses
{
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
            Console.WriteLine($"Лет {Name}, имя {Age}, клюв = {Wings}, хвостов {Tail}");
        }
    }
}