using _03_Dominio;
using System;

namespace _02_Aplicacion
{
    public class ModificadorProducto
    {
        private IRepositorioProducto repositorio;
        public ModificadorProducto(
            IRepositorioProducto repositorio
        )
        {
            this.repositorio = repositorio;
        }
        public void Execute(ProductoDTO productoDTO)
        {
            Producto producto = Producto.CrearDesdePrimitivos(
                productoDTO.Id(),
                productoDTO.Nombre(),
                productoDTO.Cantidad(),
                productoDTO.Categoria()
            );
            this.repositorio.Modificar(producto);
        }
    }
}
