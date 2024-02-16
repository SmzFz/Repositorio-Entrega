using System.ComponentModel.DataAnnotations;

namespace AppVendasWeb.Models
{
    public class AddCategoria
    {
        public Guid AddCategoriaId { get; set; }


        [Display(Name = "Nome da Categoria")]
        public Guid CategoriaId { get; set; }
        public Categoria? Categoria { get; set; }

    }
}
