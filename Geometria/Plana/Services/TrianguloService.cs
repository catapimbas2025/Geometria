using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometria.Plana.Contracts;

namespace Geometria.Plana.Services
{
   public class TrianguloService : ITriangulo
    {
        public double CalcularAreaTriangulo(double b, double a)
        {
            return (b * a) / 2;
        }
        public double CalcularPerimetroTriangulo(double b)
        { 
        return 3 * b;
        }


    }
}
