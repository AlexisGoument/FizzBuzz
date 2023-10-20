namespace FizzBuzz
{
    public class FizzBuzz
    {
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
