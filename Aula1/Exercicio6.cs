using System;

namespace Aula1{

    public class Exe06{

        const int VALOR_MAX = 20;
        const int TAMANHO_VETOR = 30;

        public static void OrdenarVetor(){

            int[] numeros = new int[TAMANHO_VETOR];

            Random random = new Random();
            //Popular o vetor com valores
            for( int i = 0; i < TAMANHO_VETOR; i++){
                numeros[i] = random.Next(VALOR_MAX);
            }

            //Imprime o vetor sem ordenação
            foreach(int numero in numeros){
                Console.Write($"{numero} ");
            }

            //Ordenar vetor com bubble sort
            bool troca = false;
            do{
                for(int i = 0; i < TAMANHO_VETOR - 1; i++ ){
                    if(numeros[i] > numeros[i + 1] ){
                        int aux = numeros[i];
                        numeros[i] = numeros[i + 1];
                        numeros[i + 1] = aux;
                        troca = true;
                    }else{
                        troca = false;
                    }
                }
            }while(troca);
            //Ordena o vetor automaticamente
            //Array.Sort(numeros);
            Console.WriteLine("");
            //Imprime o vetor ordenado
            foreach(int numero in numeros){
                Console.Write($"{numero} ");
            }

        }
    }

}