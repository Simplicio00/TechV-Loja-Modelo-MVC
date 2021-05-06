using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Classes.Produto;
using Data.Contexts;
using Data.Resources.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Data.Resources.Repositories
{
    public class ProdutoRepository : IProduto
    {
        DBContext _db;
        public ProdutoRepository( DBContext _db)
        {
            this._db = _db;    
        }

        public async Task Add(Produto objeto)
        {
            try
            {
                await _db.AddAsync(objeto);
                await _db.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Produto>> List() => await _db.Produto.Include(a => a.Imagens).Include(a => a.IdEstoqueNavigation).Include(a => a.IdCategoriaNavigation).ToListAsync();

        public async Task<Produto> SearchById(int id) => await _db.Produto.Include(a => a.IdEstoqueNavigation).Include(a => a.IdCategoriaNavigation).Include(a => a.Imagens).FirstOrDefaultAsync(a => a.IdProduto == id);

        public async Task<List<Produto>> SearchProduct(string value) => await _db.Produto.Include(a => a.IdEstoqueNavigation).Include(a => a.IdCategoriaNavigation).Include(a => a.Imagens).Where(a => a.NomeProduto.Contains(value)).ToListAsync();

        public async Task Update(Produto objeto)
        {
            try
            {
                _db.Produto.Update(objeto);
                await _db.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}