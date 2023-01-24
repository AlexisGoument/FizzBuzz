namespace FizzBuzz
{
    public interface IHelper
    {
        bool IsMultiple3(int nb);
        bool IsMultiple5(int nb);
    }

    public class Helper : IHelper
    {
        public bool IsMultiple3(int nb)
        {
            return nb % 3 == 0;
        }

        public bool IsMultiple5(int nb)
        {
            return nb % 5 == 0;
        }
    }
}
