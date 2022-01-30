using eCommerceServer.Data;
using eCommerceServer.Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerceServer.Controllers
{

    public class HomeController : ApiController
    {
        private readonly eCommerceDbContext _db;

        public HomeController(eCommerceDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        [Route("test")]
        public IActionResult Home()
        {
            return Ok("Works");
        }

        [Authorize]
        [HttpGet]
        [Route("auth")]
        public ActionResult<string> Users()
        {
            return Ok("authentication work");
        }


    }
}
