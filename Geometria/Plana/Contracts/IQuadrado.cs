using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria.Plana.Contracts
{
   public interface IQuadrado
    {
        double CalcularAreaQuadrado(double ladox, double ladoy);
        double CalculaPerimetroQuadrado(double ladox);
    }
}
