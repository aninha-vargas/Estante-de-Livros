using System;
// Namespace seria a pasta que vou usar para acessar alguns arquivos
namespace Aula1 
{
    public class Exe01{
        //Metodoas devem começar com verbo
        public static void Renderizar(){

            int largura, altura;

            Console.WriteLine("Digite a largura: ");
            largura =  Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a altura: ");
            altura =  Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Área: {CalcularAreaRetangulo(largura, altura)} ");
        }

        public static int CalcularAreaRetangulo( int largura, int altura){
            return largura * altura;
        }
    }
}