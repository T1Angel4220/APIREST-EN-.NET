using APIREST_WINDOWS_.Models;
using MiApiRest.Models;
using System.Xml.Linq;

namespace APIREST_WINDOWS_.Repositories
{
    public class ProductoRepository : IProductoRepository
    {
        private static List<Producto> _productos = new()
        {
            new Producto { Id = 1, Nombre = "Laptop", Precio = 1200.50m, Disponible = true },
            new Producto { Id = 2, Nombre = "Mouse", Precio = 25.00m, Disponible = true },
            new Producto { Id = 3, Nombre = "Teclado", Precio = 75.99m, Disponible = false }
        };

        public IEnumerable<Producto> GetAll() => _productos;

        public Producto? GetById(int id) => _productos.FirstOrDefault(p => p.Id == id);

        public void Add(Producto producto)
        {
            producto.Id = _productos.Any() ? _productos.Max(p => p.Id) + 1 : 1;
            _productos.Add(producto);
        }

        public void Update(Producto producto)
        {
            var existing = GetById(producto.Id);
            if (existing != null)
            {
                existing.Nombre = producto.Nombre;
                existing.Precio = producto.Precio;
                existing.Disponible = producto.Disponible;
            }
        }

        public void Delete(int id)
        {
            var producto = GetById(id);
            if (producto != null)
                _productos.Remove(producto);
        }
    }
}