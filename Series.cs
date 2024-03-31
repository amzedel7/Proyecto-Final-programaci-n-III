using System;

namespace Practico
{
    public class Series
    {
        public static void Ejercicio6()
        {
            int n = 5;
            long fibonacci = CalcularFibonacci(n);
            Console.WriteLine("\nEjercicios de la clase Series del 1 al 5");
            Console.WriteLine("1. El quinto término de la serie de Fibonacci es: " + fibonacci);
        }

        public static long CalcularFibonacci(int n)
        {
            if (n <= 1)
            {
                return n;
            }

            long fibMinus2 = 0;
            long fibMinus1 = 1;
            long fibonacci = 0;

            for (int i = 3; i <= n; i++)
            {
                fibonacci = fibMinus2 + fibMinus1;
                fibMinus2 = fibMinus1;
                fibMinus1 = fibonacci;
            }

            return fibonacci;
        }


        public static void Ejercicio7()
        {
            int quintoTermino = ObtenerQuintoTermino();

            Console.WriteLine("2. El quinto término de la serie de números es: " + quintoTermino);
        }

        public static int ObtenerQuintoTermino()
        {
            int[] serie = { 1, 2, 3, 6, 7, 14, 15, 30, 31};

            if (serie.Length >= 5)
            {
                return serie[4];
            }
            else
            {
                // Manejar el caso en el que la serie no tenga suficientes términos
                throw new Exception("La serie no tiene suficientes términos para obtener el quinto término.");
            }
        }

        public static void Ejercicio8()
        {
            int suma = CalcularSuma();

            Console.WriteLine("3. La suma de los primeros cinco términos de la serie de números es: " + suma);
        }

        public static int CalcularSuma()
        {
            int[] serie = { 0, 2, 4, 6, 8, 10, 12, 14, 16 };
            int suma = 0;

            if (serie.Length >= 5)
            {
                for (int i = 0; i < 5; i++)   //modificamos 5 para consultar otra pocision 
                {
                    suma += serie[i];
                }
            }
            else
            {
                // Manejar el caso en el que la serie no tenga suficientes términos
                throw new Exception("La serie no tiene suficientes términos para calcular la suma.");
            }

            return suma;
        }


        public static void Ejercicio9()
        {
            // Definir la serie de números
            int[] serie = { 1, 3, 7, 15, 31, 63, 127, 255 };

            // Devolver el sexto término (índice 5)
            int sextoTermino = serie[5];

            Console.WriteLine($"4. El sexto término de la serie es: {sextoTermino}");
        }



        public static void Ejercicio10()
        {
            int[] serie = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int sumaPrimerosCincoPares = CalcularSumaPrimerosCincoPares(serie);

            Console.WriteLine("5. La suma de los primeros cinco términos pares de la serie de números es: " + sumaPrimerosCincoPares);
        }

        public static int CalcularSumaPrimerosCincoPares(int[] serie)
        {
            int suma = 0;
            int contadorPares = 0;

            foreach (int numero in serie)
            {
                if (numero % 2 == 0)
                {
                    suma += numero;
                    contadorPares++;

                    if (contadorPares == 5)
                    {
                        break;
                    }
                }
            }

            return suma;
        }

    }
}