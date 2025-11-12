using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char genero = 'F';
            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";

            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo);
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais");
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais");


            Console.WriteLine("\n\n\n\n\n");


            Console.Write("Bom dia!");
            Console.WriteLine("Boa tarde!"); 
            Console.WriteLine("Boa noite!"); 
            Console.WriteLine("---------------");

            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo);

            //forma de controlar a quantidade de casas decimais mostradas no console, F2 = 2 casas decimais
            Console.WriteLine(saldo.ToString("F2"));

            Console.WriteLine(nome);

            //forma de desconsiderar formatação de paises, nesse caso estamos trocando a virgula como separador em numeros pelo ponto como separador
            //Necessario usar o "Using System.Globalization;"
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture)); 
        }
    }
}