using FizzBuzzRestfulApi.Web.Models;
using FizzBuzzRESTfulService.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzzRestfulApi.Web.Infrastructure
{
    public class FizzBuzzService : IFizzBuzzService
    {
        public IEnumerable<string> Classic()
        {
            int min = 1;
            int max = 100;
            int size = Math.Abs(max - min)+1;
            //string[] result = new string[size];
            List<string> result = new List<string>();
            DivisorTokenDto fizz = new DivisorTokenDto()
            {
                Divisor = 3,
                Tokens = "Fizz"
            };
            DivisorTokenDto buzz = new DivisorTokenDto()
            {
                Divisor = 5,
                Tokens = "Buzz"
            };
            for (int i = min; i < size+1; i++)
            {
                if (i % fizz.Divisor == 0 && i % buzz.Divisor == 0)
                {
                    result.Add(fizz.Tokens + buzz.Tokens);
                }
                else if (i % fizz.Divisor == 0)
                {
                    result.Add(fizz.Tokens);
                }
                else if (i % buzz.Divisor == 0)
                {
                    result.Add(buzz.Tokens);
                }
                else
                {
                    result.Add(i.ToString());
                }
            }
            return result;

        }
        public IEnumerable<string> Advanced()
        {
            int min = -12;
            int max = 145;
            int size = Math.Abs(max - min)+1;
            List<string> result = new List<string>();
            DivisorTokenDto fizz = new DivisorTokenDto()
            {
                Divisor = 3,
                Tokens = "Fizz"
            };
            DivisorTokenDto buzz = new DivisorTokenDto()
            {
                Divisor = 7,
                Tokens = "Buzz"
            };DivisorTokenDto bazz = new DivisorTokenDto()
            {
                Divisor = 38,
                Tokens = "Bazz"
            };
            for (int i = min; i < size-1; i++)
            {
                if (i % fizz.Divisor == 0 && i % buzz.Divisor == 0 && i % bazz.Divisor == 0)
                {
                    result.Add(fizz.Tokens + buzz.Tokens + bazz.Tokens);
                }
                else if (i % fizz.Divisor == 0 && i % buzz.Divisor == 0)
                {
                    result.Add(fizz.Tokens + buzz.Tokens);
                }
                else if (i % fizz.Divisor == 0 && i % bazz.Divisor == 0)
                {
                    result.Add(fizz.Tokens + bazz.Tokens);
                }
                else if (i % buzz.Divisor == 0 && i % bazz.Divisor == 0)
                {
                    result.Add(buzz.Tokens + bazz.Tokens);
                }
                else if (i % fizz.Divisor == 0)
                {
                    result.Add(fizz.Tokens);
                }
                else if (i % buzz.Divisor == 0)
                {
                    result.Add(buzz.Tokens);
                }
                else if (i % bazz.Divisor == 0)
                {
                    result.Add(bazz.Tokens);
                }
                else
                {
                    result.Add(i.ToString());
                }
            }
            return result;
        }
        public IEnumerable<string> CustomRange(int min, int max, [FromBody] List<DivisorTokenDto> divisorTokenDtos)
        {
            int size = Math.Abs(max - min);
            List<string> result = new List<string>();
            
            for (int i = min; i < size + 1; i++)
            {
                string str = "";
                foreach(DivisorTokenDto dto in divisorTokenDtos)
                {
                    if(i % dto.Divisor == 0)
                    {
                        str += dto.Tokens;
                    }
                }
                if(str != "")
                {
                    result.Add(str);
                }
                else
                {
                    result.Add(i.ToString());
                }
            }
            return result;
        }
        public IEnumerable<string> CustomSet([FromQuery] List<int> numbers, [FromBody] List<DivisorTokenDto> divisorTokenDtos)
        {
            List<string> result = new List<string>();

            foreach(int i in numbers)
            {
                string str = "";
                foreach (DivisorTokenDto dto in divisorTokenDtos)
                {
                    if (i % dto.Divisor == 0)
                    {
                        str += dto.Tokens;
                    }
                }
                if (str != "")
                {
                    result.Add(str);
                }
                else
                {
                    result.Add(i.ToString());
                }
            }
            return result;
        }
    }
}
