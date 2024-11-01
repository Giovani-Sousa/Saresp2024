using System.ComponentModel.DataAnnotations;

namespace Saresp2024.Models
{
    public class Aluno
    {
        [Display(Name = "Id do Aluno")]
        public int IdAluno { get; set; }

        [Required(ErrorMessage = "O Nome do Aluno é obrigatório")]
        [Display(Name = "Nome do Aluno")]
        public string NomeAluno { get; set; }

        [Required(ErrorMessage = "O Email do Aluno é obrigatório")]
        [EmailAddress(ErrorMessage = "O Email deve ser válido")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O Telefone é obrigatório")]
        [StringLength(12, ErrorMessage = "O Telefone deve ter no máximo 12 digitos")]
        [Display(Name = "Telefone")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "A Série é obrigatória")]
        [Display(Name = "Série")]
        public string Serie { get; set; }

        [Required(ErrorMessage = "A Turma é obrigatória")]
        [Display(Name = "Turma")]
        public string Turma { get; set; }

        [Required(ErrorMessage = "A Data de Nascimento é obrigatória")]
        [DataType(DataType.Date)]
        [Display(Name = "Data de Nascimento")]
        public DateTime DtNascimento { get; set; }
    }
}
