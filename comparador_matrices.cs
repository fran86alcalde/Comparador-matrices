using System;

namespace Comparador_Matrices
{
    class Program
    {
        static void Main(string[] args)
        {
            //iniciamos variables

            int filaMatrizA = 0;
            int coluMatrizA = 0;
            int coluMatrizB = 0;
            int filaMatrizB = 0;
            string valoresA = "";
            string valoresB = "";


            //solicitamos que introduzan los datos y los leemos
            //primero tamaño de las matrices

            Console.WriteLine("ILERNA Pac09 UF1 Programación Francisco Alcalde Rodriguez \n");

            Console.WriteLine("Introduce numero de filas de la matriz A");
            filaMatrizA = int.Parse(Console.ReadLine());


            Console.WriteLine();

            Console.WriteLine("A continuación introduce el número de columnas de la matriz A");
            coluMatrizA = int.Parse(Console.ReadLine());
            Console.WriteLine();


            Console.WriteLine("Introduce numero de filas de la matriz B");
            filaMatrizB = int.Parse(Console.ReadLine());
            Console.WriteLine();


            Console.WriteLine("A continuación introduce el número de columnas de la matriz B");
            coluMatrizB = int.Parse(Console.ReadLine());
            Console.WriteLine();

            //declaramos las matrices ahora que ya tenemos declaradas las variables por el usuario

            string[,] MatrizA = new string[filaMatrizA, coluMatrizA];
            string[,] MatrizB = new string[filaMatrizB, coluMatrizB];

            //ahora los datos de las matrices, recorriendolas con método for

            for (int i = 0; i < MatrizA.GetLength(0); i++)
            {
                for (int j = 0; j < MatrizA.GetLength(1); j++)
                {
                    Console.WriteLine("Introduce el elemento de la Matriz A para la posición {0},{1}:", i, j);
                    string dato = Console.ReadLine();
                    MatrizA[i, j] = dato;
                    valoresA = valoresA + dato;
                }

            }

            Console.WriteLine();

            for (int i = 0; i < MatrizB.GetLength(0); i++)
            {
                for (int j = 0; j < MatrizB.GetLength(1); j++)
                {
                    Console.WriteLine("Introduce el elemento de la Matriz B para la posición {0},{1}:", i, j);
                    string dato = Console.ReadLine();
                    MatrizB[i, j] = dato;
                    valoresB = valoresB + dato;
                }

            }


            //imprimimos en pantalla

            Console.WriteLine("Matriz A:");

            for (int i = 0; i < MatrizA.GetLength(0); i++)
            {
                for (int j = 0; j < MatrizA.GetLength(1); j++)
                {

                    Console.Write(MatrizA[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            Console.WriteLine("Matriz B:");

            for (int i = 0; i < MatrizB.GetLength(0); i++)
            {
                for (int j = 0; j < MatrizB.GetLength(1); j++)
                {
                    Console.Write(MatrizB[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            //consideramos si las matrices pueden ser comparadas y las comparamos

            bool matricesiguales = valoresA == valoresB;
            
            if ((filaMatrizA == filaMatrizB) && (coluMatrizA == coluMatrizB))

            {
                Console.WriteLine("Las matrices pueden ser comparadas");
                


                if (matricesiguales == true)
                {

                    Console.WriteLine("Las matrices son iguales");
                    Console.ReadKey();

                }
                else
                {

                    Console.WriteLine("Las matrices no son iguales");
                    Console.ReadKey();

                }

            }


            else

                Console.WriteLine("Las matrices no pueden ser comparadas");

        }
    }
}
