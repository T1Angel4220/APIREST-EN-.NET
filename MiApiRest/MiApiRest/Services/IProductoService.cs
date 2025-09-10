using MiApiRest.Models;

namespace MiApiRest.Services
{
    public interface IProductoService
    {
        IEnumerable<Producto> ObtenerProductos();
        Producto? ObtenerProducto(int id);
        void CrearProducto(Producto producto);
        void ActualizarProducto(Producto producto);
        void EliminarProducto(int id);
   }
}