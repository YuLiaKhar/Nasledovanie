using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Building building = new Building("Ул. Садовая, д.3", 60, 40, 4);
            MultiBuilding multiBuilding = new MultiBuilding("Ул. Мраморная, д.8", 40, 30, 20, 5);
            building.Print();
            Console.WriteLine();
            multiBuilding.Print();
            Console.ReadKey();
        }
    }
    class Building
    {
        public string Address { get; set; }
        public int Length { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public Building(string address, int length, int wigth, int height)
        {
            Address = address;
            Length = length;
            Width = wigth;
            Height = height;
        }
        public void Print()
        {
            Console.WriteLine("Адрес: {0}", Address);
            Console.WriteLine("Длина здания: {0} м", Length);
            Console.WriteLine("Ширина здания: {0} м", Width);
            Console.WriteLine("Высота здания: {0} м", Height);
        }
    }
    sealed class MultiBuilding : Building
    {
        public int Floor { get; set; }
        public MultiBuilding(string address, int length, int wigth, int height, int floor) : base(address, length, wigth, height)
        {
            Floor = floor;
        }
        public new void Print()
        {
            base.Print();
            Console.WriteLine("Количество этажей: {0}" ,Floor);
        }
    }
}