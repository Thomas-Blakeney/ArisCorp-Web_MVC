﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ArisCorpWeb.Areas.VerseExkurs.Controllers
{
    [Area("VerseExkurs")]
    public class UEERegierungController : Controller
    {
        [Route("VerseExkurs/UEE-reg")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
