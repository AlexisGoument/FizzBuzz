namespace FizzBuzz
{
    public class FizzBuzz
    {
        private DatabaseInterface _database;

        public FizzBuzz(DatabaseInterface database)
        {
            _database = database;
        }

        public string[] TransformFromDatabase()
        {
            var numbers = _database.GetNumbers();

            return numbers.Select(GetFizzBuzz).ToArray();
        }

        public string[] CountTo100()
        {
            var results = new List<string>();

            for (int nb = 1; nb <= 100; ++nb)
            {
                results.Add(GetFizzBuzz(nb));
            }

            return results.ToArray();
        }

        private string GetFizzBuzz(int nb)
        {
            if (IsMultiple3(nb) && IsMultiple5(nb)) return "FizzBuzz";
            if (IsMultiple3(nb)) return "Fizz";
            if (IsMultiple5(nb)) return "Buzz";
            return nb.ToString();
        }

        protected bool IsMultiple3(int nb)
        {
            return nb % 3 == 0;
        }

        protected bool IsMultiple5(int nb)
        {
            return nb % 5 == 0;
        }
    }
}
