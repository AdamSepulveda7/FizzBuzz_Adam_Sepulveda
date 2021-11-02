using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzzRestfulApi.Web.Models
{
    public class DivisorTokenDto
    {
        public int Divisor { get; set; }
        public string Tokens { get; set; }
    }
}
