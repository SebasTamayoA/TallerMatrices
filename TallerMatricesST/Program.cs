using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerMatricesST
{
    internal class Program
    {
        public static void LlenarMatrizAleatoria(int[,] matriz)
        {
            Random random = new Random();
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = random.Next(1, 100);
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public static void RestarMatrices(int[,] matriz1, int[,] matriz2)
        {
            Console.WriteLine("La resta matricial es:");
            int[,] matriz3 = new int[matriz1.GetLength(0), matriz1.GetLength(1)];
            for (int i = 0; i < matriz1.GetLength(0); i++)
            {
                for (int j = 0; j < matriz1.GetLength(1); j++)
                {
                    matriz3[i, j] = matriz1[i, j] - matriz2[i, j];
                    Console.Write(matriz3[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public static void MatrizTranspuesta(int[,] matriz)
        {
            Console.WriteLine("La matriz transpuesta es:");
            int[,] matrizTranspuesta = new int[matriz.GetLength(0), matriz.GetLength(1)];
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matrizTranspuesta[i, j] = matriz[j, i];
                    Console.Write(matrizTranspuesta[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public static void MatrizImpares(int[,] matriz)
        {
            Console.WriteLine("La matriz de impares es:");
            string[,] matrizImpares = new string[matriz.GetLength(0), matriz.GetLength(1)];
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (matriz[i, j] % 2 == 0)
                    {
                        matrizImpares[i, j] = "-";
                    }
                    else
                    {
                        matrizImpares[i, j] = matriz[i, j].ToString();
                    }
                    Console.Write(matrizImpares[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public static void CantidadPares(int[,] matriz)
        {
            int count = 0;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (matriz[i, j] % 2 == 0)
                    {
                        count = count + 1;
                    }
                }
            }
            Console.WriteLine("La cantidad de numeros pares es: " + count);
            Console.WriteLine();
        }

        public static void BuscarEnMatriz(int[,] matriz)
        {
            Console.Write("Ingresar número a buscar: ");
            int buqueda = int.Parse(Console.ReadLine());
            bool aux = false;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (matriz[i, j] == buqueda)
                    {
                        Console.WriteLine("El número está en la posición: " + "[ " + i + "," + j + " ]");
                        aux = true;
                    }
                }
            }
            if (aux == false)
            {
                Console.WriteLine("El número no está en la matriz");
            }
            Console.WriteLine();
        }

        public static void EscalarPorMatriz(int[,] matriz)
        {
            Console.Write("Ingresar escalar: ");
            int num = int.Parse(Console.ReadLine());
            int[,] matrizEscalar = new int[matriz.GetLength(0), matriz.GetLength(1)];
            Console.WriteLine("Matriz por escalar: ");

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matrizEscalar[i, j] = matriz[i, j] * num;
                    Console.Write(matrizEscalar[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            // Ejercicio 1 restar matrices
            // Dadas 2 matrices con números aleatorios, realizar la resta de las matrices

            int[,] numeros1 = new int[5, 5];
            Console.WriteLine("Ejercicio 1:");
            Console.WriteLine("Matriz #1");
            LlenarMatrizAleatoria(numeros1);

            int[,] numeros2 = new int[5, 5];
            Console.WriteLine("Matriz #2");
            LlenarMatrizAleatoria(numeros2);
            RestarMatrices(numeros1, numeros2);

            Console.WriteLine(">===========================================");


            //===============================================================================

            // Ejercicio 2 Transpuesta de una matriz
            // Dada una matriz con números aleatorios, mostrar la transpuesta de la matriz
            int[,] numeros3 = new int[5, 5];
            Console.WriteLine("Ejercicio 2:");
            Console.WriteLine("Matriz original:");
            LlenarMatrizAleatoria(numeros3);
            MatrizTranspuesta(numeros3);
            Console.WriteLine(">===========================================");


            //===============================================================================

            // Ejercicio 3 
            //Dada una matriz con números aleatorios, mostrar por pantalla 
            //aquellos que son impares(aquellos que sean pares se mostraría un espacio en blanco ' ' o un guión '-')
            int[,] numeros4 = new int[5, 5];
            Console.WriteLine("Ejercicio 3:");
            Console.WriteLine("Matriz original:");
            LlenarMatrizAleatoria(numeros4);
            MatrizImpares(numeros4);
            Console.WriteLine(">===========================================");


            //===============================================================================

            // Ejercicio 4
            // Dada una matriz con números aleatorios, indicar la cantidad de números que son pares
            int[,] numeros5 = new int[5, 5];
            Console.WriteLine("Ejercicio 4:");
            Console.WriteLine("Matriz original:");
            LlenarMatrizAleatoria(numeros5);
            CantidadPares(numeros5);
            Console.WriteLine(">===========================================");

            //===============================================================================
            // Ejercicio 5 
            // Solicitar un número por teclado e indicar si el número se encuentra en la Matriz
            int[,] numeros6 = new int[5, 5];
            Console.WriteLine("Ejercicio 5:");
            Console.WriteLine("Matriz original:");
            LlenarMatrizAleatoria(numeros6);
            BuscarEnMatriz(numeros6);
            Console.WriteLine(">===========================================");


            //===============================================================================
            // Ejercicio 6
            // Solicitar un número por teclado y realizar la multiplicación escalar de ese número por la Matriz
            int[,] numeros7 = new int[5, 5];
            Console.WriteLine("Ejercicio 6:");
            Console.WriteLine("Matriz original:");
            LlenarMatrizAleatoria(numeros7);
            EscalarPorMatriz(numeros7);
            Console.ReadKey();

        }
    }
}
