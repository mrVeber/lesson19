using System;
using System.Collections.Generic;
using System.Linq;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Computers> listComputers = new List<Computers>()
            {
                new Computers(){Id = 1, BrandComputers = "ACER", TypeProcessor = "Intel", CPU = 3.5, RAM = 2, SSD = 256, VideoCardValue = 6, Price = 150, Number = 25},
                new Computers(){Id = 2, BrandComputers = "APPLE", TypeProcessor = "AMD", CPU = 2.8, RAM = 4, SSD = 512, VideoCardValue = 4, Price = 300, Number = 15},
                new Computers(){Id = 3, BrandComputers = "ASUS", TypeProcessor = "Intel", CPU = 3.2, RAM = 4, SSD = 256, VideoCardValue = 8, Price = 250, Number = 13},
                new Computers(){Id = 4, BrandComputers = "INTEL", TypeProcessor = "AMD", CPU = 2.7, RAM = 4, SSD = 128, VideoCardValue = 16, Price = 350, Number = 30},
                new Computers(){Id = 5, BrandComputers = "LENOVO", TypeProcessor = "AMD", CPU = 2.2, RAM = 4, SSD = 256, VideoCardValue = 8, Price = 450, Number = 35},
                new Computers(){Id = 6, BrandComputers = "DELL", TypeProcessor = "Intel", CPU = 2.4, RAM = 6, SSD = 512, VideoCardValue = 4, Price = 550, Number = 5},
                new Computers(){Id = 7, BrandComputers = "ALIENWARE", TypeProcessor = "AMD", CPU = 2.2, RAM = 8, SSD = 1024, VideoCardValue = 6, Price = 350, Number = 20},
                new Computers(){Id = 8, BrandComputers = "HP", TypeProcessor = "Intel", CPU = 3.2, RAM = 12, SSD = 1024, VideoCardValue = 8, Price = 350, Number = 19},
                new Computers(){Id = 9, BrandComputers = "MSI", TypeProcessor = "AMD", CPU = 4, RAM = 4, SSD = 256, VideoCardValue = 16, Price = 100, Number = 26},
                new Computers(){Id = 10, BrandComputers = "ACER", TypeProcessor = "Intel", CPU = 4.2, RAM = 8, SSD = 512, VideoCardValue = 4, Price = 750, Number = 32}
            };

             Console.Write("Выберите процессор (Intel or AMD): ");
             string typeProcessor = Console.ReadLine();

            List<Computers> computers = listComputers
                 .Where(d => d.TypeProcessor == typeProcessor).ToList();
             Print(computers);

             Console.ReadKey();
             Console.Clear();

             Console.Write("Выберете объём Оперативной памяти (от 2 до 12): ");
             double ram = Convert.ToDouble(Console.ReadLine());
             List<Computers> computers1 = listComputers
                 .Where(c => c.RAM == ram).ToList();
             Print(computers1);

             Console.ReadKey();
             Console.Clear();

             Console.WriteLine("Весь список по увеличению стоимости: ");
             List<Computers> computers2 = listComputers
                 .OrderBy(c => c.Price).ToList();
             Print(computers2);

             Console.ReadKey();
             Console.Clear();

             Console.WriteLine("Весь список по типу процессора: ");
             List<Computers> computers3 = listComputers
                 .OrderBy(c => c.TypeProcessor).ToList();
             Print(computers3);

             Console.ReadKey();
             Console.Clear();

            Console.WriteLine("Компьютер с максимальной ценой: ");
            Computers computers4 = listComputers.OrderByDescending(x => x.Price).FirstOrDefault();
            Console.WriteLine($"\nID: {computers4.Id}; " +
                 $"Марка компьютера: {computers4.BrandComputers}; " +
                 $"Тип процессора: {computers4.TypeProcessor}; " +
                 $"Частота процессора: {computers4.CPU:F2}; " +
                 $"Оперативная память: {computers4.RAM}; " +
                 $"Объём жёсткого диска: {computers4.SSD}; " +
                 $"Объём видеокарты: {computers4.VideoCardValue}; " +
                 $"Цена: {computers4.Price:F2}; " +
                 $"Количество: {computers4.Number} ");

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Компьютер с минимальной ценой: ");
            Computers computers5 = listComputers.OrderBy(x => x.Price).FirstOrDefault();
            Console.WriteLine($"\nID: {computers5.Id}; " +
                 $"Марка компьютера: {computers5.BrandComputers}; " +
                 $"Тип процессора: {computers5.TypeProcessor}; " +
                 $"Частота процессора: {computers5.CPU:F2}; " +
                 $"Оперативная память: {computers5.RAM}; " +
                 $"Объём жёсткого диска: {computers5.SSD}; " +
                 $"Объём видеокарты: {computers5.VideoCardValue}; " +
                 $"Цена: {computers5.Price:F2}; " +
                 $"Количество: {computers5.Number} ");

            Console.ReadKey();
            Console.Clear();

            Console.Write("Есть ли компьютер в количестве не менее 30 шт.: ");
            Console.WriteLine(listComputers.Any(a => a.Number >= 30));

            Console.ReadKey();
        }

        static void Print(List<Computers> computers)
        {
            foreach (Computers c in computers)
            {
                Console.WriteLine($"\nID: {c.Id}; " +
                    $"Марка компьютера: {c.BrandComputers}; " +
                    $"Тип процессора: {c.TypeProcessor}; " +
                    $"Частота процессора: {c.CPU:F2}; " +
                    $"Оперативная память: {c.RAM}; " +
                    $"Объём жёсткого диска: {c.SSD}; " +
                    $"Объём видеокарты: {c.VideoCardValue}; " +
                    $"Цена: {c.Price:F2}; " +
                    $"Количество: {c.Number} ");
            }
            Console.WriteLine();
        }
    }
}
