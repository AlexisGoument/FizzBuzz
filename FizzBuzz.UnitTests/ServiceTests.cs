using NSubstitute;

//https://nsubstitute.github.io/help/getting-started/

namespace FizzBuzz.UnitTests
{
    public class ServiceTests
    {
        private IHelper _helper;
        private IRepository _repository;
        private IService _service;

        [SetUp]
        public void Setup()
        {
            _helper = new Helper();
            _repository = Substitute.For<IRepository>();
            _service = new Service(_helper, _repository);
        }

        [Test]
        public void Service_Null()
        {
            var actual = _service.FizzBuzz(null);
            Assert.That(actual, Is.Empty);
            _repository.DidNotReceiveWithAnyArgs().Log(Arg.Any<int>(), Arg.Any<string>());
        }

        [Test]
        public void Service_Empty()
        {
            var actual = _service.FizzBuzz("");
            Assert.That(actual, Is.Empty);
            _repository.DidNotReceiveWithAnyArgs().Log(Arg.Any<int>(), Arg.Any<string>());
        }

        [Test]
        public void Service_Fizz()
        {
            var actual = _service.FizzBuzz("3");
            Assert.That(actual, Is.EqualTo("Fizz"));
            _repository.Received().Log(3, "Fizz");
        }

        [Test]
        public void Service_Buzz()
        {
            var actual = _service.FizzBuzz("5");
            Assert.That(actual, Is.EqualTo("Buzz"));
            _repository.Received().Log(5, "Buzz");
        }

        [Test]
        public void Service_FizzBuzz()
        {
            var actual = _service.FizzBuzz("15");
            Assert.That(actual, Is.EqualTo("FizzBuzz"));
            _repository.Received().Log(15, "FizzBuzz");
        }

        [Test]
        public void Service_None()
        {
            var actual = _service.FizzBuzz("8");
            Assert.That(actual, Is.EqualTo("8"));
            _repository.Received().Log(8, "8");
        }
    }
}