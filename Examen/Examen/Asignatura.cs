using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public class Asignatura : Alumno
    {
        // Atributos adicionales
        public string NombreAsignatura { get; set; }
        public string Horario { get; set; }
        public string Docente { get; set; }

        // Implementación del método Imprimir
        public override void Imprimir()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Número de Cuenta: {NumeroCuenta}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Asignatura: {NombreAsignatura}");
            Console.WriteLine($"Horario: {Horario}");
            Console.WriteLine($"Docente: {Docente}");
        }
    }
}
