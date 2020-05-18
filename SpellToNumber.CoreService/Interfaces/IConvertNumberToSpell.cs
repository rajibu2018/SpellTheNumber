using SpellToNumber.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpellToNumber.CoreService.Interfaces
{
    interface IConvertNumberToSpell
    {
        string GetWordFromNumber(SpellNumberViewModel number);
    }
}
