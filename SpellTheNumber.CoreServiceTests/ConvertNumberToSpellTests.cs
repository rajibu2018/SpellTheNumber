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
        public void IsANumber() {
            var input = new SpellNumberViewModel { Number = "1" };
            var result = ConvertNumberToSpell.GetWordFromNumber(input);
            Assert.AreEqual("One", result.Word);
        }

        [TestMethod]
        public void IsAcceptingString() {
            var input = new SpellNumberViewModel { Number = "1" };
            var result = ConvertNumberToSpell.GetWordFromNumber(input);
            Assert.AreEqual("Unable to get word", result.Word);
        }
        public void CanGetSingleDigitNumber() {
            var input = new SpellNumberViewModel { Number = "1" };
            var result = ConvertNumberToSpell.GetWordFromNumber(input);
            Assert.AreEqual("One", result.Word);
        }
    }
}
