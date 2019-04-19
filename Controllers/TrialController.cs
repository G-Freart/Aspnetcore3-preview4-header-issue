using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HeaderTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrialController : ControllerBase
    {
        [Route("correct-digit")]
        [HttpGet()]
        public string HeaderDigitOnly()
        {
            Response.Headers.Add("X-header-digit", "1");

            return "correct";
        }

        [Route("error-empty")]
        [HttpGet()]
        public string HeaderDigitEmpty()
        {
            Response.Headers.Add("X-header-digit", "1");
            Response.Headers.Add("X-header-empty", "");

            return "correct";
        }

        [Route("correct-space")]
        [HttpGet()]
        public string HeaderDigitSpace()
        {
            Response.Headers.Add("X-header-digit", "1");
            Response.Headers.Add("X-header-space", " ");

            return "correct";
        }
    }
}
