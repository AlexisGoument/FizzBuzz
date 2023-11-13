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

            throw new NotImplementedException();
        }

        public string[] CountTo100()
        {
            var results = new List<string>();

            for (int nb = 1; nb <= 100; ++nb)
            {
                if (IsMultiple3(nb) && IsMultiple5(nb)) results.Add("FizzBuzz");
                else if (IsMultiple3(nb)) results.Add("Fizz");
                else if (IsMultiple5(nb)) results.Add("Buzz");
                else results.Add(nb.ToString());
            }

            return results.ToArray();
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
