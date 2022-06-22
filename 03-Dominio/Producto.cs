using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Dominio
{
    public class Producto
    {
        private Id id;
        private Nombre nombre;
        private Cantidad cantidad;
        private Categoria categoria;
        public Producto(
            Id id, Nombre nombre, Cantidad cantidad, Categoria categoria
        )
        {
            this.id = id;
            this.nombre = nombre;
            this.cantidad = cantidad;
            this.categoria = categoria;
        }

        public static Producto CrearDesdePrimitivos(
            int id, string nombre, int cantidad, string categoria
        )
        {
            return new Producto(
                new Id(id),
                new Nombre(nombre),
                new Cantidad(cantidad),
                new Categoria(categoria)
            );
        }

        public void Modificar(
            Nombre nombre, Cantidad cantidad, Categoria categoria
        )
        {
            this.nombre = nombre;
            this.cantidad = cantidad;
            this.categoria = categoria;
        }

        public Id Id()
        {
            return this.id;
        }
        public Nombre Nombre()
        {
            return this.nombre;
        }
        public Cantidad Cantidad()
        {
            return this.cantidad;
        }
        public Categoria Categoria()
        {
            return this.categoria;
        }
    }
}
