using System;

namespace bhaskara
{
    class Program
    {
        static void Main(string[] args)
        {
            double a=0;
            double b=0;
            double c=0;
            double d=0;
            double x1=0;
            double x2=0;

            Console.ForegroundColor=ConsoleColor.Blue;
            Console.WriteLine("---------------------------------------------------");
            Console.ResetColor();
            Console.WriteLine("Calculando as raízes de uma equação de segundo grau");
            Console.ForegroundColor=ConsoleColor.Blue;
            Console.WriteLine("---------------------------------------------------");
            Console.ResetColor();
            Console.WriteLine();

            Console.WriteLine("Digite os valores de A,B e C: ");
            Console.ForegroundColor=ConsoleColor.Blue;
            Console.WriteLine("------------------------------");
            Console.ResetColor();

            Console.Write("(A): ");
            Console.ForegroundColor=ConsoleColor.Blue;
            a=Convert.ToDouble(Console.ReadLine());
            Console.ResetColor();

            Console.Write("(B): ");
            Console.ForegroundColor=ConsoleColor.Blue;
            b=Convert.ToDouble(Console.ReadLine());
            Console.ResetColor();


            Console.Write("(C): ");
            Console.ForegroundColor=ConsoleColor.Blue;
            c=Convert.ToDouble(Console.ReadLine());
            Console.ResetColor();


            d=Math.Pow(b,2)-4*a*c;
            x1=(-b+ Math.Sqrt(d))/2*a;
            x2=(-b- Math.Sqrt(d))/2*a;
            


            if(d<0){
                Console.ForegroundColor=ConsoleColor.Red;
                Console.WriteLine("Como delta= "+d+", a equação não possui raízes reais!");
                Console.ResetColor();

            } else if (a==0){
                Console.ForegroundColor=ConsoleColor.Red;
                Console.WriteLine("Não é uma equação de segundo grau!");
                Console.ResetColor();

            } else {
                Console.ForegroundColor=ConsoleColor.Red;
                Console.WriteLine("X1 = "+x1+" e X2 = "+x2+". ");
                Console.ResetColor();

            }

        }
    }
}
