/*
    Разработать собственный структурный тип данных
    для хранения целочисленных коэффициентов A и B
    линейного уравнения A×X + B×Y = 0. в классе реали-
    зовать статический метод Parse(), которые принимает
    строку со значениями коэффициентов, разделенных
    запятой или пробелом.
*/
using System;

namespace CSharpHomeCase5_1
{
    class Program
    {
        public struct Coefficient
        {
            public int A, B;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("\nEnter two " +
                "coefficients of linear equation A and B." +
                "\nFormat: \"A,B\".");
            string line = Console.ReadLine();
            Coefficient k = new Coefficient();
            Parse(line, ref k.A, ref k.B);
            Console.WriteLine($"\nResult:\n" +
                $"{k.A}X + {k.B}Y = 0;");

            Console.ReadKey();
        }

        static void Parse(string data, ref int a, ref int b)
        {
            data = data.Trim();
            string data1, data2;
            int commaPlace = CommaCheck(data);
            data1 = data.Substring(0, commaPlace);
            data2 = data.Substring(commaPlace + 1,
                data.Length - commaPlace - 1);

            a = Int32.Parse(data1);
            b = Int32.Parse(data2);
        }

        static int CommaCheck(string data)
        {
            int i = 0;
            int commaPlace = -1;
            int commaQuantity = 0;
            foreach (char el in data)
            {
                if (el == ',')
                {
                    commaPlace = i;
                    commaQuantity++;
                }
                i++;
            }
            return commaPlace;
        }
    }
}
