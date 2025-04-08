using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometria.Plana.Contracts;

namespace Geometria.Plana.Services
{
    public class QuadradoService : IQuadrado
    {     
        public double CalcularAreaQuadrado(double ladox, double ladoy)
        {
            return ladox * ladoy;
        }

        public double CalculaPerimetroQuadrado(double ladox)
        {
            return 4 * ladox;
        }
    }
}
