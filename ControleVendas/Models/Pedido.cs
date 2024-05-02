using System.ComponentModel.DataAnnotations;

namespace ControleVendas.Models
{
    public class Pedido
    {
        public int PedidoID { get; set; }

        [Required]
        [Display(Name = "Produto")]
        public int Produto_Id { get; set; }

        [Required]
        [Display(Name = "Cliente")]
        public int Cliente_Id { get; set; }

        [Required]
        [Display(Name = "Vendedor")]
        public int Vendedor_Id { get; set; }
    }
}
