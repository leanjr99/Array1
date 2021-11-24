using System;

namespace Array1
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.Write("Insira o tamanho do array: ");
             int size = Convert.ToInt32(Console.ReadLine());
             int[] arr = new int[size];

             Console.WriteLine("Insira {0} elementos no array", size);
             for(int i = 0; i< size; i++)
             {
                 arr[i] = Convert.ToInt32(Console.ReadLine());
             }
             Console.Write("\n Os elementos do array são: ");
             for (int i = 0; i< size; i++)
             {
                 Console.Write("{0} ", arr[i]);
             }
             Console.ReadLine();
         

            /*
            //Criação do array
            string[] carros;
            //inicialização com 3 valores
            carros = new string[3];
            //definição dos valores e posições
            carros[0] = "Palio";
            carros[1] = "Corsa";
            carros[2] =   "Gol";
            //verificação
            for(int i=0; i<3; i++)
            {
                //faz a contagem e escrita
                //i = contador de posição do array
                Console.WriteLine(carros[i].ToString());
            }

            */



            /* **********ARRAY BIDIMENSIONAL ******* */

            /*
            //declaração de array de duas dimensões
            //possui duas linhas e 2 colunas
            int[,] array = new int[2, 2];

            //Inicialização de cada posição da matriz
            array[0, 0] = 5;
            array[0, 1] = 4;
            array[1, 0] = 3;
            array[1, 1] = 2;

            //nesse tipo é necessário dois laços for
            //o primeiro laço percorre as linhas
            for (int i = 0; i < 2; i++)
            {
                //segundo laço percorre as colunas
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine(array[i, j].ToString());
                }
            }
            */
            /*
            int[] array = new int[2];
            array[0] = 1;
            array[1] = 2;

            foreach(int valor in array)
            {
                Console.WriteLine(valor.ToString());
            }
            */

        }
    }
}
