using System;

namespace Practico
{
    public class Numeros
    {
        public static void Ejercicio1()
        {
            int numero = 87423;
            int mayorDigito = ObtenerMayorDigito(numero);
            Console.WriteLine("Ejercicios de la clase Numeros del 1 al 5");
            Console.WriteLine("1. El mayor dígito de {0} es: {1}", numero, mayorDigito);
        }
           
        public static int ObtenerMayorDigito(int numero)
        {
            int mayorDigito = 0;

            while (numero != 0)
            {
                int digito = numero % 10;
                mayorDigito = Math.Max(digito, mayorDigito);
                numero /= 10;
            }

            return mayorDigito;
        }

        public static void Ejercicio2()
        {

            int numero = 87423;

            // Encuentra la suma de los dígitos pares
            int sumaDigitosPares = SumaDigitosPares(numero);

            // Imprime el resultado
            Console.WriteLine("2. La suma de los dígitos pares de " + numero + " es: " + sumaDigitosPares);
        }

        // Función para encontrar la suma de los dígitos pares de un número
        public static int SumaDigitosPares(int num)
        {
            int suma = 0;

            // Itera sobre cada dígito del número
            while (num > 0)
            {
                int digito = num % 10; // Obtiene el último dígito
                if (digito % 2 == 0) // Comprueba si el dígito es par
                {
                    suma += digito; // Suma el dígito par
                }
                num /= 10; // Elimina el último dígito
            }

            return suma;
        }

        public static void Ejercicio3()
        {
            int numero = 87423;

            int numeroConMayorDigitoAlFinal = LlevarMayorDigitoAlFinal(numero);

            Console.WriteLine("3. El número con el mayor dígito al final es: " + numeroConMayorDigitoAlFinal);
        }

        public static int LlevarMayorDigitoAlFinal(int numero)
        {
            int mayorDigito = -1;
            int numeroTemporal = numero;

            while (numeroTemporal != 0)
            {
                int digito = numeroTemporal % 10;

                if (digito > mayorDigito)
                {
                    mayorDigito = digito;
                }

                numeroTemporal /= 10;
            }

            int resultado = (numero * 10) + mayorDigito;

            return resultado;
        }

        public static void Ejercicio4()
        {
            int numero = 1237;

            bool estaOrdenado = VerificarOrden(numero);

            Console.WriteLine("4. El número está ordenado en sus dígitos " + estaOrdenado);
        }

        public static bool VerificarOrden(int numero)
        {
            int digitoAnterior = numero % 10;
            numero /= 10;

            bool ascendente = true;
            bool descendente = true;

            while (numero != 0 && (ascendente || descendente))
            {
                int digito = numero % 10;

                if (digito < digitoAnterior)
                {
                    ascendente = false;
                }
                else if (digito > digitoAnterior)
                {
                    descendente = false;
                }

                digitoAnterior = digito;
                numero /= 10;
            }

            return ascendente || descendente;
        }

        public static void Ejercicio5()
        {
            int numero = 3827435;

            int cantidadImparesAntesDePar = ContarImparesAntesDePar(numero);

            Console.WriteLine("5. La cantidad de dígitos impares antes de un dígito par es: " + cantidadImparesAntesDePar);
        }

        public static int ContarImparesAntesDePar(int numero)
        {
            int cantidadImpares = 0;
            bool encontradoPar = false;

            while (numero != 0 && !encontradoPar)
            {
                int digito = numero % 10;

                if (digito % 2 != 0)
                {
                    cantidadImpares++;
                }
                else
                {
                    encontradoPar = true;
                }

                numero /= 10;
            }

            return cantidadImpares;
        }
    }
}
