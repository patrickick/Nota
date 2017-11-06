using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Revisao.Models
{
    public class Repositorio
    {
        public static List<Aluno> _alunos = new List<Aluno>();

        public static List<Aluno> GetAlunos()
        {
            return _alunos;
        }

        public static void InsertAluno(Aluno a)
        {
            a.Media1 = a.NotaNAC1 * 0.2 + a.NotaAM1 * 0.3 + a.NotaPS1 * 0.5;
            a.Media2 = a.NotaNAC2 * 0.2 + a.NotaAM2 * 0.3 + a.NotaPS2 * 0.5;
            a.MediaFinal = (a.Media1 + a.Media2) / 2;

            if (a.MediaFinal < 6)
            {
                a.Resultado = "Reprovado";
            }
            else
            {
                a.Resultado = "Aprovado";
            }
            _alunos.Add(a);
        }


    }
}