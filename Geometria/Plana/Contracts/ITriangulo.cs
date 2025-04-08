using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria.Plana.Contracts
{
    public interface ITriangulo
    {
        double CalcularAreaTriangulo(double b, double a);
        double CalcularPerimetroTriangulo(double b);
    }
}
