using System.Collections.Generic;
using System.Threading.Tasks;
using Classes.Categoria;

namespace Data.Resources.Interfaces
{
    public interface ICategoria : IGeneric<Categoria>
    {
        Task<List<Categoria>> Search(string search);
    }
}