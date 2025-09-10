using MiApiRest.Models;
using MiApiRest.Repositories;

namespace MiApiRest.Services
{
    public class ProductoService : IProductoService
    {
        private readonly IProductoRepository _repository;

        public ProductoService(IProductoRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Producto> ObtenerProductos() => _repository.GetAll();

        public Producto? ObtenerProducto(int id) => _repository.GetById(id);

        public void CrearProducto(Producto producto) => _repository.Add(producto);

        public void ActualizarProducto(Producto producto) => _repository.Update(producto);

        public void EliminarProducto(int id) => _repository.Delete(id);
   }
}
