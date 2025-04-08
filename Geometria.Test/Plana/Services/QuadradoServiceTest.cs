using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometria.Plana.Services;

namespace Geometria.Test.Plana.Services
{
    
    public class QuadradoServiceTest
    {
        [Fact]
        public void VerificarAreaQuadrado()
        {
            //Arrange
            double ladox = 10.0;
            double ladoy = 10.0;
            QuadradoService quadrado = new QuadradoService();
            //Act
            double resultado = quadrado.CalcularAreaQuadrado(ladox, ladoy);
            //Assert
            Assert.Equal(100.0, resultado);
        }

        [Fact]
        public void VerificarPerimetroQuadrado()
        {
            //Arrange
            double ladox = 10.0;          
            QuadradoService quadrado = new QuadradoService();
            //Act
            double resultado = quadrado.CalculaPerimetroQuadrado(ladox);
            //Assert
            Assert.Equal(40.0, resultado);
        }
    }
}
