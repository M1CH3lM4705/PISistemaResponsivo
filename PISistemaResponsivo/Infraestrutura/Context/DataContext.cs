using PISistemaResponsivo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PISistemaResponsivo.Infraestrutura.Context
{
    public class DataContext : DbContext
    {
        public DataContext() : base("DataContext")
        {

        }

        public virtual DbSet<PessoaCarente> PessoasCarentes { get; set; }
        public virtual DbSet<Voluntario> Voluntarios { get; set; }
        public virtual DbSet<Paroquia> Paroquias { get; set; }
        public virtual DbSet<Doacao> Doacoes { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
    }
}