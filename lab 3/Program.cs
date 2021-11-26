using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace lab_3
{
    class Program
    {
        static double[,] X = { { 10, -5, -5 }, { -5, -5, 10 }, { 1.5, 1.5, 0 }, { 0, 0, 0 } };
        static double[] detX = new double[4];

        static double M(int i)
        {
            return X[i, 0] * 0.5 + X[i, 1] * 0.1 + X[i, 2] * 0.4;
        }

        static void U(int i)
        {
            X[i, 0] = Sqrt(X[i, 0] + 5) / 15; 
            X[i, 1] = Sqrt(X[i, 1] + 5) / 15;
            X[i, 2] = Sqrt(X[i, 2] + 5) / 15;
        }

        static double InvU(double M)
        {
            return 225*M*M - 5;
        }

        static void Main()
        {
            double[] spodiv_wins = new double[4];

            for(int i = 0; i < 4; i++)
            {
                spodiv_wins[i] = M(i);
            }

            for(int i=0; i<4; i++)
            {
                U(i);

                detX[i] = InvU(M(i));
            }

            double[] Premiya = new double[4];

            for(int i=0; i<4; i++)
            {
                Premiya[i] = spodiv_wins[i] - detX[i];
            }

            Console.WriteLine($"{Premiya[0]} {Premiya[1]} {Premiya[2]} {Premiya[3]} \n");

            double max = Premiya.Max();

            if(Premiya[0]==max)
            {
                Console.WriteLine($"Рiшення 1 є найкращим");
            }
            else if(Premiya[1] == max)
            {
                Console.WriteLine($"Рiшення 2 є найкращим");
            }
            else if(Premiya[2] == max)
            {
                Console.WriteLine($"Рiшення 3 є найкращим");
            }
            else
            {
                Console.WriteLine($"Рiшення 4 є найкращим");
            }

            Console.ReadKey();
        }
    }
}
