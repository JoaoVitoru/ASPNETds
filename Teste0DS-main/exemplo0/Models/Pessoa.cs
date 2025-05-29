using System.ComponentModel.DataAnnotations;

namespace exemplo0.Models
{
    public class Pessoa
    {
        [Display (Name = "Código do Cliente")]
        public int PessoaId { get; set; }
        [Display (Name = "Nome do Cliente")]

        /*get é um método que retorna o valor atual de um atributo;
         set permite definir ou modificar o valor de um atributo
        */
        public string? Nome { get; set; }
        [EmailAddress (ErrorMessage = "Endereço de email inválido")]
        public string? Email { get; set; }

    }
}
