namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            var helper = new Helper();
            var repository = new Repository();
            var service = new Service(helper, repository);

            while (true)
            {
                Console.WriteLine("Write a number:");
                string? s = Console.ReadLine();
                service.FizzBuzz(s);
            }
        }
    }
}