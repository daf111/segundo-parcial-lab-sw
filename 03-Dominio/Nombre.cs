using System;

namespace _03_Dominio
{
    public class Nombre
    {
        private string value;
        public Nombre(string nombre)
        {
            this.ControlarLongitud(nombre);
            this.value = nombre;
        }

        private void ControlarLongitud(string nombre)
        {
            if (nombre.Length > 50)
            {
                throw new Exception("El nombre no puede ser mayor a 50 de longitud");
            }
        }

        public string Value()
        {
            return this.value;
        }
    }
}
