using _03_Dominio;
using System;
using System.Collections.Generic;

namespace _04_Infraestructura
{
    public class RepositorioProducto : IRepositorioProducto
    {
        private List<Producto> productos;

        public RepositorioProducto()
        {
            productos = new List<Producto>();
            Producto producto = Producto.CrearDesdePrimitivos(
                1, "NombreFalso", 3, "CategoriaX"
            );
            productos.Add(producto);
        }

        public Producto BuscarPorNombre(Nombre nombre)
        {
            return this.productos.Find(p => p.Nombre().Value() == nombre.Value());
        }

        public void Modificar(Producto producto)
        {
            Producto productoEncontrado = this.productos.Find(p => p.Id().Value() == producto.Id().Value());
            productoEncontrado.Modificar(
                producto.Nombre(),
                producto.Cantidad(),
                producto.Categoria()
            );
        }
        //public Producto BuscarPorNombre(Nombre nombre)
        //{

        //}
    }
}
