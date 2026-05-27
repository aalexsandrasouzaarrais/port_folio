
/* Dada a fórmula do VALOR FUTURO (juros compostos a.m.) para cálcular investimento:   F = p * ( 1 + i ) ^n 
p= valor presente
i= taxa de juros
n= tempo a.m
f=valor final do investimento
*/
using System;
using System.Runtime.Serialization;
using System.Security.Cryptography;
namespace TestedeMesa2
{
    class Program
    {
        static void Main(string[] args)
        {

            double p;
            double i;
            double n;
            string tipon;
            double ra;
            double r;
            double rl;


            Console.WriteLine("Digite o valor do investimento em reais (R$):");
            p = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Qual a taxa de juros? em %");
            i = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Você quer investir em meses ou em anos?(meses/anos)");
            tipon = Console.ReadLine()?.ToLower() ?? "";

            Console.WriteLine("Quanto tempo você quer investir?");
            n = Convert.ToDouble(Console.ReadLine());

            if (tipon == "anos")

            {
                n = n * 12;
            }

            i = i / 100;
            r = p;
            ra = p;


            Console.WriteLine("===========================================================");
            Console.WriteLine("Mês| Taxa Juros|Rendimento|Rendi. Liquído| Renda Acumulada");
            Console.WriteLine("===========================================================");


            for (int m = 1; m <= n; m++)
            {
                r = r * (1 + i);
                rl = r - p;

                if (m == 1)
                {
                    ra = r;
                }
                else
                {
                    ra = ra + rl;

                }
                Console.WriteLine("Mês| Taxa Juros|Rendimento|Rendi. Liquído| Renda Acumulada");
                Console.WriteLine($"{m:00} | {i:P2} | {r:C2} |{rl:C2}| {ra:C2}|");
            }
            Console.WriteLine("===========================================================");



        }
    }
}


