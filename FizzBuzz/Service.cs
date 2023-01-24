namespace FizzBuzz
{
    public interface IService
    {
        string FizzBuzz(string? s);
    }

    public class Service : IService
    {
        public IHelper _helper { get; set; }
        public IRepository _repository { get; set; }

        public Service(IHelper helper, IRepository repository)
        {
            _helper = helper;
            _repository = repository;
        }

        public string FizzBuzz(string? str)
        {
            string result = "";

            if (int.TryParse(str, out int nb))
            {
                if (_helper.IsMultiple3(nb) && _helper.IsMultiple5(nb)) result = "FizzBuzz";
                else if (_helper.IsMultiple3(nb)) result = "Fizz";
                else if (_helper.IsMultiple5(nb)) result = "Buzz";
                else result = str;

                Write(nb, result);
            }
            else
            {
                Console.WriteLine(string.Format("{0} is not a number\n", str));
            }

            return result;
        }

        public void Write(int nb, string str)
        {
            Console.WriteLine(str);
            Console.WriteLine("");
            _repository.Log(nb, str);
        }
    }
}
