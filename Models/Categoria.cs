using System.ComponentModel.DataAnnotations;

namespace GestaoEventos.Models
{
    public class Categoria
    {

        //Passo 1 : Criar a model com seus atributos
        public int Id { get; set; }
        [Required(ErrorMessage = "O nome da categoria é obrigatória")]
        public string Nome { get; set; } = string.Empty;
    }
}
