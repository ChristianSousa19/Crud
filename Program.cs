using System;
using System.Linq;
using APPCURSO2.Models;
using Microsoft.EntityFrameworkCore;
using APPCURSO2.Data;
namespace AppCurso
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var context = new AppCursoDataContext())
            {
                var aluno = new Aluno { Nome="Christian de Sousa Carvalho", Email="Christianssv37@gmail.com", , DataCriacao=DateTime.Now};
                context.Alunos.Add(aluno);
                context.SaveChanges();
                var alunos = context.Alunos.FirstOrDefault(x => x.Id == 17);
                 aluno.Nome="Christian de Sousa Carvalho";
                 aluno.Email="Christianssv37@gmail.com";
                 
                 aluno.DataCriacao= DateTime.Parse("2022-11-26 22:30:32.694");

                 context.Update(aluno);
                 context.SaveChanges();

                 //var alunos = context.Alunos.FirstOrDefault(x => x.Id == 17);

                // context.Remove(aluno);
                 //context.SaveChanges();
                
                 //var alunos = context
                    // .Alunos
                    // .AsNoTracking()
                     //ToList();
                      //.Where(x => x.Nome.Contains("Christian de Sousa Carvalho"));

             //foreach (var aluno in alunos)
               //  {
                   //  Console.WriteLine(aluno.Nome);
                // }

                // var alunos = context
                     //.Alunos
                    //.AsNoTracking()
                    // .FirstOrDefault(x => x.Id == 9);
                 //Console.WriteLine(aluno?.Nome);
            }
        }
    }
}
