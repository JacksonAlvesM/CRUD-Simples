using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CRUD.Models
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public char Sexo { get; set; }
        [DisplayName("Data De Nascimento")]
        public DateTime DataDeNascimento { get; set; }



    }
}
