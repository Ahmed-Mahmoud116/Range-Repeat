namespace Range_Repeat_and_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Even numbers from 2 to 20: \n");
            
            var evenNumbers = Enumerable.Range(2, 20).Where(n => n % 2 == 0);
            foreach (var evenNumber in evenNumbers)
            {
                Console.WriteLine(evenNumber + "\n");
            }
            Console.WriteLine("--------------------\n");
            Console.WriteLine("Hello repeated 5 times: \n");
            var Hello = Enumerable.Repeat("Hello", 5);
            foreach (var hello in Hello)
                Console.WriteLine(hello + "\n");
        }
    }
}
