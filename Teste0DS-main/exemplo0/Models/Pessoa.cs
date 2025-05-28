namespace exemplo0.Models
{
    public class Pessoa
    {
        [Display(Name = "Código do Cliente")]
        public int PessoaId { get; set; }
        /*get é um método que retorna o valor atual de um atributo;
         set permite definir ou modificar o valor de um atributo
        */
        public string?/*operador ternário*/ Nome { get; set; }
        public string?/*operador ternário*/ Email { get; set; }

    }
}
