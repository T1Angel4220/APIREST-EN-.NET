using MiApiRest.Models;

namespace APIREST_WINDOWS_.Services
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