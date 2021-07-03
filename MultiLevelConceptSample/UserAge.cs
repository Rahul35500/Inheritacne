using System;

namespace MultiLevelConceptSample
{
   public class UserAge:UserLocation
    {
        public int age;
       public void GetAge()
       {
          Console.WriteLine($"Age:{age}");
       }
    }
}