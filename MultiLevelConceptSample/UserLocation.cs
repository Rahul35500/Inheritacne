using System;

namespace MultiLevelConceptSample
{
    public class UserLocation :UserName
    {
        public string location;
        public void GetLocation()
        {
            Console.WriteLine($"Location: {location}");
        }
    }
}