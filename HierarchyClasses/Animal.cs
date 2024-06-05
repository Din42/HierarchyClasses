using System;
using System.IO;


namespace HierarchyClasses
{// абстрактный класс для животный
    abstract class Animal : IAnimal, IOutput
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public abstract void Sound();  
        public abstract void Info();

        //метод для получения информации о жифотном
        protected abstract string GetInfo();

        public void OutputFile()
        {
            string fileName = $"{Name} info.txt";
            string info = GetInfo();

            try
            {
                File.WriteAllText(fileName, info);
                Console.WriteLine($"Информация записана в фаил {fileName}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка записи.");
            }
        }
    }
}
