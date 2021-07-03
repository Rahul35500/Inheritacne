namespace LaptopInformation
{
    class Laptop:LaptopDetails
    {
        public void ShowDetails(string name,string price,string processor,string ram,string Hard_drive)
        {
            System.Console.WriteLine($"Name:{name}");
            System.Console.WriteLine($"Price:{price}");
            System.Console.WriteLine($"processor:{processor}");
            System.Console.WriteLine($"Ram:{ram}");
            System.Console.WriteLine($"Hard Drive:{Hard_drive}");
        }
    }
}