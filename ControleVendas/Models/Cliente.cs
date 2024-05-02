using System.ComponentModel.DataAnnotations;

namespace ControleVendas.Models
{
    public class Cliente
    {
        public int ClienteId { get; set; }

        [Required(ErrorMessage = "O nome do cliente é obrigatório")]
        [StringLength(100, ErrorMessage = "O nome do cliente deve ter no máximo 100 caracteres")]
        public string Nome { get; set; }

        [Display(Name ="CPF ou CNPJ")]
        [Required(ErrorMessage = "O CPF ou CNPJ do cliente é obrigatório")]
        [StringLength(14, MinimumLength = 11, ErrorMessage = "O CPF ou CNPJ do cliente deve ter entre 11 e 14 caracteres")]
        public string CpfCnpj { get; set; }

        [Required(ErrorMessage = "O telefone do cliente é obrigatório")]
        [StringLength(11, MinimumLength = 9, ErrorMessage = "O telefone do cliente deve ter entre 9 e 11 caracteres")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "O e-mail do cliente é obrigatório")]
        [EmailAddress(ErrorMessage = "Formato de e-mail inválido")]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [StringLength(100, ErrorMessage = "O logradouro deve ter no máximo 100 caracteres")]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "O número é obrigatório")]
        [Display(Name = "Número")]
        public string Numero { get; set; }

        [StringLength(50, ErrorMessage = "O complemento deve ter no máximo 50 caracteres")]
        public string Complemento { get; set; }

        [StringLength(50, ErrorMessage = "O bairro deve ter no máximo 50 caracteres")]
        public string Bairro { get; set; }

        [StringLength(50, ErrorMessage = "A cidade deve ter no máximo 50 caracteres")]
        public string Cidade { get; set; }

        [StringLength(2, MinimumLength = 2, ErrorMessage = "A sigla do estado deve ter 2 caracteres")]
        public string Estado { get; set; }

        [Required(ErrorMessage = "O CEP é obrigatório")]
        [StringLength(8, MinimumLength = 8, ErrorMessage = "O CEP deve ter 8 caracteres")]
        public string CEP { get; set; }

        [ScaffoldColumn(false)]
        public int NivelAcessoId { get; set; } = 3; // Todo cliente terá nível de acesso 3

        [Required(ErrorMessage = "A senha é obrigatória")]
        [DataType(DataType.Password)]
        [StringLength(8, MinimumLength = 8, ErrorMessage = "A senha deve ter 8 caracteres.")]
        public string Senha { get; set; }
    }
}
