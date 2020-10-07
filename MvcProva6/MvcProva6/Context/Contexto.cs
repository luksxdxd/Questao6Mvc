using MvcProva6.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcProva6.Context
{
    public class Contexto : DbContext
    {
        public DbSet<AlunoModel> alunos { get; set; }
    }
}