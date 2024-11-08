

namespace Examen
{
    public interface IAsignatura
    {
        public double CalcularNotaFinal ();
        public double CalcularPeriodo(int n1, int n2, int n3);
        public string MensajeNotaFinal(double notaFinal);
        public void Imprimir();
    }
}
