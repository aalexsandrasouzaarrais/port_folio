using System;
namespace TestedeMesa2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double p;      
            double i;        
            double n;       
            string tipon;    
            double r;        
            double rl;      
            double ra = 0;  
            string res;
            int mres = 0;
            double vres = 0;

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

            Console.WriteLine("Você quer fazer algum resgate? (sim/nao)");
            res = Console.ReadLine()?.ToLower() ?? "";
            if (res == "sim")
            {
                Console.WriteLine("Em qual mês você quer fazer o resgate?");
                mres = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Qual o valor que deseja resgatar? em reais (R$)");
                vres = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine("=================================================================================================================");
            Console.WriteLine($"{"Mês",-4}  | {"Taxa Juros",-10} | {"Rendimento",-11} | {"Rend. Líq.",-11} | {"Renda Acum.",-11} | {"Resgate",-10} |{"Saldo",-12}");
            Console.WriteLine("=================================================================================================================");

            r=p;
            for (int m = 1; m <= n; m++)
            {
                r = r * (1 + i);
                ra = r;
                rl = ra - p;
           
                double resgateDesteMes = 0;
                if (res == "sim" && m == mres)
                {
                    p = ra;
                    resgateDesteMes = vres;
                    r = r - resgateDesteMes;
                    p = r;  
                }

                Console.WriteLine($"{m:00}   | {i,-10:P2} | {r,-11:C2} | {rl,-11:C2} | {ra,-11:C2} |{resgateDesteMes,-10:C2} | {r,-12:C2}");
            }
            Console.WriteLine("=================================================================================================================");
        }
    }
}









