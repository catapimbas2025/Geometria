using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometria.Plana.Contracts;

namespace Geometria.Plana.Services
{
    public class CircunferenciaService : ICircunferencia
    {
        public double CalcularAreaCircunferencia(double r)
        {
            return (3.14 * (r * r));
        }
    }
}
