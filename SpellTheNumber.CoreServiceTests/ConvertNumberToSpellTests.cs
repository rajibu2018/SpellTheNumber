using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpellToNumber.CoreService.Impl;
using SpellToNumber.CoreService.Interfaces;
using SpellToNumber.ViewModel;

namespace SpellTheNumber.CoreServiceTests {
    [TestClass]
    public class ConvertNumberToSpellTests {
        public IConvertNumberToSpell ConvertNumberToSpell { get; set; }

        public ConvertNumberToSpellTests() {
            ConvertNumberToSpell = new ConvertNumberToSpell();
        }
        [TestMethod]
        public void IsAcceptingANumber() {
            var input = new SpellNumberViewModel { Number = "1" };
            var result = ConvertNumberToSpell.GetWordFromNumber(input);
            Assert.AreEqual("One", result.Word);
        }

        [TestMethod]
        public void IsAcceptingString() {
            var input = new SpellNumberViewModel { Number = "Test String" };
            var result = ConvertNumberToSpell.GetWordFromNumber(input);
            Assert.AreEqual("Unable to get word", result.Word);
        }

        [TestMethod]
        public void CanGetSingleDigitNumber() {
            var input = new SpellNumberViewModel { Number = "1" };
            var result = ConvertNumberToSpell.GetWordFromNumber(input);
            Assert.AreEqual("One", result.Word);
        }

        [TestMethod]
        public void CanGetTwoDigitNumber_Twelve() {
            var input = new SpellNumberViewModel { Number = "12" };
            var result = ConvertNumberToSpell.GetWordFromNumber(input);
            Assert.AreEqual("Twelve", result.Word);
        }

        [TestMethod]
        public void CanGetTwoDigitNumber_ThirtyNine() {
            var input = new SpellNumberViewModel { Number = "39" };
            var result = ConvertNumberToSpell.GetWordFromNumber(input);
            Assert.AreEqual("Thirty Nine", result.Word);
        }

        [TestMethod]
        public void CanConvertZero() {
            var input = new SpellNumberViewModel { Number = "0" };
            var result = ConvertNumberToSpell.GetWordFromNumber(input);
            Assert.AreEqual("Zero", result.Word);
        }

        [TestMethod]
        public void CanGetThreeDigitNumber_OneHundredThirtyNine() {
            var input = new SpellNumberViewModel { Number = "139" };
            var result = ConvertNumberToSpell.GetWordFromNumber(input);
            Assert.AreEqual("One Hundred Thirty Nine", result.Word);
        }
        [TestMethod]
        public void CanGetThreeDigitNumber_OneHundredTwelve() {
            var input = new SpellNumberViewModel { Number = "112" };
            var result = ConvertNumberToSpell.GetWordFromNumber(input);
            Assert.AreEqual("One Hundred Twelve", result.Word);
        }
    }
}
