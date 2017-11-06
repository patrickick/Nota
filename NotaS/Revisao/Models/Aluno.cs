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

        [Display(Name = "Matéria")]
        public string Materia { get; set; }

        [Range(0,10, ErrorMessage = "A nota deve estar entre 0 e 10!")]
        [Display(Name = "NAC1")]
        public double NotaNAC1 { get; set; }

        [Range(0, 10, ErrorMessage = "A nota deve estar entre 0 e 10!")]
        [Display(Name = "AM1")]
        public double NotaAM1 { get; set; }

        [Range(0, 10, ErrorMessage = "A nota deve estar entre 0 e 10!")]
        [Display(Name = "PS1")]
        public double NotaPS1 { get; set; }

        [Display(Name = "Média1")]
        public double Media1 { get; set; }

        [Range(0, 10, ErrorMessage = "A nota deve estar entre 0 e 10!")]
        [Display(Name = "NAC2")]
        public double NotaNAC2 { get; set; }

        [Range(0, 10, ErrorMessage = "A nota deve estar entre 0 e 10!")]
        [Display(Name = "AM2")]
        public double NotaAM2 { get; set; }

        [Range(0, 10, ErrorMessage = "A nota deve estar entre 0 e 10!")]
        [Display(Name = "PS2")]
        public double NotaPS2 { get; set; }

        [Display(Name = "Média2")]
        public double Media2 { get; set; }

        [Display(Name = "MédiaFinal")]
        public double MediaFinal { get; set; }

        [Display(Name = "Resultado Final")]
        public string Resultado { get; set; }
    }

}