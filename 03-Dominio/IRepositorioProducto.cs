using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Dominio
{
    public interface IRepositorioProducto
    {
        void Modificar(Producto producto);
        Producto BuscarPorNombre(Nombre nombre);
    }
}
