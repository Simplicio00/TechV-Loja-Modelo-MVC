using System.Collections.Generic;
using System.Threading.Tasks;
using Classes.Produto;

namespace Data.Resources.Interfaces
{
    public interface IProduto : IGeneric<Produto>
    {
        Task<List<Produto>> SearchProduct(string value);
    }
}