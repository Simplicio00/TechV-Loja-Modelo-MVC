using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Classes.Categoria;
using Data.Contexts;
using Data.Resources.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Data.Resources.Repositories
{
    public class CategoriaRepository : ICategoria
    {
        private DBContext _db;
        public CategoriaRepository(DBContext _db)
        {
            this._db = _db;
        }
        public async Task Add(Categoria objeto)
        {
			try
			{
                await _db.Categoria.AddAsync(objeto);
                await _db.SaveChangesAsync();
			}
			catch (Exception)
			{
				throw;
			}
        }

        public async Task Delete(int id)
        {
            try
            {
                var categoria = await _db.Categoria.FirstOrDefaultAsync(a => a.IdCategoria == id);
                _db.Remove(categoria);
                await _db.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<Categoria>> List() => await _db.Categoria.AsTracking().Include(a => a.Produto).OrderBy(a => a.NomeCategoria).ToListAsync();

        public async Task<List<Categoria>> Search(string search) => await _db.Categoria.AsTracking().Include(a => a.Produto).Where(a => a.NomeCategoria.Contains(search)).ToListAsync();

		public async Task<Categoria> SearchById(int id) => await _db.Categoria.AsTracking().Include(a => a.Produto).FirstOrDefaultAsync(a => a.IdCategoria == id);

		public async Task Update(Categoria objeto)
        {
            try
            {
                _db.Categoria.Update(objeto);
                await _db.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}