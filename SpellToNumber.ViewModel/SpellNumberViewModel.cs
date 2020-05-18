﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SpellToNumber.ViewModel {
    public class SpellNumberViewModel {
        [Display(Name = "Number")]
        public int? Number { get; set; }
        public string Word { get; set; }
    }
}
