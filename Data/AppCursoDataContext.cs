using APPCURSO2.Models;
using Microsoft.EntityFrameworkCore;

namespace APPCURSO2.Data
{
    public class AppCursoDataContext:DbContext
    {
        public DbSet<Aluno>? Alunos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Data Source=usinacompany.com;User ID=usina_usr;Password=Abc54321;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        // protected override void OnModelCreating(ModelBuilder modelBuilder)
        // {
        //     modelBuilder.ApplyConfiguration(new UsuarioMap());
        // }

    }
}