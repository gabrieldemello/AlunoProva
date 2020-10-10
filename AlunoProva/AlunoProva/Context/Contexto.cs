using AlunoProva.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AlunoProva.Context
{
    public class Contexto : DbContext
    {
        public DbSet<Aluno> alunos { get; set; }
    }
}