namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ForLoop();
            int number = 100;
            while (number >=0) 
            
            { 
               Console.WriteLine(number);

                number--;   
            
            }
        }

        private static void ForLoop()
        {
            for (int i = 100; i >= 0; i = i - 2)

            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Finished!");

        }
    }
}