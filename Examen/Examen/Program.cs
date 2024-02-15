using Examen;
using static Examen.Clase_Nota;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Asignatura alumno = new Asignatura();

            Console.Write("Ingrese el nombre del alumno: ");
            alumno.Nombre = Console.ReadLine();

            Console.Write("Ingrese el número de cuenta: ");
            alumno.NumeroCuenta = Console.ReadLine();

            Console.Write("Ingrese el email del alumno: ");
            alumno.Email = Console.ReadLine();

            Console.Write("Ingrese el nombre de la asignatura: ");
            alumno.NombreAsignatura = Console.ReadLine();

            Console.Write("Ingrese el horario de la asignatura: ");
            alumno.Horario = Console.ReadLine();

            Console.Write("Ingrese el nombre del docente: ");
            alumno.Docente = Console.ReadLine();


            Console.WriteLine("*************************************************");
            Console.WriteLine("\nIngrese las notas parciales:");


            Console.Write("Nota Parcial 1: ");
            double nota1 = Convert.ToDouble(Console.ReadLine());
            if (nota1 < 0 || nota1 > 30)
                throw new ArgumentException("Nota fuera de rango. Debe estar entre 0 y 30.");

            Console.Write("Nota Parcial 2: ");
            double nota2 = Convert.ToDouble(Console.ReadLine());
            if (nota2 < 0 || nota2 > 30)
                throw new ArgumentException("Nota fuera de rango. Debe estar entre 0 y 30.");

            Console.Write("Nota Parcial 3: ");
            double nota3 = Convert.ToDouble(Console.ReadLine());
            if (nota3 < 0 || nota3 > 40)
                throw new ArgumentException("Nota fuera de rango. Debe estar entre 0 y 40.");

            Nota notas = new Nota();
            double notaFinal = notas.CalcularNotaFinal(nota1, nota2, nota3);
            string mensajeNota = notas.MensajeNota(notaFinal);

            Console.WriteLine("*************************************************");
            alumno.Imprimir();
            Console.WriteLine($"\nNota Final: {notaFinal}");
            Console.WriteLine($"{mensajeNota}");


        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Ingrese un valor numérico válido para las notas.");
        }
        catch (ArgumentException e)
        {
            Console.WriteLine($"Error: {e.Message}");
        }
        catch (Exception)
        {
            Console.WriteLine("Error inesperado.");
        }
    }
}