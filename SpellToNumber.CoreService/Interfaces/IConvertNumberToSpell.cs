using SpellToNumber.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpellToNumber.CoreService.Interfaces
{
   public interface IConvertNumberToSpell
    {
        string GetWordFromNumber(SpellNumberViewModel number);
    }
}
