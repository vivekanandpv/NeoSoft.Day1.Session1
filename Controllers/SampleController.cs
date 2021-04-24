using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NeoSoft.Day1.Session1.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NeoSoft.Day1.Session1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SampleController : ControllerBase
    {
        private readonly ValueProvider _valueProvider;
        public SampleController(ValueProvider valueProvider)
        {
            _valueProvider = valueProvider;
        }


        [HttpGet]
        public IActionResult Foo()
        {
            return Ok(_valueProvider.GetValue());
        }
    }
}
