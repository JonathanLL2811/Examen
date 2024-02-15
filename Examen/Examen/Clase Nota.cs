using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Examen.InterfaceNota;

namespace Examen
{
    internal class Clase_Nota
    {
        public class Nota : INota
        {
            private double nota1;
            private double nota2;
            private double nota3;

            // Constructor con parámetros
            public Nota(double nota1, double nota2, double nota3)
            {
                this.nota1 = nota1;
                this.nota2 = nota2;
                this.nota3 = nota3;
            }

            // Constructor sin parámetros
            public Nota()
            {
                nota1 = 0;
                nota2 = 0;
                nota3 = 0;
            }

            // Implementación del método CalcularNotaFinal
            public double CalcularNotaFinal(double nota1, double nota2, double nota3)
            {
                return (nota1 + nota2 + nota3) ;
            }

            // Implementación del método MensajeNota
            public string MensajeNota(double notaFinal)
            {
                if (notaFinal < 60)
                    return "Reprobado";
                else if (notaFinal < 80)
                    return "Bueno";
                else if (notaFinal < 90)
                    return "Muy Bueno";
                else
                    return "Sobresaliente";
            }
        }

    }
}
