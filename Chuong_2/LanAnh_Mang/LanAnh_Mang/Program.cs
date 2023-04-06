using System;
using static System.Console;

namespace Exercise03
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 15 == 0)
                {
                    Write("Chia het cho 3 và 5");
                }
                else if (i % 5 == 0)
                {
                    Write("Chia het cho 5");
                }
                else if (i % 3 == 0)
                {
                    Write("Chia het cho 3");
                }
                else
                {
                    Write(i);
                }

                // đặt dấu phẩy và dấu cách sau mỗi số trừ 100 
                if (i < 100) Write(", ");

                // viết xuống dòng sau mỗi mười số
                if (i % 10 == 0) WriteLine();
            }
            WriteLine();
        }
    }
}