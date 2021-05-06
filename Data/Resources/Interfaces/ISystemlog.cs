using Classes.Historico;
using Classes.Registro;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Data.Resources.Interfaces
{
    public interface ISystemlog
    {
        Task<List<HistoricoCompra>> Syslog();

        Task<List<HistoricoCompra>> GetUserHistory(int id);

        Task UpdateStatus(HistoricoCompra historico);

        Task<HistoricoCompra> GetHistory(string codigo);

        Task<int> Post(HistoricoCompra historico);

        Task Post(Registro registro);

    }
}