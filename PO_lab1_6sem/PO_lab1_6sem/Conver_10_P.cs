using System.Globalization;

namespace Convertor
{
    class Conver_10_P
    {
        //Преобразовать целое в символ.
        public static char int_to_Char(int n)
        {
            if (n > 9)
            {
                switch (n)
                {
                    case 10:
                        return 'A';
                    case 11:
                        return 'B';
                    case 12:
                        return 'C';
                    case 13:
                        return 'D';
                    case 14:
                        return 'E';
                    case 15:
                        return 'F';
                }
            }
            int code = n + 48;
            char ans = (char)code;
            return ans;
        }
        //Преобразовать десятичное целое в с.сч. с основанием р.
        public static string int_to_P(int n, int p)
        {
            if (p < 2 || p > 16)
                throw new ArgumentException("Base must be between 2 and 16.");

            int sign = 1;
            if (n < 0) { n *= -1; sign = -1; } // проверяем знак и работаем с числом без него
            Stack<string> whole_stack = new Stack<string>();
            int whole_part = (int)n;

            while (whole_part >= p)
            {
                int item = whole_part % p;
                char check = int_to_Char(item);
                whole_stack.Push(check.ToString());
                whole_part /= p;

            }
            whole_stack.Push(int_to_Char(whole_part).ToString());
            string answer = "";
            while (whole_stack.Count() != 0)
            {
                answer += whole_stack.Pop();
            }
            if (sign == -1)
            {
                answer = "-" + answer;
            }
            return answer;
        }
        //Преобразовать десятичную дробь в с.сч. с основанием р.
        public static string flt_to_P(double n, int p, int c)
        {
            if (p < 2 || p > 16)
                throw new ArgumentException("Base must be between 2 and 16.");

            if (n < 0) { n *= -1; }
            int whole_part = (int)n;
            double fraction = Math.Abs(n - whole_part);
            string fraction_stack = "";
            for (int i = 0; i < c; i++)
            {
                double mult = fraction * p; // произведение десятичной части числа на сс
                int buffer = (int)mult; // выделяем целую часть результата
                char converted_buffer = int_to_Char(buffer);
                fraction = mult - buffer; // выделяем десятичную часть результата
                fraction_stack += converted_buffer.ToString();// складываем в строку целую часть. Десятичная нужна для след. итерации
            }
            string result =  "." + fraction_stack;
            return result;
        }
        //Преобразовать десятичное 
        //действительное число в с.сч. с осн. р.
        public static string Do(double n, int p, int c)
        {
            int whole_part = (int)n;
            string whole_string = int_to_P(whole_part, p);
            string result = "";
            if (n != (double)whole_part)
            {
                string fraction_string = flt_to_P(n, p, c);
                result = whole_string + fraction_string;
            }
            else
            {
                result = whole_string;
            }
            
            return result;
        }
    }
}