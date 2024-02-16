namespace DataTypesApp
{
    class DataTypesProgram
    {
        static void Main(string[] args)
        {
        Console.Write("Enter the pieces of apple: ");
            int pieces;
            pieces = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter total price of " + pieces + " apples");
            double price;
            price = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("The total price of " + pieces + " is: " + price);
            Console.WriteLine("The value of original price is " + price);
            Console.WriteLine("The value of converted price is " + (int)price);

        }
    }
}
