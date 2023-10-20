namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            var fizzBuzz = new FizzBuzz();

            var lines = fizzBuzz.CountTo100();

            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }
            Console.ReadLine();
        }
    }
}