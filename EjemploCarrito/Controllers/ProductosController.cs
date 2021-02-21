using EjemploCarrito.Extensions;
using EjemploCarrito.Models;
using EjemploCarrito.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjemploCarrito.Controllers
{
    public class ProductosController : Controller
    {
        RepositoryProductos repo;

        public ProductosController(RepositoryProductos repo)
        {
            this.repo = repo;
        }

        public IActionResult GetProductos(int? idproducto)
        {
            if (idproducto != null)
            {
                List<int> carrito;
                if (HttpContext.Session.GetObject<List<int>>("CARRITO") == null)
                {
                    carrito = new List<int>();
                }
                else
                {
                    carrito = HttpContext.Session.GetObject<List<int>>("CARRITO");
                }
                if (carrito.Contains(idproducto.Value) == false)
                {
                    carrito.Add(idproducto.Value);
                    HttpContext.Session.SetObject("CARRITO", carrito);
                }
            }
            List<Producto> productos = this.repo.GetProductos();
            return View(productos);
        }

        public IActionResult Carrito(int? idproducto)
        {
            List<int> carrito = HttpContext.Session.GetObject<List<int>>("CARRITO");
            if (carrito == null)
            {
                return View();
            }
            else
            {
                if (idproducto != null)
                {
                    carrito.Remove(idproducto.Value);
                    HttpContext.Session.SetObject("CARRITO", carrito);
                }

                List<Producto> productos = this.repo.GetProductosCarrito(carrito);
                return View(productos);
            }
        }

        public IActionResult Pedidos()
        {
            List<int> carrito = HttpContext.Session.GetObject<List<int>>("CARRITO");
            List<Producto> productos = this.repo.GetProductosCarrito(carrito);
            HttpContext.Session.Remove("CARRITO");
            return View(productos);
        }
    }
}
