namespace Capitulo2
{
    public class Produto
    {
        public string Nome;
        public double Valor { get; set; }

        public Produto(string nome, double valor)
        {
            this.Nome = nome;
            this.Valor = valor;
        }        
    }
}
