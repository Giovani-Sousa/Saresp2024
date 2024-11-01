using Saresp2024.Models;
namespace Saresp2024.Repository.Contract
{
    public interface IAlunoRepository
    {
        IEnumerable<Aluno> obterTodosAlunos();
        void Cadastrar(Aluno aluno);
    }
}
