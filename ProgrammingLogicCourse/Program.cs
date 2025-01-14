using System;

namespace ProgrammingLogicCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tipos basicos de dados.
            byte n1 = 126; // vai de 0 a 255
            int n2 = 2147483647; // vai de -2.147.483.648 a 2.147.483.647
            long n3 = 1000000000; //  bits
            bool completo = false; // true ou false
            char genero = 'F'; // um unico caractere
            float n4 = 4.5f; // 32 bits
            double n5 = 4.5; // 64 bits
            string nome = "Maria"; // cadeia de caracteres
            object obj1 = "Alex Brown"; // aceita qualquer tipo de dado
            object obj2 = 4.5f; // aceita qualquer tipo de dado
            var n6 = 4.5; // o compilador infere o tipo

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(nome);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);
            Console.WriteLine(n6);

        }
    }
}