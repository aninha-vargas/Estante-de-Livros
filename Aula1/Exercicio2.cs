using System;

namespace Aula1{

    public class Exe02{

        public static void ConverterMoedas(){

            double real, dolar, peso, euro;

            const double VALOR_DOLAR_ATUAL = 5.17;
            const double VALOR_EURO_ATUAL = 6.14;
            const double VALOR_PESO_ATUAL = 0.05;

            Console.WriteLine("Exercicio 2 ");
            Console.WriteLine("Digite o valor em real:  ");
            real =  Convert.ToDouble(Console.ReadLine());
            
            dolar = real / VALOR_DOLAR_ATUAL;
            peso = real / VALOR_PESO_ATUAL;
            euro = real / VALOR_EURO_ATUAL;

            Console.WriteLine($"Dolar: {dolar.ToString("C2")} ");
            Console.WriteLine($"Euro: {euro.ToString("C2")} ");
            Console.WriteLine($"Peso: {peso.ToString("C2")} ");
        }


    }

}