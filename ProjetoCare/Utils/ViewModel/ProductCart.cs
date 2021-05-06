
namespace ProjetoCare.Utils.ViewModel
{
    public class ProductCart : ExtensionCart
    {
        public int IdProduto { get; set; }
        public int QuantidadeCarrinho { get; set; }
    }

    public class ExtensionCart 
    {
        public double Preco {get;set;}
        public string NomeProduto {get;set;}
        public string Imagem {get;set;}
    }
}