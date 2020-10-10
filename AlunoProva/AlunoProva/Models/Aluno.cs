using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlunoProva.Models
{
    public class Aluno
    {

        public int Id { get; set; }
        public String Nome { get; set; }
        public String Endereco { get; set; }
        public String Filiacao { get; set; }
        public String Curso { get; set; }
        public int Telefone { get; set; }
        public String Email { get; set; }
    }
}