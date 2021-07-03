using System;

namespace MultipleInheritance
{
    public interface IFirstInterface
    {
        string setImage(string name);
    }
    public interface ISecondInterface
    {
        int getAmount(int amount);
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car obj=new Car();
            obj.getAmount(20000000);
           System.Console.WriteLine(obj.setImage("BMW"));
        }
    }
}
