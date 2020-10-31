using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using CRUD.Models;

namespace CRUD.DAO
{
    public class InicializadorPessoa : System.Data.Entity.DropCreateDatabaseIfModelChanges<PessoaContext>
    {
        protected override void Seed(PessoaContext context)
        {
            var students = new List<Pessoa>
            {
            new Pessoa{Nome="Carson",Sexo='M',DataDeNascimento=DateTime.Parse("2005-09-01")},
            new Pessoa{Nome="Meredith",Sexo='M',DataDeNascimento=DateTime.Parse("2002-09-01")},
            new Pessoa{Nome="Arturo",Sexo='M',DataDeNascimento=DateTime.Parse("2003-09-01")},
            new Pessoa{Nome="Gytis",Sexo='F',DataDeNascimento=DateTime.Parse("2002-09-01")},
            new Pessoa{Nome="Yan",Sexo='F',DataDeNascimento=DateTime.Parse("2002-09-01")},
            new Pessoa{Nome="Peggy",Sexo='F',DataDeNascimento=DateTime.Parse("2001-09-01")},
            new Pessoa{Nome="Laura",Sexo='F',DataDeNascimento=DateTime.Parse("2003-09-01")},
            new Pessoa{Nome="Nino",Sexo='M',DataDeNascimento=DateTime.Parse("2005-09-01")}
            };

            students.ForEach(s => context.pessoas.Add(s));
            context.SaveChanges();
            
        }
    }
}