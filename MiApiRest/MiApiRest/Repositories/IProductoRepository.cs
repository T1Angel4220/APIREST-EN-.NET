using APIREST_WINDOWS_.Models;
using MiApiRest.Models;

namespace APIREST_WINDOWS_.Repositories
{
    public interface IProductoRepository
    {
        IEnumerable<Producto> GetAll();
        Producto? GetById(int id);
        void Add(Producto producto);
        void Update(Producto producto);
        void Delete(int id);
    }
}