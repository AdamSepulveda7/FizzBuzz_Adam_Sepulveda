using FizzBuzzRestfulApi.Web.Infrastructure;
using NUnit.Framework;

namespace FizzBuzzRestfulApi.Tests
{
    public class Tests
    {
        private FizzBuzzService _fizzBuzzApi;
        [SetUp]
        public void Setup()
        {
            _fizzBuzzApi = new FizzBuzzService();
        }

        [Test]
        public void Test1()
        {
            var result = _fizzBuzzApi.Classic();
            string[] compare = { "1", "2", "Fizz", "4", "Buzz", "15" };
            char comp = result.ToString()[0];
            //string.IndexOf(result.ToString(),0);
            //string i = Array.IndexOf(compare, "");
            string i = result.ToString();
            Assert.AreEqual(result.ToString()[0], '1');
            Assert.AreEqual(result.ToString()[2], "Fizz");
            Assert.AreEqual(result.ToString()[4], "Buzz");
            Assert.AreEqual(result.ToString()[14], "FizzBuzz");
        }
    }
}