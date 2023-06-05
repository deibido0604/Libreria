using Libreria.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace Libreria.Web.Controllers
{
    public class ProductosController : Controller
    {
        public IActionResult Index()
        {
            var producto1 = new ProductoModel();
            producto1.Id= 1;
            producto1.Descripcion = "Libro de Matematicas";

            var producto2 = new ProductoModel();
            producto2.Id = 1;
            producto2.Descripcion = "Libro de Fisica";


            var listaDeProductos = new List<ProductoModel>();

            listaDeProductos.Add(producto1);
            listaDeProductos.Add(producto2);

            return View(listaDeProductos);
        }
    }
}
