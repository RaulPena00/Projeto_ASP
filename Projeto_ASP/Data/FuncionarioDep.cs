using Microsoft.EntityFrameworkCore;
using Projeto_ASP.Models;

namespace Projeto_ASP.Data
{
    public class FuncionarioDep : DbContext
    {
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-UQQF9JL; Database=ProjetoDep; User Id=ra; Password=ra12345; TrustServerCertificate=True");
        }

    }
}
