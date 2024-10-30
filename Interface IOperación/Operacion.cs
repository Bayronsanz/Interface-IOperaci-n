using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Interface_IOperación
{
    public class Operacion : IOperacion
    {
        public double N1;
        public double N2;

        public double Area()
        {
            return N1 * N2;
        }

        public double Tiempo()
        {
            return N1/N2;
        }

        public double perimetro()
        {
            return 4*N1;
        }

        public double PerimetroRectangulo()
        {
            return 2*(N1+N2);
        }

        public double Volumen()
        {
            return Math.Pow(N1, 3);
        }

        public void Imprimir()
        {
            Console.WriteLine();
            Console.WriteLine($"El area de un rectangulo es: {Area()} cm");
            Console.WriteLine($"El Tiempo es: {Tiempo()} Seg");
            Console.WriteLine($"El perimetro de un cuadrado es: {perimetro()} cm");
            Console.WriteLine($"El perimetro de un rectangulo es: {PerimetroRectangulo()} cm");
            Console.WriteLine($"El Volumen de un cubo es: {Volumen():N} cm");
        }
    }
}
