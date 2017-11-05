using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Revisao.Models
{
    public class Aluno
    {
        [StringLength(5, MinimumLength = 5, ErrorMessage = "O RM deve ter 5 dígitos!")]
        public string RM { get; set; }

        [Range(0,10, ErrorMessage = "A nota deve estar entre 0 e 10!")]
        [Display(Name = "NAC")]
        public double NotaNAC { get; set; }

        [Range(0, 10, ErrorMessage = "A nota deve estar entre 0 e 10!")]
        [Display(Name = "AM")]
        public double NotaAM { get; set; }

        [Range(0, 10, ErrorMessage = "A nota deve estar entre 0 e 10!")]
        [Display(Name = "PS")]
        public double NotaPS { get; set; }

        [Display(Name = "Média")]
        public double Media { get; set; }
    }
}