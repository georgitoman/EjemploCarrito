using EjemploCarrito.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjemploCarrito.Repositories
{
    public class RepositoryProductos
    {
        public List<Producto> GetProductos()
        {
            List<Producto> productos = new List<Producto>();
            Producto producto1 = new Producto
            {
                IdProducto = 1,
                Nombre = "Tortilla",
                Precio = 4
            };
            Producto producto2 = new Producto
            {
                IdProducto = 2,
                Nombre = "Pan",
                Precio = 1
            };
            Producto producto3 = new Producto
            {
                IdProducto = 3,
                Nombre = "Huevos",
                Precio = 3
            };
            Producto producto4 = new Producto
            {
                IdProducto = 4,
                Nombre = "Harina",
                Precio = 1
            };
            Producto producto5 = new Producto
            {
                IdProducto = 5,
                Nombre = "Leche",
                Precio = 1
            };

            productos.Add(producto1);
            productos.Add(producto2);
            productos.Add(producto3);
            productos.Add(producto4);
            productos.Add(producto5);

            return productos;
        }

        public List<Producto> GetProductosCarrito(List<int> idproductos)
        {
            //List<Producto> productos = this.context.Productos.Where(z => idproductos.Contains(z.IdProducto));

            List<Producto> productos = new List<Producto>();
            foreach (int idproducto in idproductos)
            {
                switch (idproducto)
                {
                    case 1:
                        Producto producto1 = new Producto
                        {
                            IdProducto = 1,
                            Nombre = "Tortilla",
                            Precio = 4
                        };
                        productos.Add(producto1);
                        break;
                    case 2:
                        Producto producto2 = new Producto
                        {
                            IdProducto = 2,
                            Nombre = "Pan",
                            Precio = 1
                        };
                        productos.Add(producto2);
                        break;
                    case 3:
                        Producto producto3 = new Producto
                        {
                            IdProducto = 3,
                            Nombre = "Huevos",
                            Precio = 3
                        };
                        productos.Add(producto3);
                        break;
                    case 4:
                        Producto producto4 = new Producto
                        {
                            IdProducto = 4,
                            Nombre = "Harina",
                            Precio = 1
                        };
                        productos.Add(producto4);
                        break;
                    case 5:
                        Producto producto5 = new Producto
                        {
                            IdProducto = 5,
                            Nombre = "Leche",
                            Precio = 1
                        };
                        productos.Add(producto5);
                        break;
                    default:
                        break;
                }
            }

            return productos;
        }



    }
}
