using FizzBuzzRestfulApi.Web.Models;
using FizzBuzzRESTfulService.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzzRestfulApi.Web.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class FizzBuzzController : ControllerBase
    {
        private readonly IFizzBuzzService _FizzBuzzApi;
        private DivisorTokenDto dto;

        public FizzBuzzController(IFizzBuzzService fizzBuzzApi)
        {
            _FizzBuzzApi = fizzBuzzApi;
            dto = new DivisorTokenDto();
        }
        [HttpGet]
        public IEnumerable<string> GetClassic()
        {
            var result = _FizzBuzzApi.Classic();
            //if (result == null)
            //    return (IEnumerable<string>)StatusCode(404);
            //else
            //    return (IEnumerable<string>)StatusCode(201, result);
            return result;
            //throw new NotImplementedException();
        }
        [HttpPost]
        public IEnumerable<string> GetAdvanced()
        {
            var result = _FizzBuzzApi.Advanced();
            return result;
        }

        
        [HttpPost]
        public IEnumerable<string> GetCustomRange(int start, int end, [FromBody] List<DivisorTokenDto> divisorTokenDtos)
        {
            var result = _FizzBuzzApi.CustomRange(start, end, divisorTokenDtos);
            return result;
        }


        [HttpPost]
        public IEnumerable<string> GetCustomSet([FromQuery] List<int> numbers, [FromBody] List<DivisorTokenDto> divisorTokenDtos)
        {
            var result = _FizzBuzzApi.CustomSet(numbers, divisorTokenDtos);
            return result;
        }
    }
}
