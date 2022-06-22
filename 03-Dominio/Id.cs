using System;

namespace _03_Dominio
{
    public class Id
    {
        private int value;
        public Id(int cantidad)
        {
            this.ControlarNegativos(cantidad);
            this.value = cantidad;
        }

        private void ControlarNegativos(int cantidad)
        {
            if (cantidad < 0)
            {
                throw new Exception("El ID debe ser mayor a cero");
            }
        }

        public int Value()
        {
            return this.value;
        }
    }
}
