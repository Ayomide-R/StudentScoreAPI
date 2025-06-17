using Microsoft.EntityFrameworkCore;
using StudentScoreAPI.model;

namespace StudentScoreAPI.Infraestrutura
{
    public class connection:DbContext
    {
        public DbSet<Aluno> Alunos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "server=127.0.0.1:3306;database=studentscoreapi_bd;user=root;password=s1ea004635";
            var serverVersion = new MySqlServerVersion(new Version(8, 0, 21));

            optionsBuilder.UseMySql(connectionString, serverVersion);
        }
    }
}
