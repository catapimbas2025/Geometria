using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometria.Plana.Contracts;
using Geometria.Plana.Services;

namespace Geometria.Test.Plana.Services
{
    public class TrianguloServiceTest
    {
     [Fact]
     public void VerificarAreaTriangulo()
        {
            //Arrange
            double b = 10.0;
            double a = 10.0;
            TrianguloService triangulo = new TrianguloService();
            //Act
            double resultado = triangulo.CalcularAreaTriangulo(b, a);
            //Assert
            Assert.Equal(50.0, resultado);
        }
        [Fact]
        public void VerificarPerimetroTriangulo()
        {
            //Arrange
            double b = 10.0;           
            TrianguloService triangulo = new TrianguloService();
            //Act
            double resultado = triangulo.CalcularPerimetroTriangulo(b);
            //Assert
            Assert.Equal(30.0, resultado);
        }
    }
}
