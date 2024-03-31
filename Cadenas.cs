using System;

namespace Practico
{
    public class Cadenas
    {
        public static void Ejercicio11()
        {
            string cadena = "Hola buenas tardes";
            int cantidadPalabras = ContarPalabras(cadena);
            Console.WriteLine("\nEjercicios de la clase Cadenas del 1 al 5");
            Console.WriteLine("1. La cantidad de palabras en la cadena es: " + cantidadPalabras);
        }

        public static int ContarPalabras(string cadena)
        {
            // Se utiliza el método Split para dividir la cadena en palabras basándose en los espacios en blanco
            // y se devuelve la longitud del arreglo resultante.
            string[] palabras = cadena.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return palabras.Length;
        }
        public static void Ejercicio12()
        {
            string cadena = "Buenas tardes";
            string cadenaSinVocales = EliminarVocales(cadena);

            Console.WriteLine("2. La cadena sin vocales es: " + cadenaSinVocales);
        }

        public static string EliminarVocales(string cadena)
        {
            string vocales = "aeiouAEIOU";

            // Se recorre la cadena y se verifica si cada carácter es una vocal.
            // Si no es una vocal, se concatena a una nueva cadena.
            string nuevaCadena = "";
            foreach (char caracter in cadena)
            {
                if (!vocales.Contains(caracter))
                {
                    nuevaCadena += caracter;
                }
            }

            return nuevaCadena;
        }

        public static void Ejercicio13()
        {
            string cadena = "Esta es una prueba más";
            string palabraMasLarga = EncontrarPalabraMasLarga(cadena);

            Console.WriteLine("3. La palabra más larga en la cadena es: " + palabraMasLarga);
        }

        public static string EncontrarPalabraMasLarga(string cadena)
        {
            string[] palabras = cadena.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string palabraMasLarga = "";

            foreach (string palabra in palabras)
            {
                if (palabra.Length > palabraMasLarga.Length)
                {
                    palabraMasLarga = palabra;
                }
            }

            return palabraMasLarga;
        }

        public static void Ejercicio14()
        {
            string cadena = "Esta es una prueba más";
            string cadenaSinPrimerasLetras = EliminarPrimerasLetras(cadena);

            Console.WriteLine("4. La cadena sin las primeras letras de cada palabra es: " + cadenaSinPrimerasLetras);
        }

        public static string EliminarPrimerasLetras(string cadena)
        {
            string[] palabras = cadena.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < palabras.Length; i++)
            {
                string palabra = palabras[i];

                if (palabra.Length > 1)
                {
                    palabras[i] = palabra.Substring(1);
                }
                else
                {
                    palabras[i] = "";
                }
            }

            return string.Join(" ", palabras);
        }

        public static void Ejercicio15()
        {
            string cadena = "Esta es una prueba más";
            string cadenaInvertida = InvertirCadaPalabra(cadena);

            Console.WriteLine("5. La cadena con las palabras invertidas es: " + cadenaInvertida);
        }

        public static string InvertirCadaPalabra(string cadena)
        {
            string[] palabras = cadena.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < palabras.Length; i++)
            {
                char[] caracteres = palabras[i].ToCharArray();
                Array.Reverse(caracteres);
                palabras[i] = new string(caracteres);
            }

            return string.Join(" ", palabras);
        }

    }
}


