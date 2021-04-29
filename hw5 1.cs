using System;

namespace hw_5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int s;
            Console.Write("size: ");
            s = Int32.Parse(Console.ReadLine());
            Pascaltriangle(s);
            Console.ReadLine();

        }
        public static void Pascaltriangle(int s)
        {
            int[,] Pascaltriangle = new int[s, s];
            int r, c;
            for (r = 0; r < s; r++)
                for (c = 0; c < s; c++) Pascaltriangle[r, c] = 0;

            Pascaltriangle[0, 0] = 1;
            Pascaltriangle[1, 0] = 1;
            Pascaltriangle[1, 1] = 1;
            
            for (r = 2; r < s; r++)
            {
                Pascaltriangle[r, 0] = 1;
                for (c = 1; c <= r; c++)
                {
                    Pascaltriangle[r, c] = Pascaltriangle[r - 1, c - 1] + Pascaltriangle[r - 1, c];
                }
            }
            for (r = 0; r < s; r++)
            {
                for (c = 0; c <= r; c++)
                {
                    Console.WriteLine("{0}", Pascaltriangle[r, c]);
                }
                Console.WriteLine();
            }
            for (s < 0) 
            {
                Console.WriteLine("Invalid Pascal’s triangle row number.");
            }
        }
    }
}
