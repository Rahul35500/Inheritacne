using System;

namespace FirstConcept
{
    class Program
    {
        static void Main(string[] args)
        {
            Details firstObject=new Details();
            firstObject.name="Harsh singh";
            firstObject.age=21;
            firstObject.GetUserInfo("Bangalore");
            firstObject.GetAge();
        }
    }
}
