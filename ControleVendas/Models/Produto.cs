using System.ComponentModel.DataAnnotations;

namespace ControleVendas.Models
{
    public class Produto
    {
        public int ProdutoID { get; set; }

        [Required(ErrorMessage = "O nome do produto é obrigatório")]
        [StringLength(100, ErrorMessage = "O nome do produto deve ter no máximo 100 caracteres")]
        public string Nome { get; set; }

        [Display(Name = "Preço")]
        [Required(ErrorMessage = "O preço do produto é obrigatório")]
        [Range(0.01, double.MaxValue, ErrorMessage = "O preço do produto deve ser maior que zero")]
        public decimal Preco { get; set; }

        [Required(ErrorMessage = "A quantidade em estoque do produto é obrigatória")]
        [Range(0, int.MaxValue, ErrorMessage = "A quantidade em estoque do produto deve ser maior ou igual a zero")]
        public int Estoque {  get; set; }

        [ScaffoldColumn(false)]
        [Display(Name = "Data de Cadastro")]
        [DataType(DataType.Date)]
        public DateTime DataCadastro { get; set; }

        public Produto()
        {
            DataCadastro = DateTime.Now;
        }

    }
}
