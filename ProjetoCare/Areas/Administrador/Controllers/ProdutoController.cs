using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Classes.Estoque;
using Classes.Imagem;
using Classes.Produto;
using Data.Resources.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProjetoCare.Utils.ArchiveUpload;
using ProjetoCare.Utils.Pagination;
using ProjetoCare.Utils.Security;
using ProjetoCare.Utils.Validations;
using ProjetoCare.Utils.ViewModel;

namespace ProjetoCare.Areas.Administrador.Controllers
{
    [Area("Administrador")]
    public class ProdutoController : Controller
    {
        IProduto _pd;
        IEstoque _es;
        ICategoria _ct;
        UploadFile _up;
        I_IMG _im;

        private const int PageSize = 5;
        public ProdutoController(IProduto _pd, ICategoria _ct, IEstoque _es, UploadFile _up, I_IMG _im)
        {
            this._pd = _pd;
            this._ct = _ct;
            this._es = _es;
            this._up = _up;
            this._im = _im;
        }

        
        /// <summary>
        /// Listagem inicial com todos os produtos cadastrados
        /// </summary>
        /// <param name="pesquisa"> parametro de pesquisa </param>
        /// <param name="pg">página</param>
        /// <returns>Retorna uma página com a lista de produtos</returns>
        [RoleSecurityRoute(adm = true)]
        public async Task<IActionResult> Index(string? pesquisa, int pg = 1)
        {   
            List<Produto> pdt = await _pd.List();

            if(!string.IsNullOrEmpty(pesquisa)) pdt = await _pd.SearchProduct(pesquisa);
            

            if(pg < 1) pg = 1;
            
            Pager pager = new Pager(pdt.Count, pg, PageSize);

            ViewBag.Pager = pager;

            return View(pdt.Skip(Validations.RecSkip(pg, PageSize)).Take(pager.PageSize).ToList());
        } 




        /// <summary>
        /// Tela de cadastro de produto
        /// </summary>
        /// <returns>Retorna a tela de cadastro com informações para inserção de um novo produto</returns>
        [RoleSecurityRoute(adm = true)]
        public async Task<IActionResult> Cadastrar()
        {

            List<SelectListItem> categorias = new List<SelectListItem>();

            foreach (var item in await _ct.List())
            {
                categorias.Add(
                    new SelectListItem() 
                    { Text = item.NomeCategoria, 
                      Value = item.IdCategoria.ToString()
                    });                
            }

            ViewBag.Categorias = categorias; 
            
            return View();

        }


        
        /// <summary>
        /// Ação de cadastrar o produto
        /// </summary>
        /// <param name="produto">Objeto de cadastro do produto</param>
        /// <returns>Realiza o cadastro</returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Cadastrar(ProdutoViewModel produto)
        {
            if (ModelState.IsValid)
            {
                Estoque es = new Estoque()
                {
                    Quantidade = produto.Quantidade,
                    Status = produto.EstoqueStatus
                };

                await _es.Add(es);

                Produto pd = new Produto()
                {
                    NomeProduto = produto.NomeProduto,
                    DataRegistro = DateTime.Today,
                    Descricao = produto.Descricao,
                    Preco = produto.Preco,
                    IdCategoria = produto.IdCategoria,
                    Status = true,
                    Altura = produto.Altura,
                    Comprimento = produto.Comprimento,
                    Peso = produto.Peso,
                    Largura = produto.Largura,
                    IdEstoque = _es.SearchById(es.IdEstoque).Result.IdEstoque
                };

                await _pd.Add(pd);

                
                List<IFormFile> imagens = new List<IFormFile>()
                { 
                    produto.Imagem1, 
                    produto.Imagem2, 
                    produto.Imagem3 
                };

				foreach (IFormFile img in imagens)
				{
                    string novaImg = await _up.UploadFileToLocal(img);
                    if(novaImg != null)
                        await _im.Add(
                            new Imagem(){
                            ImagemCaminho = novaImg,
                            IdProduto = pd.IdProduto
                        });
                }

                TempData["MSG_S"] = "O produto foi cadastrado com sucesso!";

                return RedirectToAction(nameof(Index));
            }
            
            List<SelectListItem> categorias = new List<SelectListItem>();

            foreach (var item in await _ct.List())
            {
                categorias.Add(
                    new SelectListItem() 
                    { Text = item.NomeCategoria, 
                      Value = item.IdCategoria.ToString() 
                    });
            }

            ViewBag.Categorias = categorias;

            return  View(produto);

        }


        /// <summary>
        /// Retorna a página do produto com os seus detalhes editáveis
        /// </summary>
        /// <param name="id">Id do produto</param>
        /// <returns>Retorna informações do produto</returns>
        
        [RoleSecurityRoute(adm = true)]
        [RouteRefererSecurity]
        public async Task<IActionResult> Produto(int id)
        {
            List<SelectListItem> categorias = new List<SelectListItem>();

            foreach (var item in await _ct.List())
            {
                categorias.Add(
                    new SelectListItem() 
                    { 
                        Text = item.NomeCategoria, 
                        Value = item.IdCategoria.ToString() 
                    });
            }

            ViewBag.Categorias = categorias;

            Produto produto = await _pd.SearchById(id);
    
            return View(
                new ProdutoAtualizacaoViewModel(){
                    IdProduto = produto.IdProduto,
                    IdEstoque = produto.IdEstoque,
                    NomeProduto = produto.NomeProduto,
                    Descricao = produto.Descricao,
                    EstoqueStatus = produto.IdEstoqueNavigation.Status,
                    IdCategoria = produto.IdCategoria,
                    Peso = produto.Peso,
                    Altura = produto.Altura,
                    Comprimento = produto.Comprimento,
                    Preco = produto.Preco,
                    Largura = produto.Largura,
                    Quantidade = produto.IdEstoqueNavigation.Quantidade,
                    Imagens = produto.Imagens.ToList()
            });
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Produto(ProdutoAtualizacaoViewModel produto)
        {

            if(ModelState.IsValid){
                await _es.Update(new Estoque(){
                    IdEstoque = produto.IdEstoque,
                    Status = produto.EstoqueStatus,
                    Quantidade = produto.Quantidade
                });

                await Task.Delay(1000);

                await _pd.Update(new Produto(){
                    IdProduto = produto.IdProduto,
                    IdEstoque = produto.IdEstoque,
                    IdCategoria = produto.IdCategoria,
                    NomeProduto = produto.NomeProduto,
                    Descricao = produto.Descricao,
                    Peso = produto.Peso,
                    Altura = produto.Altura,
                    Comprimento = produto.Comprimento,
                    Preco = produto.Preco,
                    Largura = produto.Largura
                });


                return RedirectToAction(nameof(Produto), new { id = produto.IdProduto});
            }

            List<SelectListItem> categorias = new List<SelectListItem>();

            foreach (var item in await _ct.List())
            {
                categorias.Add(
                    new SelectListItem() 
                    { 
                        Text = item.NomeCategoria, 
                        Value = item.IdCategoria.ToString() 
                    });
            }

            ViewBag.Categorias = categorias;

            return View(produto);
        }

        


        /// <summary>
        /// Ação de excluir imagem
        /// </summary>
        /// <param name="id">Id da imagem</param>
        /// <param name="idProduto">Id do produto</param>
        /// <returns>Recarrega a página do produto devidamente atualizada</returns>
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeletarImagem(int id, int idProduto)
		{
            Imagem img = await _im.SearchById(id);
            
            if(img != null)
			{
                await _im.Delete(id);
                await _up.DeleteLocalFile(img.ImagemCaminho);
            }

            return RedirectToAction(nameof(Produto), new { id = idProduto });
        }



        /// <summary>
        /// Cadastro individual de imagem
        /// </summary>
        /// <param name="id">Id da imagem</param>
        /// <param name="img">Arquivo de imagem</param>
        /// <returns>Recarrega a página do produto devidamente atualizada</returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CadastrarImagem(int id, IFormFile img)
		{
            var imagem = await _up.UploadFileToLocal(img);

			if (!string.IsNullOrEmpty(imagem))
			{
                await _im.Add(new Imagem()
                {
                    IdProduto = id,
                    ImagemCaminho = imagem
                });

                return RedirectToAction(nameof(Produto), new { id });
			}

            return RedirectToAction(nameof(Produto), new { id });
        }




    }
}