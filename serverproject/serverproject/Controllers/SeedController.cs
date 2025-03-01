using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using modelDB;

namespace serverproject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeedController(WorldCitySourceContext context) : ControllerBase
    {
        [HttpPost("Country")]
        public async Task<ActionResult> ImportCountriesAsync()
        {

        }

        [HttpPost("Cities")]
        public async Task<ActionResult> ImportCitiesAsync()
        {

        }
    }
}
