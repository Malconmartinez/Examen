using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public class Asignatura : Alumno, IAsignatura 
    {
        public int N1 { get; set; }
        public int N2 { get; set; }
        public int N3 { get; set; }
        public string NombreAsignatura { get; set; }
        public string Horario {  get; set; }
        public string NombreDocente { get; set; }
        public double CalcularNotaFinal()
        {
        return N1 + N2 + N3;
        }
        public double CalcularNotaFinal(int n1, int n2, int n3)
        {
        return n1 + n2 + n3;        
        }
        public string MensajeNotaFinal(double notaFinal)
        {
        if (notaFinal >= 0 && notaFinal < 60) return "Reprobado";
        if (notaFinal >= 60 && notaFinal < 80) return "Bueno";
        if (notaFinal >= 80 && notaFinal < 90) return "Muy Bueno";
        if (notaFinal >= 92 && notaFinal < 100) return "Sobresaliente";
        }

        public void Imprimir ()
        {
        double notaFinal1 = CalcularNotaFinal();
        double notaFinal2 = CalcularNotaFinal(N2, N2, N3);
        Console.WriteLine($"Alumno: {NombreAlumno}, Numero de cuenta: {NumeroCuenta}, Email: {Email}");
        Console.WriteLine($"Asignatura: {NombreAsignatura}, Docente: {NumeroDocente}, Horario: {Horario}");
        Console.WriteLine($"Nota Final(sin parametros): {notaFinal1} - {MensajeNotaFinal(notaFinal1)}");
        Console.WriteLine($"Nota Final (con parametros): {notaFinal2} - {MensajeNotaFinal(notaFinal2)}");
        }
    }
}
