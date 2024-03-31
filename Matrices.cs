using System;

namespace Practico
{
    public class Matrices
    {
        public static void Ejercicio21()
        {

            int n = 5;
            int[,] matriz = new int[n, n];

            LlenarMatrizEscalonadaDescendente(matriz, n);
            Console.WriteLine("\nEjercicios de la clase Matrices del 1 al 5");
            Console.WriteLine("1. Matriz escalonada inferior descendente:");

            ImprimirMatriz(matriz);
        }

        public static void LlenarMatrizEscalonadaDescendente(int[,] matriz, int n)
        {
            int valor = n * (n + 1) / 2;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    matriz[i, j] = valor;
                    valor--;
                }
            }
        }

        public static void ImprimirMatriz(int[,] matriz)
        {
            int n = matriz.GetLength(0);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        public static void Ejercicio22()
        {
            int n = 5;
            int[,] matriz = new int[n, n];

            LlenarMatrizEscalonadaAscendenteArribaAbajo(matriz, n);

            Console.WriteLine("2. Matriz escalonada inferior ascendente:");

            ImprimirMatrizAscen(matriz);
        }

        public static void LlenarMatrizEscalonadaAscendenteArribaAbajo(int[,] matriz, int n)
        {
            int valor = 1;

            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    matriz[j, i] = valor;
                    valor++;
                }
            }
        }

        public static void ImprimirMatrizAscen(int[,] matriz)
        {
            int n = matriz.GetLength(0);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        public static void Ejercicio23()
        {
            int filas = 5;
            int columnas = 4;

            int[,] matriz = new int[filas, columnas];

            LlenarMatrizSerpienteAscendenteArribaAbajo(matriz, filas, columnas);

            Console.WriteLine("3. Matriz serpiente ascendente:");

            ImprimirMatrizSerpiente(matriz);
        }

        public static void LlenarMatrizSerpienteAscendenteArribaAbajo(int[,] matriz, int filas, int columnas)
        {
            int valor = 1;
            int filaInicio = 0;
            int filaFin = filas - 1;

            for (int columna = 0; columna < columnas; columna++)
            {
                if (columna % 2 == 0) // Movimiento hacia abajo
                {
                    for (int fila = filaInicio; fila <= filaFin; fila++)
                    {
                        matriz[fila, columna] = valor;
                        valor++;
                    }
                }
                else // Movimiento hacia arriba
                {
                    for (int fila = filaFin; fila >= filaInicio; fila--)
                    {
                        matriz[fila, columna] = valor;
                        valor++;
                    }
                }
            }
        }

        public static void ImprimirMatrizSerpiente(int[,] matriz)
        {
            int filas = matriz.GetLength(0);
            int columnas = matriz.GetLength(1);

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        public static void Ejercicio24()
        {
            int n = 5;
            int[,] matriz = GenerarCuadradoMagico(n);

            Console.WriteLine("4. Cuadrado Mágico:");
            ImprimirMatrizCuadrado(matriz);
        }

        public static int[,] GenerarCuadradoMagico(int n)
        {
            int[,] matriz = new int[n, n];
            int fila = n - 1;
            int columna = n / 2;

            for (int valor = 1; valor <= n * n; valor++)
            {
                matriz[fila, columna] = valor;
                fila = (fila + 1) % n;
                columna = (columna + 1) % n;

                if (matriz[fila, columna] != 0)
                {
                    fila = (fila - 2 + n) % n;
                    columna = (columna - 1 + n) % n;
                }
            }

            return matriz;
        }

        public static void ImprimirMatrizCuadrado(int[,] matriz)
        {
            int filas = matriz.GetLength(0);
            int columnas = matriz.GetLength(1);

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}