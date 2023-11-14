using FizzBuzz;
using NSubstitute;

namespace FizzBuzzTests
{
    public class DummyFizzBuzz : FizzBuzz.FizzBuzz
    {
        public DummyFizzBuzz(DatabaseInterface database) : base(database)
        { }

        public new bool IsMultiple3(int nb)
        {
            return base.IsMultiple3(nb);
        }

        public new bool IsMultiple5(int nb)
        {
            return base.IsMultiple5(nb);
        }
    }

    public class FizzBuzzTests
    {
        private DatabaseInterface _database;
        private DummyFizzBuzz _fizzBuzz;

        [SetUp]
        public void Setup()
        {
            _database = Substitute.For<DatabaseInterface>();
            _fizzBuzz = new DummyFizzBuzz(_database);
        }

        [Test]
        public void IsMultiple3_Success()
        {
            var actual = _fizzBuzz.IsMultiple3(3);
            Assert.That(actual, Is.True);
        }

        [Test]
        public void IsMultiple3_False()
        {
            var actual = _fizzBuzz.IsMultiple3(2);
            Assert.That(actual, Is.False);
        }

        [TestCase(0)]
        [TestCase(5)]
        [TestCase(15)]
        [TestCase(125)]
        public void IsMultiple5_Success(int nb)
        {
            var actual = _fizzBuzz.IsMultiple5(5);
            Assert.That(actual, Is.True);
        }

        [TestCase(1)]
        [TestCase(4)]
        [TestCase(6)]
        [TestCase(101)]
        public void IsMultiple5_False(int nb)
        {
            var actual = _fizzBuzz.IsMultiple5(2);
            Assert.That(actual, Is.False);
        }

        [Test]
        public void FizzBuzz_CountTo100_ShouldReturn100Numbers()
        {
            var results = _fizzBuzz.CountTo100();
            Assert.That(results.Length, Is.EqualTo(100));
        }

        [Test]
        public void FizzBuzz_CountTo100_ShouldBeginBy1()
        {
            var results = _fizzBuzz.CountTo100();
            Assert.That(results[0], Is.EqualTo("1"));
        }

        [Test]
        public void FizzBuzz_TransformFromDatabase()
        {
            var numbers = new[] { 1, 2, 3, 4, 5, 15 };
            _database.GetNumbers().ReturnsForAnyArgs(numbers);
            
            var result = _fizzBuzz.TransformFromDatabase();

            CollectionAssert.AreEqual(new [] { "1", "2", "Fizz", "4", "Buzz", "FizzBuzz" }, result);
        }
    }
}