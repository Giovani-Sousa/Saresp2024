using MySql.Data.MySqlClient;
using Saresp2024.Models;
using Saresp2024.Repository.Contract;
namespace Saresp2024.Repository
{
    public class AlunoRepository : IAlunoRepository
    {
        private readonly string _conexaoMySql;

        public AlunoRepository(IConfiguration conf)
        {
            _conexaoMySql = conf.GetConnectionString("conexaoMySql");
        }

        public void Cadastrar(Aluno aluno)
        {
            using (var conexao = new MySqlConnection(_conexaoMySql))
            {
                conexao.Open();

                MySqlCommand cmd = new MySqlCommand("insert into aluno(Nome, Email, Telefone, Serie, Turma, DataNasc) values(@Nome, @Email, @Telefone, @Serie, @Turma, @DataNasc)", conexao);

                cmd.Parameters.Add("@Nome", MySqlDbType.VarChar).Value = aluno.NomeAluno;
                cmd.Parameters.Add("@Email", MySqlDbType.VarChar).Value = aluno.Email;
                cmd.Parameters.Add("@Telefone", MySqlDbType.VarChar).Value = decimal.Parse(aluno.Telefone);
                cmd.Parameters.Add("@Serie", MySqlDbType.VarChar).Value = aluno.Serie;
                cmd.Parameters.Add("@Turma", MySqlDbType.VarChar).Value = aluno.Turma;
                cmd.Parameters.Add("@DataNasc", MySqlDbType.DateTime).Value = aluno.DtNascimento;

                cmd.ExecuteNonQuery();
                conexao.Close();
            }
        }

        public IEnumerable<Aluno> obterTodosAlunos()
        {
            var alunos = new List<Aluno>();

            using (var conexao = new MySqlConnection(_conexaoMySql))
            {
                conexao.Open();

                MySqlCommand cmd = new MySqlCommand("Select * from aluno", conexao);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var aluno = new Aluno
                        {
                            IdAluno = reader.GetInt32("IdAluno"),
                            NomeAluno = reader.GetString("NomeAluno"),
                            Email = reader.GetString("Email"),
                            Telefone = reader.GetDecimal("Telefone").ToString("0"),
                            Serie = reader.GetString("Serie"),
                            Turma = reader.GetString("Turma"),
                            DtNascimento= reader.GetDateTime("DtNascimento")
                        };

                        alunos.Add(aluno);
                    }

                    conexao.Close();
                }

                return alunos;
            }
        }
    }
}
