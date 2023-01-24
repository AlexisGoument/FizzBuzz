namespace FizzBuzz.UnitTests
{
    public class HelperTests
    {
        private IHelper _helper;

        [SetUp]
        public void Setup()
        {
            _helper = new Helper();
        }

        [Test]
        public void IsMultiple3_Success()
        {
            var actual = _helper.IsMultiple3(3);
            Assert.That(actual, Is.True);
        }

        [Test]
        public void IsMultiple3_False()
        {
            var actual = _helper.IsMultiple3(2);
            Assert.That(actual, Is.False);
        }

        [TestCase(0)]
        [TestCase(5)]
        [TestCase(15)]
        [TestCase(125)]
        public void IsMultiple5_Success(int nb)
        {
            var actual = _helper.IsMultiple3(3);
            Assert.That(actual, Is.True);
        }

        [TestCase(1)]
        [TestCase(4)]
        [TestCase(6)]
        [TestCase(101)]
        public void IsMultiple5_False(int nb)
        {
            var actual = _helper.IsMultiple3(2);
            Assert.That(actual, Is.False);
        }
    }
}