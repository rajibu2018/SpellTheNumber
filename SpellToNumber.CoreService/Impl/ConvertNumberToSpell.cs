using SpellToNumber.CoreService.Interfaces;
using SpellToNumber.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpellToNumber.CoreService.Impl {

    public class ConvertNumberToSpell : IConvertNumberToSpell {

        public SpellNumberViewModel GetWordFromNumber(SpellNumberViewModel viewModel) {
            try {
                var input = Int32.Parse(viewModel.Number);


                viewModel.Word = SpellNumber(viewModel.Number);
            } catch (FormatException) {
                viewModel.Word = "Unable to get word";
            }
            return viewModel;
        }
        /// <summary>
        /// get word for the input number
        /// </summary>
        /// <param name="input"></param>
        /// <returns>words</returns>
        private string SpellNumber(string input) {
            var word = string.Empty; 
            var isDone = false;//test if already translated    
            var dblAmt = (Convert.ToInt32(input));
            if (dblAmt > 0) {

                var numDigits = input.Length;
                var position = 0;//
                var place = "";//  
                switch (numDigits) {
                    case 1://ones'  

                        word = OnesPlace(input);
                        isDone = true;
                        break;
                    case 2://tens'    
                        word = TensPlaces(input);
                        isDone = true;
                        break;
                    case 3://hundreds'   
                        position = (numDigits % 3) + 1;
                        place = " Hundred ";
                        break;
                    case 4://thousands'     
                    case 5:
                    case 6:
                        position = (numDigits % 4) + 1;
                        place = " Thousand ";
                        break;
                    case 7://millions'     
                    case 8:
                    case 9:
                        position = (numDigits % 7) + 1;
                        place = " Million ";
                        break;
                    case 10://Billions's     
                    case 11:
                    case 12:

                        position = (numDigits % 10) + 1;
                        place = " Billion ";
                        break;
                    //add extra case options for anything above Billion...    
                    default:
                        isDone = true;
                        break;
                }
                if (!isDone) {//if transalation is not done, continue...(Recursion comes in now!!)    
                    if (input.Substring(0, position) != "0" && input.Substring(position) != "0") {
                        try {
                            word = SpellNumber(input.Substring(0, position)) + place + SpellNumber(input.Substring(position));
                        } catch { }
                    } else {
                        word = SpellNumber(input.Substring(0, position)) + SpellNumber(input.Substring(position));
                    }
  
                }
                  
                if (word.Trim().Equals(place.Trim())) word = "";
                
            }
            if (string.IsNullOrEmpty(word) && input == "0") word = "Zero";
            return word;
        }

        /// <summary>
        /// get word for Ones Place
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private String OnesPlace(string input) {
            var name = "";
            var number = Convert.ToInt32(input);
            switch (number) {

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

        /// <summary>
        /// get word for Tens Places
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private String TensPlaces(string input) {
           
            var name = string.Empty;
            var number = Convert.ToInt32(input);
            switch (number) {
                case 10:
                    name = "Ten";
                    break;
                case 11:
                    name = "Eleven";
                    break;
                case 12:
                    name = "Twelve";
                    break;
                case 13:
                    name = "Thirteen";
                    break;
                case 14:
                    name = "Fourteen";
                    break;
                case 15:
                    name = "Fifteen";
                    break;
                case 16:
                    name = "Sixteen";
                    break;
                case 17:
                    name = "Seventeen";
                    break;
                case 18:
                    name = "Eighteen";
                    break;
                case 19:
                    name = "Nineteen";
                    break;
                case 20:
                    name = "Twenty";
                    break;
                case 30:
                    name = "Thirty";
                    break;
                case 40:
                    name = "Fourty";
                    break;
                case 50:
                    name = "Fifty";
                    break;
                case 60:
                    name = "Sixty";
                    break;
                case 70:
                    name = "Seventy";
                    break;
                case 80:
                    name = "Eighty";
                    break;
                case 90:
                    name = "Ninety";
                    break;
                default:
                    if (number > 0) {
                        name = TensPlaces(input.Substring(0, 1) + "0") + " " + OnesPlace(input.Substring(1));
                    }
                    break;
            }
            return name;
        }
    }
}
