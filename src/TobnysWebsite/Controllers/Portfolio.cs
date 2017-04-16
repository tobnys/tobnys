using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace TobnysWebsite.Controllers
{
    public class Portfolio : Controller
    {
        [Route("portfolio/tobnys")]
        public IActionResult tobnys()
        {
            return View();
        }

        [Route("portfolio/mkey")]
        public IActionResult mkey()
        {
            return View();
        }
    }
}
