using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NeoSoft.Day1.Session1.Services;
using NeoSoft.Day1.Session1.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NeoSoft.Day1.Session1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoansController : ControllerBase
    {
        private readonly ILoanApplicationService _service;

        public LoansController(ILoanApplicationService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<LoanApplicationViewModel>> Get()
        {
            return Ok(_service.Get());
        }

        [HttpGet("{id}")]
        public ActionResult<LoanApplicationViewModel> Get(int id)
        {
            return Ok(_service.Get(id));
        }
    }
}
