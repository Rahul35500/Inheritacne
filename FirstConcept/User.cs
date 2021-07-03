using System;

namespace FirstConcept
{
    public class User
    {
        public string name;
        private string location;

        public User()
        {
            Console.WriteLine("Base constructor");
        }
        public void GetUserInfo(string address)
        {
            location=address;
            Console.WriteLine($"Name:{name}");
            Console.WriteLine($"Location:{location}");
        }
        

    }
}