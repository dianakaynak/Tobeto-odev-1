namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Add();
            Add();
            Add();
            Add();
            var result = Add2();

            Console.WriteLine(result);

            Console.ReadLine();
        }

        static void Add()
        {
            Console.WriteLine("Added!!!");

        }

        static int Add2(int number1=20, int number2=30)
        {
            var result = number1 + number2;
            return result;
        }
    }
}