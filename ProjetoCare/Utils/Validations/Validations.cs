using Classes.Categoria;
using Classes.Produto;
using Classes.Usuario;
using Microsoft.AspNetCore.Http;
using ProjetoCare.Utils.DefaultValue;
using ProjetoCare.Utils.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ProjetoCare.Utils.Validations
{
    public class Validations
    {
		const string PR1 = "1-5";
        const string PR2 = "6-10";
        const string PR3 = "11-15";
        const string PR4 = "16-20";

		/// <summary>
		/// Faz a validacao de um valor pelo criterio de limite de caracteres e a verificacao de valor nulo
		/// </summary>
		/// <param name="valor">Valor inserido</param>
		/// <param name="limitLenght">Estabelece o limite de caracteres para a string</param>
		/// <returns>Retorna uma valida��o de verdadeiro ou falso</returns>
		public static bool DefaultSingleStringValidation(string valor, int limitLenght) => !string.IsNullOrEmpty(valor) && valor.Length > 3 && valor.Length < limitLenght ? true : false;



        /// <summary>
        /// Verifica se uma lista de strings cont�m o valor determinado
        /// </summary>
        /// <param name="list">Lista contendo os valores</param>
        /// <param name="valor">Valor que ser� procurado na lista</param>
        /// <returns>Retorna uma valida��o de verdadeiro ou falso</returns>
        public static bool ValueStringExists(IEnumerable<string> list, string valor) => list.Contains(valor) ? true : false;



        /// <summary>
        /// Faz a listagem de categorias por ordem alfab�tica
        /// </summary>
        /// <param name="list">Lista de categorias requisitada</param>
        /// <returns>Retorna uma lista de categorias</returns>
        public static List<Categoria> AlfabeticListCategoria(IEnumerable<Categoria> list) => list.OrderBy(a => a.NomeCategoria).ToList();



        /// <summary>
        /// Faz a listagem de categorias pela quantidade de produtos
        /// </summary>
        /// <param name="list">Faz a listagem dos produtos</param>
        /// <returns>Retorna uma lista de categorias</returns>
        public static List<Categoria> MostProductsListCategoria(IEnumerable<Categoria> list) => list.OrderByDescending(a => a.Produto.Count).ToList();


        /// <summary>
        /// Faz a pesquisa simples de uma categoria
        /// </summary>
        /// <param name="list">lista</param>
        /// <param name="categoria">Categoria buscada</param>
        /// <returns>Retorna uma lista de categorias</returns>
        public static List<Categoria> SearchCategoria(IEnumerable<Categoria> list, string categoria) => list.Where(a => a.NomeCategoria.Contains(categoria)).ToList();
    
    

        /// <summary>
        /// Faz o cálculo de produtos por página
        /// </summary>
        /// <param name="pg">Páginas</param>
        /// <param name="pageSize">Produtos máximos da página</param>
        /// <returns>Retorna um número inteiro</returns>
        public static int RecSkip(int pg, int pageSize) => (pg - 1) * pageSize;


        /// <summary>
        /// Validação para saber se o arquivo inserido via formulário é imagem
        /// </summary>
        /// <param name="file">Arquivo de formulário HTML</param>
        /// <returns>Retorna verdadeiro ou falso</returns>
        public static bool IsImage(IFormFile file) => file.ContentType.Contains("jpeg") || file.ContentType.Contains("png") ? true : false;



        /// <summary>
        /// Validação para saber se há algum produto cadastrado na categoria
        /// </summary>
        /// <param name="categoria">Categoria a ser avaliada</param>
        /// <returns>Retorna verdadeiro ou falso</returns>
        public static bool CategoriaContainProduct(Categoria categoria) => categoria.Produto.Count > 0 ? true : false;

        
        /// <summary>
        /// Faz uma validação simples
        /// </summary>
        /// <param name="status">status inserido</param>
        /// <param name="statusRequired">status requerido</param>
        /// <returns>Retorna verdeiro ou falso</returns>
        public static bool RequiredStringValidation(string status, string statusRequired) => status == statusRequired ? true : false;


        /// <summary>
        /// Faz a validação de E-mail no formato válido
        /// </summary>
        /// <param name="email">E-mail para cadastro</param>
        /// <returns>Retorna verdadeiro ou falso</returns>
        public static bool IsEmailValid(string email) => Regex.IsMatch(email, DefaultStrings.EmailRegexProp) ? true : false;



        /// <summary>
        /// Faz a validação perguntando se o E-Mail já está cadastrado
        /// </summary>
        /// <param name="email">Email inserido</param>
        /// <param name="Email">Lista de usuários cadastrados</param>
        /// <returns>Retorna verdadeiro se existe, e falso caso o email não estiver cadastrado</returns>
        public static bool EmailExists(string email, List<Usuario> Email) => Email.Exists(a => a.Email == email) ? true : false;




        /// <summary>
        /// Gera um código para a transação
        /// </summary>
        /// <returns>retorna um código</returns>
        public static string GenerateTransactionCode() => $"transaction-{Guid.NewGuid()}";




        /// <summary>
        /// Faz separação unitária dos produtos adicionados ao carrinho/cesta
        /// </summary>
        /// <param name="list">lista de produtos</param>
        /// <returns>Retorna uma lista ordenada com todos os produtos desejados</returns>
        public static List<string> UnityCount(List<ProductCart> list)
		{
            List<string> newlist = new List<string>();

			foreach (var unity in list)
			{
				if (unity.QuantidadeCarrinho > 1)
                {
                    int indice = 0;

                    do
                    {
                        newlist.Add($"{unity.NomeProduto} -- {unity.Preco.ToString("C")}");

                        indice++;

                    } while (unity.QuantidadeCarrinho != indice);

                }
				else
				{
                     newlist.Add($"{unity.NomeProduto} -- {unity.Preco.ToString("C")}");
                }
            }

            return newlist;

        }



        /// <summary>
        /// Validação do produto com a sua lista
        /// </summary>
        /// <param name="list">Lista bruta de produtos</param>
        /// <param name="statusRequired">Status de disponibilidade do produto</param>
        /// <param name="pesquisa">String de pesquisa</param>
        /// <returns>Retorna a lista de produtos com os produtos válidos (com e sem pesquisa)</returns>
        public static List<Produto> ProductIntegratedVerification(List<Produto> list, string statusRequired, string? pesquisa, string? prices)
        {
            List<Produto> produtos = new List<Produto>();
            List<string> categorias = new List<string>();

            foreach (var item in list.ToList())
            {
                categorias.Add(item.IdCategoriaNavigation.NomeCategoria);
            }

            if(ValueStringExists(categorias, pesquisa).Equals(true))
            {
                foreach (Produto produto in list.Where(a => a.IdCategoriaNavigation.NomeCategoria.ToUpper().Trim().Contains(pesquisa.ToUpper().Trim())).ToList())
                {
                    if(RequiredStringValidation(produto.IdEstoqueNavigation.Status, statusRequired).Equals(true))
				    {
						produtos.Add(produto);
				    }
                }

            }
            else if (DefaultSingleStringValidation(pesquisa, 30).Equals(true))
            {
                foreach (Produto produto in list.Where(a => a.Descricao.ToLower().Contains(pesquisa.ToLower()) || a.NomeProduto.ToLower().Contains(pesquisa.ToLower())))
                {
                    if(RequiredStringValidation(produto.IdEstoqueNavigation.Status, statusRequired).Equals(true))
					{
						produtos.Add(produto);
					}
                }
                return produtos;
            }
            else
            {
                foreach (Produto produto in list)
                {
                    if(RequiredStringValidation(produto.IdEstoqueNavigation.Status, statusRequired).Equals(true))
					{
						produtos.Add(produto);
					}
                }
            }


            if (!string.IsNullOrEmpty(prices))
            {
                List<Produto> produto = new List<Produto>();

                switch (prices)
                {

                    case PR1:
                        produto = produtos.Where(a => a.Preco > 1 && a.Preco < 5).OrderBy(a => a.Preco).ToList();
                        return produto;

                    case PR2:
                        produto = produtos.Where(a => a.Preco > 5 && a.Preco < 10).OrderBy(a => a.Preco).ToList();
                        return produto;

                    case PR3:
                        produto = produtos.Where(a => a.Preco > 10 && a.Preco < 15).OrderBy(a => a.Preco).ToList();
                        return produto;

                    case PR4:
                        produto = produtos.Where(a => a.Preco > 15 && a.Preco < 20).OrderBy(a => a.Preco).ToList();
                        return produto;

                }
            }


            return produtos;
        }
        


    }

}