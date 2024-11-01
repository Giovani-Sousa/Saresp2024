using System.ComponentModel.DataAnnotations;

namespace Saresp2024.Models
{
    public class ProfAplicador
    {
        [Display(Name = "Id do Professor")]
        public int IdProf {  get; set; }

        [Required(ErrorMessage = "O Nome é obrigatório")]
        [Display(Name = "Nome do Professor")]
        public string Nome {  get; set; }

        [Required(ErrorMessage = "O CPF é obrigatório")]
        [StringLength(11, ErrorMessage = "O CPF deve ter 11 dígitos")]
        [Display(Name = "CPF")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "O RG é obrigatório")]
        [StringLength(9, ErrorMessage = "O RG deve ter 9 dígitos")]
        [Display(Name = "RG")]
        public string RG { get; set; }

        [Required(ErrorMessage = "O Telefone é obrigatório")]
        [StringLength(12, ErrorMessage = "O Telefone deve ter 12 dígitos")]
        [Display(Name = "Telefone")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "A Data de Nascimento é obrigatória")]
        [DataType(DataType.Date)]
        [Display(Name = "Data de Nascimento")]
        public DateTime DtNascimento { get; set; }
    }
}
