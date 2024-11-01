using Saresp2024.Models;
using Saresp2024.Repository.Contract;
using Microsoft.AspNetCore.Mvc;

namespace Saresp2024.Controllers
{
    public class ProfAplicadorController : Controller
    {
        private readonly IProfAplicadorRepository _profAplicadorRepository;

        public ProfAplicadorController(IProfAplicadorRepository profAplicadorRepository)
        {
            _profAplicadorRepository = profAplicadorRepository;
        }
        public IActionResult Index()
        {
            var professores = _profAplicadorRepository.ObterTodosProfessores();
            return View(professores);
        }

        [HttpGet]
        public IActionResult CadastrarProfessor()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CadastrarProfessor(ProfAplicador prof)
        {
            if (ModelState.IsValid)
            {
                _profAplicadorRepository.Cadastrar(prof);
            }

            return View();
        }
    }
}
