namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            var database = new Database();
            var fizzBuzz = new FizzBuzz(database);

            var lines = fizzBuzz.CountTo100();

            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }

            fizzBuzz.TransformFromDatabase();

            Console.ReadLine();
        }
    }
}