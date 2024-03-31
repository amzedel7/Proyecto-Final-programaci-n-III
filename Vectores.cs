using System;

namespace Practico
{
    public class Vectores
    {
        public static void Ejercicio16()
        {
            int[] vector = { 2, 4, 5, 12, 23, 54, 3, 34, 6 };
            int cantidadPares = ContarNumerosPares(vector);
            Console.WriteLine("\nEjercicios de la clase Vectores del 1 al 5");
            Console.WriteLine("1. La cantidad de números pares en el vector es: " + cantidadPares);
        }

        public static int ContarNumerosPares(int[] vector)
        {
            int cantidadPares = 0;

            foreach (int numero in vector)
            {
                if (numero % 2 == 0)
                {
                    cantidadPares++;
                }
            }
            return cantidadPares;
        }


        public static void Ejercicio17()
        {
            int[] vector = { 5, 2, 9, 1, 3, 6, 8, 4, 7 };
            Console.WriteLine("2. Vector original:");
            ImprimirVector(vector);

            OrdenarVector(vector);

            Console.WriteLine("Vector ordenado:");
            ImprimirVector(vector);
        }

        public static void OrdenarVector(int[] vector)
        {
            int[] tempArray = new int[vector.Length];
            MergeSortRecursive(vector, tempArray, 0, vector.Length - 1);
        }

        private static void MergeSortRecursive(int[] vector, int[] tempArray, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;

                MergeSortRecursive(vector, tempArray, left, middle);
                MergeSortRecursive(vector, tempArray, middle + 1, right);

                Merge(vector, tempArray, left, middle, right);
            }
        }

        private static void Merge(int[] vector, int[] tempArray, int left, int middle, int right)
        {
            int i = left;
            int j = middle + 1;
            int k = left;

            while (i <= middle && j <= right)
            {
                if (vector[i] <= vector[j])
                {
                    tempArray[k] = vector[i];
                    i++;
                }
                else
                {
                    tempArray[k] = vector[j];
                    j++;
                }
                k++;
            }

            while (i <= middle)
            {
                tempArray[k] = vector[i];
                i++;
                k++;
            }

            while (j <= right)
            {
                tempArray[k] = vector[j];
                j++;
                k++;
            }

            for (int m = left; m <= right; m++)
            {
                vector[m] = tempArray[m];
            }
        }

        public static void ImprimirVector(int[] vector)
        {
            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write(vector[i] + " ");
            }
            Console.WriteLine();
        }




        public static void Ejercicio18()
        {
            int[] vector = { 5, 2, 9, 1, 3, 6, 8, 4, 7 };
            Console.WriteLine("3. Vector original:");
            ImprimirVectorSort(vector);

            OrdenarVectorSort(vector);

            Console.WriteLine("Vector ordenado:");
            ImprimirVectorSort(vector);
        }

        public static void OrdenarVectorSort(int[] vector)
        {
            int n = vector.Length;

            for (int i = 1; i < n; i++)
            {
                int valorActual = vector[i];
                int j = i - 1;

                while (j >= 0 && vector[j] > valorActual)
                {
                    vector[j + 1] = vector[j];
                    j--;
                }

                vector[j + 1] = valorActual;
            }
        }

        public static void ImprimirVectorSort(int[] vector)
        {
            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write(vector[i] + " ");
            }
            Console.WriteLine();
        }


        public static void Ejercicio19()
        {
            int[] vector = { 2, 5, 65, 23, 45, 2 , 13, 45, 61 };
            Console.WriteLine("4. Vector original:");
            ImprimirVectorDato(vector);

            int valorAEliminar = 2;
            int[] vectorSinElemento = EliminarElementoVector(vector, valorAEliminar);

            Console.WriteLine($"Vector sin el elemento {valorAEliminar}:");
            ImprimirVectorDato(vectorSinElemento);
        }

        public static int[] EliminarElementoVector(int[] vector, int valorAEliminar)
        {
            int ocurrencias = 0;

            // Contar las ocurrencias del valor a eliminar
            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i] == valorAEliminar)
                {
                    ocurrencias++;
                }
            }

            // Crear un nuevo vector sin las ocurrencias del valor a eliminar
            int[] vectorSinElemento = new int[vector.Length - ocurrencias];
            int index = 0;

            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i] != valorAEliminar)
                {
                    vectorSinElemento[index] = vector[i];
                    index++;
                }
            }

            return vectorSinElemento;
        }

        public static void ImprimirVectorDato(int[] vector)
        {
            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write(vector[i] + " ");
            }
            Console.WriteLine();
        }


        public static void Ejercicio20()
        {
            int[] vector = { 2, 5, 65, 23, 45, 2, 13, 45 };
            Console.WriteLine("5. Vector original:");
            ImprimirVectorInvertido(vector);

            int a = 2; // Inicio de la parte a invertir
            int b = 6; // Fin de la parte a invertir

            InvertirParte(vector, a, b);

            Console.WriteLine($"Vector con la parte invertida entre {a} y {b}:");
            ImprimirVectorInvertido(vector);
        }

        public static void InvertirParte(int[] vector, int a, int b)
        {
            if (a < 0 || b >= vector.Length || a >= b)
            {
                Console.WriteLine("Las posiciones a y b son inválidas.");
                return;
            }

            while (a < b)
            {
                int temp = vector[a];
                vector[a] = vector[b];
                vector[b] = temp;
                a++;
                b--;
            }
        }

        public static void ImprimirVectorInvertido(int[] vector)
        {
            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write(vector[i] + " ");
            }
            Console.WriteLine();
        }
    }
}



