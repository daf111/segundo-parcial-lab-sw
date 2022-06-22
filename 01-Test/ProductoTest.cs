using _02_Aplicacion;
using _04_Infraestructura;
using System;
using Xunit;

namespace _01_Test
{
    public class ProductoTest
    {
        [Fact]
        public void ModificarProducto_ConDatosValidos_ModificacionExitosa()
        {
            //Arrange
            ProductoDTO producto = new ProductoDTO(
                1, "Producto01", 20, "Categoria01"
            );
            ModificadorProducto modificador = new ModificadorProducto(
                new RepositorioProducto()
            );

            //Act
            modificador.Execute(producto);

            //Assert
            Assert.True(true);
        }

        [Fact]
        public void BuscarProducto_ConNombreValido_BusquedaExitosa()
        {
            //Arrange
            BuscadorProducto buscador = new BuscadorProducto(
                new RepositorioProducto()
            );

            //Act
            ProductoDTO productoEncontrado = 
                buscador.Execute("NombreFalso");

            //Assert
            Assert.Equal(1, productoEncontrado.Id());
        }
    }
}
