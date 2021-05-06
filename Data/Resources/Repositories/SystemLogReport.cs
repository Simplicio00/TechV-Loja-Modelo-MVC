using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Classes.Historico;
using Classes.Registro;
using Data.Contexts;
using Data.Resources.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Data.Resources.Repositories
{
    public class SystemLogReport : ISystemlog
    {
        private DBContext _ct;
        public SystemLogReport(DBContext _ct)
        {
            this._ct = _ct;
        }

		public async Task<HistoricoCompra> GetHistory(string codigo) => await _ct.HistoricoCompra
		.Include(a => a.IdUsuarioNavigation).Include(a => a.Registros).AsTracking()
		.FirstOrDefaultAsync(a => a.Codigo == codigo);

		public async Task<List<HistoricoCompra>> GetUserHistory(int id) => await _ct.HistoricoCompra
        .Include(a => a.IdUsuarioNavigation).Include(a => a.Registros).Where(a => a.IdUsuario == id).OrderBy(a => a.DataEmissao)
        .AsTracking().ToListAsync();


        public async Task<int> Post(HistoricoCompra historico)
		{
			try
			{
                await _ct.AddAsync(historico);
                await _ct.SaveChangesAsync();

				return historico.IdHistoricoCompra;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public async Task Post(Registro registro)
		{
			try
			{
				await _ct.Registro.AddAsync(registro);
				await _ct.SaveChangesAsync();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public async Task<List<HistoricoCompra>> Syslog() => await _ct.HistoricoCompra
        .Include(a => a.IdUsuarioNavigation).OrderBy(a => a.DataEmissao)
        .AsTracking().ToListAsync();

		public async Task UpdateStatus(HistoricoCompra historico)
		{
			try
			{
				_ct.HistoricoCompra.Update(historico);
				await _ct.SaveChangesAsync();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}