using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpellToNumber.CoreService.Impl;
using SpellToNumber.CoreService.Interfaces;

namespace SpellTheNumber.CoreServiceTests {
    [TestClass]
    public class ConvertNumberToSpellTests {
        public IConvertNumberToSpell ConvertNumberToSpell { get; set; }

        public ConvertNumberToSpellTests() {
            ConvertNumberToSpell = new ConvertNumberToSpell();
        }
        [TestMethod]
        public void TestMethod1() {
        }
    }
}
