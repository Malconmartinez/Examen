using Examen;

public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            Asignatura asignatura = new Asignatura();

            Console.WriteLine("Ingrese el nombre del alumno: ");
            asignatura.NombreAlumno = Console.ReadLine();

            Console.WriteLine("Ingrese el numero de cuenta: ");
            asignatura.NumeroCuenta = Console.ReadLine();

            Console.WriteLine("Ingrese el email: ");
            asignatura.Email = Console.ReadLine();

            Console.WriteLine("Ingrese el nombre de la asignatura: ");
            asignatura.NombreAsignatura = Console.ReadLine();

            Console.WriteLine("Ingrese el nombre del docente: ");
            asignatura.NombreDocente = Console.ReadLine();

            Console.WriteLine("Ingrese el horario de la clase: ");
            asignatura.Horario = Console.ReadLine();

            Console.WriteLine("Ingrese la nota del primer parcial (maximo 30): ");
            asignatura.N1 = int.Parse(Console.ReadLine());
            if (asignatura.N1 > 30) throw new ArgumentException("La nota del primer parcial no puede ser mayor a 30. ");

            Console.WriteLine("Ingrese la nota del segundo parcial (maximo 30): ");
            asignatura.N2 = int.Parse(Console.ReadLine());
            if (asignatura.N2 > 30) throw new ArgumentException("La nota del segundo parcial no puede ser mayor a 30. ");

            Console.WriteLine("Ingrese la nota del tercer parcial (maximo 40): ");
            asignatura.N3 = int.Parse(Console.ReadLine());
            if (asignatura.N3 > 40) throw new ArgumentException("La nota del tercer parcial no puede ser mayor a 40. ");

            asignatura.Imprimir();
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Entrada no valida. Por favor, ingrese valores numericos para las notas.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}