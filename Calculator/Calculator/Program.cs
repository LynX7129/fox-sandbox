using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Разработать консольное приложение для вычисления выражений.
На входе получаем строку типа [значение1] оператор [значение2]
Возможные операции  - +, -, *, /.
При попытке сложения двух строк “123”+”456” получаем “123456”, в остальных случаях выводим предупреждение.
Если строка имеет не подходящий формат – предупреждение.
На выходе результат операции (10 + 15 =25) */

namespace Calculator
{
    class Program
    {
        class Calculator
        {
            private bool operation = false;
            private bool isInt = false;
            string first = "";
            string second = "";
            string arOperation = "";

            public string[] Sort(string str)
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] != '+' && str[i] != '-' && str[i] != '*' && str[i] != '/' && operation == false)
                    {
                        first += str[i];
                    }
                    else
                    {
                        operation = true;
                        if (i + 1 < str.Length) second += str[i + 1];
                        if (arOperation == "" && (arOperation.Length < 1)) arOperation += str[i];
                    }
                }

                return new string[] { first, second, arOperation };
            }

            public void Calculation()
            {
                foreach (char symbol in first)
                    if (Char.IsNumber(symbol)) isInt = true;
                    else isInt = false;

                foreach (char symbol in second)
                    if (Char.IsNumber(symbol)) isInt = true;
                    else isInt = false;

                if (isInt)
                {
                    int parserOne, parserTwo;
                    double result;
                    first.Trim();
                    second.Trim();

                    Int32.TryParse(first, out parserOne);
                    Int32.TryParse(second, out parserTwo);

                    switch (arOperation[0])
                    {
                        case '+':
                            result = parserOne + parserTwo;
                            Console.WriteLine("Resulf of operation: {0} ", result);
                            break;
                        case '-':
                            result = parserOne - parserTwo;
                            Console.WriteLine("Resulf of operation: {0} ", result);
                            break;
                        case '/':
                            try
                            {
                                result = parserOne / parserTwo;
                            }
                            catch (DivideByZeroException e)
                            {
                                if (parserTwo == 0)
                                    Console.WriteLine("Divided by zero");
                            }

                            result = parserOne / parserTwo;
                            Console.WriteLine("Resulf of operation: {0} ", result);
                            break;

                        case '*':
                            result = parserOne * parserTwo;
                            Console.WriteLine("Resulf of operation: {0} ", result);
                            break;
                    }
                }
                else
                {
                    string stringResult = "";
                    switch (arOperation[0])
                    {
                        case '+':
                            stringResult += first + second;
                            Console.WriteLine("Resulf of operation: {0} ", stringResult);
                            break;
                        case '-':
                            Console.WriteLine("Wrong operation with strings");
                            break;
                        case '/':
                            Console.WriteLine("Wrong operation with strings");
                            break;
                        case '*':
                            Console.WriteLine("Wrong operation with strings");
                            break;

                    }
                }
            }


            static void Main(string[] args)
            {
                Console.Write("Write a string: ");
                Calculator check = new Calculator();
                string randomString = Console.ReadLine();
                check.Sort(randomString);
                check.Calculation();

                Console.ReadKey();
            }
        }
    }
}
