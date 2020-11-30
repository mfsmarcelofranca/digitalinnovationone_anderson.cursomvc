using System.ComponentModel.DataAnnotations;

namespace CursoMVC.Models
{
    public class Produto
    {
        public int id { get; set; }

        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "O campo descrição é obrigatório")]
        public string descricao { get; set; }

        [Range(1,10, ErrorMessage = "Valor fora da faixa")]
        public int quantidade { get; set; }

        public int categoriaId { get; set; }

        public Categoria categoria { get; set; }
        
    }
}