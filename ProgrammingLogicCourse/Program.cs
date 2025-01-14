using System;

namespace ProgrammingLogicCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            // Saidas de dados
            int idade = 32;
            string nome = "João";
            double saldo = 10.35784;

            // Placeholders
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo);

            // Interpolação
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais");

            // Concatenação
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2") + " reais");

        }
    }
}