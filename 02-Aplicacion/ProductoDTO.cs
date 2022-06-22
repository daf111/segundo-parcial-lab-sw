using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Aplicacion
{
    public class ProductoDTO
    {
        private int id;
        private string nombre;
        private int cantidad;
        private string categoria;

        public ProductoDTO(
            int id, string nombre, int cantidad, string categoria
        )
        {
            this.id = id;
            this.nombre = nombre;
            this.cantidad = cantidad;
            this.categoria = categoria;
        }

        public int Id()
        {
            return this.id;
        }
        public string Nombre()
        {
            return this.nombre;
        }
        public int Cantidad()
        {
            return this.cantidad;
        }
        public string Categoria()
        {
            return this.categoria;
        }
    }
}
