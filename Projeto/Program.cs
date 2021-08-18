using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Projeto
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello Word com C#");
            Console.WriteLine("Digite seu nome: ");
            string name = Console.ReadLine();
            Console.WriteLine("Digite sua idade: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-------------- ");
            //Nessas duas linhas de codigo ocorre o mesmo resultado porem a maneira de escrever
            Console.WriteLine($"Ola  { name }  sua idade é de: { age }" );
            Console.WriteLine($"Ola "  + name +  " sua idade é de:  " + age  );
        }

    }
}
