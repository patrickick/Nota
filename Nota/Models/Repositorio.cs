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
            a.Media = a.NotaNAC * 0.2 + a.NotaAM * 0.3 + a.NotaPS * 0.5;
            _alunos.Add(a);
        }


    }
}