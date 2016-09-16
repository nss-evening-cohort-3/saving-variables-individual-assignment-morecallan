﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavingVariables.Models
{
    public class Variable
    {
        [Key]
        public int VariableId { get; set; }

        //Properties: => Table columns.
        [Required]
        public char Var { get; set; }
        [Required]
        public int Val { get; set; }

    }
}
