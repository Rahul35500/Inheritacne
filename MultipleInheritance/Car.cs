namespace MultipleInheritance
{
    class Car:IFirstInterface,ISecondInterface
    {
        public int getAmount(int amount)
        {
            System.Console.WriteLine($"Amount:{amount}");
            return amount;
        }
        public string setImage(string name)
        {
            return $"Car:{name}";
        }
    }
}