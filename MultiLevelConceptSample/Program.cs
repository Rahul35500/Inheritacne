using System;

namespace MultiLevelConceptSample
{
    class Program
    {
        static void Main(string[] args)
        {
           UserAge obj = new UserAge();
          obj.name = "harsh";
          obj.location = "Hyderabad";
          obj.age = 23;
          obj.GetName();
          obj.GetLocation();
          obj.GetAge();
        }
    }
}
