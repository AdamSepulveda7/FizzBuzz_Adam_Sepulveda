using FizzBuzzRestfulApi.Web.Infrastructure;
using FizzBuzzRestfulApi.Web.Models;
using NUnit.Framework;
using System.Collections.Generic;

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
        public void ClassicPass()
        {
            List<string> list = new List<string>();
            list = (List<string>)_fizzBuzzApi.Classic();
            Assert.AreEqual(list.IndexOf("Fizz"),2);
            Assert.AreEqual(list.IndexOf("Buzz"),4);
            Assert.AreEqual(list.Count,100);
        }
        [Test]
        public void AdvancedPass()
        {
            List<string> list = new List<string>();
            list = (List<string>)_fizzBuzzApi.Advanced();
            Assert.AreEqual(list.IndexOf("Fizz"), 0);
            Assert.AreEqual(list.IndexOf("Buzz"), 5);
            Assert.AreEqual(list.IndexOf("Bazz"), 50);
            Assert.AreEqual(list.Count, 158);
        }
        [Test]
        public void CustomRangePass()
        {
            List<string> list = new List<string>();
            List<DivisorTokenDto> dtoList = new List<DivisorTokenDto>();
            DivisorTokenDto fizz = new DivisorTokenDto()
            {
                Divisor = 3,
                Tokens = "Fizz"
            };
            DivisorTokenDto buzz = new DivisorTokenDto()
            {
                Divisor = 5,
                Tokens = "Buzz"
            }; DivisorTokenDto bazz = new DivisorTokenDto()
            {
                Divisor = 7,
                Tokens = "Bazz"
            };
            dtoList.Add(fizz);
            dtoList.Add(buzz);
            dtoList.Add(bazz);
            list = (List<string>)_fizzBuzzApi.CustomRange(-100,100,dtoList);
            Assert.AreEqual(list.IndexOf("Fizz"), 1);
            Assert.AreEqual(list.IndexOf("Buzz"), 0);
            Assert.AreEqual(list.IndexOf("Bazz"), 2);
            Assert.AreEqual(list.Count, 201);
        }
        [Test]
        public void CustomSetPass()
        {
            List<string> list = new List<string>();
            List<DivisorTokenDto> dtoList = new List<DivisorTokenDto>();
            List<int> numbers = new List<int> { 3, 7, -38, 4 };
            DivisorTokenDto fizz = new DivisorTokenDto()
            {
                Divisor = 3,
                Tokens = "Fizz"
            };
            DivisorTokenDto buzz = new DivisorTokenDto()
            {
                Divisor = 7,
                Tokens = "Buzz"
            }; DivisorTokenDto bazz = new DivisorTokenDto()
            {
                Divisor = 38,
                Tokens = "Bazz"
            };
            dtoList.Add(fizz);
            dtoList.Add(buzz);
            dtoList.Add(bazz);
            list = (List<string>)_fizzBuzzApi.CustomSet(numbers, dtoList);
            Assert.AreEqual(list.IndexOf("Fizz"), 0);
            Assert.AreEqual(list.IndexOf("Buzz"), 1);
            Assert.AreEqual(list.IndexOf("Bazz"), 2);
            Assert.AreEqual(list.Count, 4);
        }
    }
}