using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    using System;

    // Clase abstracta Alumno
    public abstract class Alumno
    {
        // Atributos
        public string Nombre { get; set; }
        public string NumeroCuenta { get; set; }
        public string Email { get; set; }

        // Método abstracto Imprimir
        public abstract void Imprimir();
    }
}
