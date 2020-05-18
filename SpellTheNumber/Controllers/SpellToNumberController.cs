using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpellToNumber.CoreService.Interfaces;
using SpellToNumber.ViewModel;

namespace SpellTheNumber.Controllers
{
    public class SpellToNumberController : Controller
    {
        public IConvertNumberToSpell ConvertNumberToSpell { get; set; }
        public SpellToNumberController(IConvertNumberToSpell convertNumberToSpell) {
            ConvertNumberToSpell = convertNumberToSpell;
        }
        public IActionResult Index()
        {
            var model = new SpellNumberViewModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult ConertNumber(SpellNumberViewModel viewModel) {
            try {
                if (ModelState.IsValid) {
                    viewModel = ConvertNumberToSpell.GetWordFromNumber(viewModel);
                } else {
                    viewModel.Word = "Please enter a vilid input";
                }
            } catch (Exception ex) {
                viewModel.Word = ex.Message;
            }
           
            return View("Index",viewModel);
        }
    }
}