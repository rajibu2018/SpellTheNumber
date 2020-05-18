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
                viewModel.Word = OnesPlace(input);
            } catch (FormatException) {
                viewModel.Word = "Unable to get word";
            }
            return viewModel;
        }

        private String OnesPlace(int input) {
            String name = "";
            switch (input) {

                case 1:
                    name = "One";
                    break;
                case 2:
                    name = "Two";
                    break;
                case 3:
                    name = "Three";
                    break;
                case 4:
                    name = "Four";
                    break;
                case 5:
                    name = "Five";
                    break;
                case 6:
                    name = "Six";
                    break;
                case 7:
                    name = "Seven";
                    break;
                case 8:
                    name = "Eight";
                    break;
                case 9:
                    name = "Nine";
                    break;
            }
            return name;
        }
    }
}
