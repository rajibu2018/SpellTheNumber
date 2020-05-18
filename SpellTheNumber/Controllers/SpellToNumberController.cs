using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpellToNumber.ViewModel;

namespace SpellTheNumber.Controllers
{
    public class SpellToNumberController : Controller
    {
        public IActionResult Index()
        {
            var model = new SpellNumberViewModel();
            return View(model);
        }
    }
}