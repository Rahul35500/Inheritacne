using System;

namespace LaptopInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            Laptop obj=new Laptop();
            obj.ShowDetails(Laptop.Asus,Laptop.Price1000,Laptop.i3,LaptopDetails.Ram2GB,Laptop.HD1TB);
            System.Console.WriteLine("----------------------");
            obj.ShowDetails(LaptopDetails.Dell,LaptopDetails.Price2000,LaptopDetails.i5,LaptopDetails.Ram4GB,LaptopDetails.HD250GB);
            System.Console.WriteLine("----------------------");
            obj.ShowDetails(Laptop.HP,Laptop.Price2000,Laptop.i9,Laptop.Ram8GB,Laptop.HD500GB);
        }
    }
}
