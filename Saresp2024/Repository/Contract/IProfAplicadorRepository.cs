using Saresp2024.Models;
namespace Saresp2024.Repository.Contract
{
    public interface IProfAplicadorRepository
    {
        void Cadastrar(ProfAplicador prof);
        string? ObterTodosProfessores();

        public interface IProfAplicadorRepository
        {
            IEnumerable<ProfAplicador> ObterTodosProfessores();
            void Cadastrar(ProfAplicador prof);
        }
    }
}
