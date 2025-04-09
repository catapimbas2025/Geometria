using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometria.Plana.Services;

namespace Geometria.Test.Plana.Services
{
    public class CircunferenciaServiceTest
    {
        [Fact]
        public void VerificarAreaCircunferencia()
        {
            double r = 3;

            CircunferenciaService circunferencia = new CircunferenciaService();
            double resultado = circunferencia.CalcularAreaCircunferencia(r);
            Assert.Equal(28.26, resultado);


        }
    }
}
