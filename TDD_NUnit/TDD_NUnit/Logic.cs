using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_NUnit
{
    public class Logic
    {
        public float MathOperations(string type, int num1, int num2)
        {
            float result = 0;
            switch(type)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        throw new DivideByZeroException(nameof(num2));
                    }
                    result = num1 / num2;
                    break;
            }
            return result;
        }

        public byte NumberOfDayOfWeek(string day)
        {
            switch (day)
            {
                case "Понедельник":
                    return 1;
                case "Вторник":
                    return 2;
                case "Среда":
                    return 3;
                case "Четверг":
                    return 4;
                case "Пятница":
                    return 5;
                case "Суббота":
                    return 6;
                case "Воскресенье":
                    return 7;
                default:
                    return 0;
            }
        }

        public int CalculatePerimeter(List<int> sides)
        {
            int result = 0;
            foreach (int side in sides)
            {
                result += side;
            }
            return result;
        }

        public int SizeOfSumToString(int a, int b)
        {
            int sum = a + b;
            return sum.ToString().Length;
        }

        public string Greetings(string name, string place, int visitCount)
        {
            return place + $" в {visitCount}" + "-й раз встречает Вас, " + name + "!";
        }

        public bool IsThereEnoughPizza(int peopleCount, int pizzaCount)
        {
            if (peopleCount <= pizzaCount * 2)
            {
                return true;
            }
            return false;
        }

        public string FootAndShoesSizeAcceptability(int footSize, int shoesSize)
        {
            if (footSize > shoesSize) return "Не лезет, собака!";
            else if (footSize == shoesSize) return "Ух.. Впритык...";
            else if (shoesSize - footSize == 1) return "Сойдёт!";
            else if (shoesSize - footSize == 2) return "Неплохо. Со вторыми носками пойдёт!";
            else return "На вырост сойдёт! Остаётся только превратиться в великана (-_ -)";

        }
    }
}
