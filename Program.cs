using System;

namespace EjercicioAbstraccion
{
    public abstract class Matematicas
    {
        public abstract double CalcularAreaCirculo(double radio);
        public abstract double CalcularAreaRectangulo(double largo, double ancho);
        public abstract double CalcularHipotenusa(double ladoA, double ladoB);
        public abstract double CalcularPromedio(double[] numeros);

        public void Imprimir(string mensaje)
        {
            Console.WriteLine(mensaje);
        }
    }

    public class OperacionesMatematicas : Matematicas
    {
        public override double CalcularAreaCirculo(double radio)
        {
            return Math.PI * Math.Pow(radio, 2);
        }

        public override double CalcularAreaRectangulo(double largo, double ancho)
        {
            return largo * ancho;
        }

        public override double CalcularHipotenusa(double ladoA, double ladoB)
        {
            return Math.Sqrt(Math.Pow(ladoA, 2) + Math.Pow(ladoB, 2));
        }

        public override double CalcularPromedio(double[] numeros)
        {
            double suma = 0;
            foreach (double numero in numeros)
            {
                suma += numero;
            }
            return suma / numeros.Length;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            OperacionesMatematicas operaciones = new OperacionesMatematicas();

            Console.Write("Ingrese el radio del círculo: ");
            double radio = Convert.ToDouble(Console.ReadLine());
            double areaCirculo = operaciones.CalcularAreaCirculo(radio);
            operaciones.Imprimir($"El área del círculo es: {areaCirculo}");

            Console.Write("Ingrese el largo del rectángulo: ");
            double largo = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese el ancho del rectángulo: ");
            double ancho = Convert.ToDouble(Console.ReadLine());
            double areaRectangulo = operaciones.CalcularAreaRectangulo(largo, ancho);
            operaciones.Imprimir($"El área del rectángulo es: {areaRectangulo}");

            Console.Write("Ingrese el lado A del triángulo: ");
            double ladoA = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese el lado B del triángulo: ");
            double ladoB = Convert.ToDouble(Console.ReadLine());
            double hipotenusa = operaciones.CalcularHipotenusa(ladoA, ladoB);
            operaciones.Imprimir($"La hipotenusa del triángulo es: {hipotenusa}");

            Console.Write("Ingrese la cantidad de números para calcular el promedio: ");
            int cantidad = Convert.ToInt32(Console.ReadLine());
            double[] numeros = new double[cantidad];
            for (int i = 0; i < cantidad; i++)
            {
                Console.Write($"Ingrese el número {i + 1}: ");
                numeros[i] = Convert.ToDouble(Console.ReadLine());
            }
            double promedio = operaciones.CalcularPromedio(numeros);
            operaciones.Imprimir($"El promedio de los números ingresados es: {promedio}");
        }
    }
}
