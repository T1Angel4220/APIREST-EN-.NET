using MiApiRest.Models;
using MiApiRest.Services;
using Microsoft.AspNetCore.Mvc;

namespace MiApiRest.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductosController : ControllerBase
    {
        private readonly IProductoService _service;

        public ProductosController(IProductoService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Producto>> GetProductos()
        {
            return Ok(_service.ObtenerProductos());
        }

        [HttpGet("{id}")]
        public ActionResult<Producto> GetProducto(int id)
        {
            var producto = _service.ObtenerProducto(id);
            if (producto == null) return NotFound();
            return Ok(producto);
        }

        [HttpPost]
        public ActionResult<Producto> PostProducto(Producto nuevoProducto)
        {
            _service.CrearProducto(nuevoProducto);
            return CreatedAtAction(nameof(GetProducto), new { id = nuevoProducto.Id }, nuevoProducto);
        }

        [HttpPut("{id}")]
        public IActionResult PutProducto(int id, Producto productoActualizado)
        {
            if (id != productoActualizado.Id) return BadRequest();

            var existente = _service.ObtenerProducto(id);
            if (existente == null) return NotFound();

            _service.ActualizarProducto(productoActualizado);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProducto(int id)
        {
            var existente = _service.ObtenerProducto(id);
            if (existente == null) return NotFound();

            _service.EliminarProducto(id);
            return NoContent();
        }
    }
}