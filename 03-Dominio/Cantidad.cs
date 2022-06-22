using System;

namespace _03_Dominio
{
    public class Cantidad
    {
        private int value;
        public Cantidad(int cantidad)
        {
            this.ControlarNegativos(cantidad);
            this.value = cantidad;
        }

        private void ControlarNegativos(int cantidad)
        {
            if (cantidad < 0)
            {
                throw new Exception("La cantidad debe ser mayor a cero");
            }
        }

        public int Value()
        {
            return this.value;
        }
    }
}
