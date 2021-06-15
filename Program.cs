using System;

namespace Aula1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Variáveis
            var nome = "";
            var number = 1;
            var booleano = true;
            var numeroDecimal = 20.40;

            string nomeString;
            nomeString = "Dan Lustosa";

            int numero = 1;
            double numeroDouble = 20.10;

            bool boolean = true;
            boolean = false;

            DateTime dataHora = DateTime.Now;

            Console.WriteLine("nome: " + nome);
            Console.WriteLine("number: " + number);
            Console.WriteLine("booleano: " + booleano);
            Console.WriteLine("numeroDecimal: " + numeroDecimal);
            Console.WriteLine("nomeString: " + nomeString);
            Console.WriteLine("numero: " + numero);
            Console.WriteLine("numeroDouble: " + numeroDouble);
            Console.WriteLine("boolean: " + boolean);
            Console.WriteLine("dataHora: " + dataHora);


            ///////// Estrutura de condições e Operadores //////////////


            if (nomeString == "Dan Lustosa" || boolean == true)
            {
                Console.WriteLine("Bem vindo, professor");
                Console.WriteLine("Boa noite, professor");
            }
            else
                Console.WriteLine("Bem vindo, aluno");



            for (int i = 0; i <= 10; i = i + 1)
                Console.WriteLine(i);

             


        }
    }
}
