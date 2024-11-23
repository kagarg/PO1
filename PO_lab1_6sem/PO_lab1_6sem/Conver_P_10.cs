using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convertor
{
    public class Conver_P_10
    {
        //Преобразовать цифру в число.
        static double char_To_num(char ch)
        {
            if (ch >= 'A')
            {
                return ch switch
                {
                    'A' => 10,
                    'B' => 11,
                    'C' => 12,
                    'D' => 13,
                    'E' => 14,
                    'F' => 15,
                    _ => (double)0,
                };
                
            }
            int code = (int)ch - 48;
            return code;
        }
        //Преобразовать строку в число
        private static double convert(string P_num, int P, double weight)
        {
            double result = 0;
            foreach (char symbol in P_num)
            {
                double digit = char_To_num(symbol);
                result += digit * Math.Pow(P, weight);
                weight--;
            }
            return result;
        }

        //Преобразовать из с.сч. с основанием р 
        //в с.сч. с основанием 10.
        public static double dval(string P_num, int P)
        {
            int arg = 0;
            if (P_num[0] == '-') { arg++; }
            int counter = P_num.Length-1; // подсчитываем вес,чтобы передать в функцию convert
            string func_input = ""; // Заполняем строку чтобы передать ее в функцию convert

            for (int i = arg; i < P_num.Length; i++)
            {
                if ((P_num[i] != '.')) { func_input += P_num[i]; }
                else { counter = i - 1 - arg; }
            }
            double converted_number = convert(func_input, P, counter);
            if (arg == 1) { converted_number *= -1; }
            return converted_number;
        }
    }
}
