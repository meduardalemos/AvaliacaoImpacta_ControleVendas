using System.ComponentModel.DataAnnotations;

namespace ControleVendas.Models
{
    public class Funcionario
    {
        public int FuncionarioID { get; set; }

        [Required(ErrorMessage = "O nome do funcionário é obrigatório")]
        [StringLength(100, ErrorMessage = "O nome do produto deve ter no máximo 100 caracteres")]
        public string Nome { get; set; }

        [Display(Name = "CPF")]
        [Required(ErrorMessage = "O CPF do funcionário é obrigatório")]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "O CPF do funcionário deve ter 11 caracteres")]
        public string Cpf { get; set; }

        [Display(Name = "Salário")]
        [Required(ErrorMessage = "O salário do funcionário é obrigatório")]
        [Range(0.01, double.MaxValue, ErrorMessage = "O salário do funcionário deve ser maior que zero")]
        public decimal Salario { get; set; }

        [Display(Name = "Data de Admissão")]
        [DataType(DataType.Date)]
        public DateTime DataAdmissao { get; set; }

        [Display(Name = "Nível de Acesso")]
        [Range(1, 2, ErrorMessage = "O nível de acesso deve 1 para administrador ou 2 para vendedor.")]
        public int NivelAcessoId { get; set; }

        [Required(ErrorMessage = "A senha do funcionário é obrigatória")]
        [DataType(DataType.Password)]
        [StringLength(8, MinimumLength = 8, ErrorMessage = "A senha deve ter 8 caracteres.")]
        public string Senha { get; set; }
    }
}
