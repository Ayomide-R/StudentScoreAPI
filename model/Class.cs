using Microsoft.EntityFrameworkCore.Metadata;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography;

namespace StudentScoreAPI.model
{
    [Table(¨aluno¨)]
    public class Aluno
    {
        [Key]
        private int cpf {  get; private set; }
        private string email {  get; private set; }
        private string senha { get; private set; }
        private string nome { get; private set; }

        public Aluno(int cpf, string email, string nome)
        {
            this.cpf = cpf;
            this.email = email;
            this.nome = nome;
        }
        
       

    }
}
