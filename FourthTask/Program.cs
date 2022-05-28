using System;

namespace FourthTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите последовательность целых" +  " чисел, разделенных запятыми:");
            string input = Console.ReadLine();
            Console.WriteLine();
            char[] dividers = { '1' , '2' , '3' };
            string[] segments = input.Split(dividers);
            int sum = 0;
            foreach(string s in segments)
            {
                if (s.Length > 0)
                {
                    if (IsAllDigits(s))
                    {
                        int num = 0;
                        if (Int32.TryParse(s, out num))
                        {
                            Console.WriteLine("Oчepeднoe число = { 0 }",num);
                            // Добазляем полученное число в сумму 
                            sum += num;
                        }
                    }
                }
            }
            Console.WriteLine("Сумма = { 0 }", sum);
            Console.WriteLine("Нажмите <Enter> для " + "завершения программы ... ");
            Console.Read();
        }
        public static bool IsAllDigits(string raw)
        {
            string s = raw.Trim(); // Игнорируем пробельные символы 
            if (s.Length == 0)
            {
                return false;
            }
            for (int index = 0; index < s.Length; index++)
            {
                if (Char.IsDigit(s[index]) == false)
                {
                    return false;
                }
            }
            return true;
        }


    }
}
