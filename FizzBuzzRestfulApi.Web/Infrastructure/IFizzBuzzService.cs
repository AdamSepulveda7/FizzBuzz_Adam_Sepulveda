using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using FizzBuzzRestfulApi.Web.Models;

namespace FizzBuzzRESTfulService.Infrastructure
{
    
    public interface IFizzBuzzService
    {
        public IEnumerable<string> Classic();
        public IEnumerable<string> Advanced();
        public IEnumerable<string> CustomRange(int start, int end, [FromBody] List<DivisorTokenDto> divisorTokenDtos);
        public IEnumerable<string> CustomSet([FromQuery] List<int> numbers, [FromBody] List<DivisorTokenDto> divisorTokenDtos);
    }
}