using System;

namespace FirstConcept
{
    public class Details:User
    {
        public int age;
        public Details()
        {
            Console.WriteLine("Chilld class constructor");
        }
        public void GetAge()
        {
            Console.WriteLine($"Age:{age}");
        }
        

    }
}