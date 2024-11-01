using Saresp2024.Models;
using Saresp2024.Repository.Contract;
using Microsoft.AspNetCore.Mvc;

namespace Saresp2024.Controllers
{
    public class AlunoController : Controller
    {
        private readonly IAlunoRepository _alunoRepository;

        public AlunoController(IAlunoRepository alunoRepository)
        {
            _alunoRepository = alunoRepository;
        }

        public IActionResult Index()
        {
            var Alunos = _alunoRepository.obterTodosAlunos();
            return View(Alunos);
        }

        [HttpGet]
        public IActionResult CadastrarAluno()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CadastrarAluno(Aluno aluno)
        {
            if (ModelState.IsValid)
            {
                _alunoRepository.Cadastrar(aluno);
            }
            return View();
        }
    }
}
