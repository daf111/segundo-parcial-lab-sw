using System;

namespace _03_Dominio
{
    public class Categoria
    {
        private string value;
        public Categoria(string nombre)
        {
            this.value = nombre;
        }

        public string Value()
        {
            return this.value;
        }
    }
}
