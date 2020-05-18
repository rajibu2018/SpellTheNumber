using SpellToNumber.CoreService.Interfaces;
using SpellToNumber.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpellToNumber.CoreService.Impl {

    public class ConvertNumberToSpell : IConvertNumberToSpell {

        public SpellNumberViewModel GetWordFromNumber(SpellNumberViewModel viewModel) {
            try {
                int input = Int32.Parse(viewModel.Number);
                viewModel.Word = "One";
            } catch (FormatException) {
                viewModel.Word = "Unable to get word";
            }
            return viewModel;
        }
    }
}
