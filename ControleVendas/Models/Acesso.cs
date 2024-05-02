using System.ComponentModel.DataAnnotations;

namespace ControleVendas.Models
{
    public class Acesso
    {
        [Display(Name = "ID")]
        public int AcessoID { get; set; }

        [Display(Name = "Nível de acesso")]
        [Required(ErrorMessage = "O nome do nível de acesso é obrigatório.")]
        public string AcessoNivel {  get; set; }
    }
}
