using _03_Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Aplicacion
{
    public class BuscadorProducto
    {
        private IRepositorioProducto repositorio;
        public BuscadorProducto(IRepositorioProducto repositorio)
        {
            this.repositorio = repositorio;
        }
        public ProductoDTO Execute(string nombre)
        {
            Producto productoEncontrado =
                this.repositorio.BuscarPorNombre(
                    new Nombre(nombre)
                );
            return new ProductoDTO(
                productoEncontrado.Id().Value(),
                productoEncontrado.Nombre().Value(),
                productoEncontrado.Cantidad().Value(),
                productoEncontrado.Categoria().Value()
            );
        }
    }
}
