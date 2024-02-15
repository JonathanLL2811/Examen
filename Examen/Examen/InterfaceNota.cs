using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    internal class InterfaceNota
    {

        public interface INota
        {
            double CalcularNotaFinal(double nota1, double nota2, double nota3);
            string MensajeNota(double notaFinal);
        }

    }
}
