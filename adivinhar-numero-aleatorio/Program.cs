using System;

namespace adivinhar_numero_aleatorio
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numeroAleatorio = new Random();
            int numInput=0;

            while (true)
            {
                int numeroCorreto = numeroAleatorio.Next(1, 10);
                Console.WriteLine("Número Aleatório: " + numeroCorreto.ToString());

                Console.WriteLine("Introduz um número: ");

                while (numInput != numeroCorreto)
                {
                    string numeroIntroduzido = Console.ReadLine();

                    if (!Int32.TryParse(numeroIntroduzido, out numInput))
                    {
                        Console.WriteLine("Introduz um número válido!");
                        continue;
                    }

                    // Outra maneira de fazer um IF , é utilizar um Operador Ternário " ? "
                    var condicao = numInput != numeroCorreto ? "O número introduzido está incorreto!\nIntroduz um número novo:" : "" ;
                    Console.WriteLine(condicao);
                    //if (numInput != numeroCorreto)
                    //{
                    //    Console.WriteLine("O número introduzido está incorreto!\nIntroduz um número novo: ");                        
                    //}
                }

                Console.WriteLine("\nIntroduziste o número correto!\n");
                Console.WriteLine("Desejas Continuar?\n1. Sim\n2. Não\n");
                Console.WriteLine("Opção: ");
                int opcao = Convert.ToInt32(Console.ReadLine());

                if (opcao == 1)
                {
                    continue;
                }
                else
                {
                    return;
                }
            }           

        }
    }
}
