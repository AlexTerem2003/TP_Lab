using TDD_NUnit;

string testNumber;
bool flag = true;
while (flag)
{
    Logic logic = new Logic();
    int n = 0, n1, n2;
    string s, s1, s2;
    List<int> lst = new();

    Console.Write("\nВведите номер теста: ");
    testNumber = Console.ReadLine();

    switch (testNumber)
    {
        case "1":
            Console.Write("\nТЕСТ 1\n");
            Console.Write("Введите математическую операцию: ");
            s = Console.ReadLine();
            Console.Write("Введите число 1: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Введите число 2: ");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("РЕЗУЛЬТАТ");
            Console.WriteLine(logic.MathOperations(s, n1, n2));
            break;
        case "2":
            Console.Write("\nТЕСТ 2\n");
            Console.Write("Введите названия дня недели: ");
            s = Console.ReadLine();
            Console.WriteLine("РЕЗУЛЬТАТ");
            Console.WriteLine(logic.NumberOfDayOfWeek(s));
            break;
        case "3":
            Console.Write("\nТЕСТ 3\n");
            int k = 1;
            while (n != -1)
            {
                Console.Write($"Введите число {k}: ");
                n = int.Parse(Console.ReadLine());
                k++;
                if (n != -1) lst.Add(n);
            }
            Console.WriteLine("РЕЗУЛЬТАТ");
            Console.WriteLine(logic.CalculatePerimeter(lst));
            break;
        case "4":
            Console.Write("\nТЕСТ 4\n");
            Console.Write("Введите число 1: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Введите число 2: ");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("РЕЗУЛЬТАТ");
            Console.WriteLine(logic.SizeOfSumToString(n1, n2));
            break;
        case "5":
            Console.Write("\nТЕСТ 5\n");
            Console.Write("Введите имя: ");
            s1 = Console.ReadLine();
            Console.Write("Введите место: ");
            s2 = Console.ReadLine();
            Console.Write("Введите число посещений: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("РЕЗУЛЬТАТ");
            Console.WriteLine(logic.Greetings(s1, s2, n));
            break;
        case "6":
            Console.Write("\nТЕСТ 6\n");
            Console.Write("Введите кол-во человек: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Введите кол-во пицц: ");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("РЕЗУЛЬТАТ");
            Console.WriteLine(logic.IsThereEnoughPizza(n1, n2));
            break;
        case "7":
            Console.Write("\nТЕСТ 7\n");
            Console.Write("Введите ваш размер ноги: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Введите размер обуви: ");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("РЕЗУЛЬТАТ");
            Console.WriteLine(logic.FootAndShoesSizeAcceptability(n1, n2));
            break;
        default:
            flag = false;
            break;
    }
}