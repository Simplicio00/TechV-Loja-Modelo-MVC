using Classes.Usuario;
using Data.Contexts;
using Data.Resources.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Data.Resources.Repositories
{
	public class UsuarioRepository : IUsuario
	{
		private readonly DBContext _ctx;
		public UsuarioRepository(DBContext _ctx)
		{
			this._ctx = _ctx;
		}
		public async Task Add(Usuario objeto)
		{
			try
			{
				_ctx.Usuario.Add(objeto);
				await _ctx.SaveChangesAsync();
			}
			catch (Exception)
			{
				throw;
			}
		}

		public Task Delete(int id)
		{
			throw new NotImplementedException();
		}

		public async Task<List<Usuario>> List() => await _ctx.Usuario.ToListAsync();

		public async Task<Usuario> Login(string email, string password) => await _ctx.Usuario.AsTracking().FirstOrDefaultAsync(a => a.Email == email && a.Senha == password);


		public async Task<Usuario> SearchById(int id) => await _ctx.Usuario.AsTracking().FirstOrDefaultAsync(a => a.IdUsuario == id);

		public async Task Update(Usuario objeto)
		{
			try
			{
				_ctx.Usuario.Update(objeto);
				await _ctx.SaveChangesAsync();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
