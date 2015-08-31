﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Authorization;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace CodeComb.ChinaTelecom.Website.Controllers
{
    [Authorize]
    public class CustomerController : BaseController
    {
        // GET: /<controller>/
        public IActionResult Operating()
        {
            return View();
        }
    }
}