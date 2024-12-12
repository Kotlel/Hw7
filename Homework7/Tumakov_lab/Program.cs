using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Tumakov_lab8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task8_1();
            //Task8_2();
            //Task8_3();
            //Task8_4();
        }
        static decimal checkingdecimal()
        {
            decimal x;
            while (!decimal.TryParse(Console.ReadLine(), out x))
                Console.Write("Неверный ввод!\nПовторите: ");
            return x;
        }
        static int checkingint()
        {
            int x;
            while (!int.TryParse(Console.ReadLine(), out x))
                Console.Write("Неверный ввод!\nПовторите: ");
            return x;
        }
        static void Task8_1()
        {
            Console.WriteLine("Упражнение 8.1");
            decimal myBalance;
            decimal myFriendBalance;
            Console.WriteLine("Введите ваш баланс");
            myBalance = checkingdecimal();
            Console.WriteLine("Введите баланс друга");
            myFriendBalance = checkingdecimal();
            BankAccount myAccount = new BankAccount(myBalance, AccountType.Current);
            BankAccount myFriendAccount = new BankAccount(myFriendBalance, AccountType.Current);
            Console.WriteLine(myAccount.GetFullInfo());
            Console.WriteLine(myFriendAccount.GetFullInfo());
            Console.WriteLine("Введите сумму перевода");
            decimal yourAmount;
            yourAmount = checkingdecimal();
            myAccount.MoneyTransfer(myFriendAccount, yourAmount);
            Console.WriteLine(myAccount.GetFullInfo());
            Console.WriteLine(myFriendAccount.GetFullInfo());
        }
        static void Task8_2()
        {
            Console.WriteLine("Упражнение 8.2");
            Console.WriteLine("Введите строку");
            string line;
            line = Console.ReadLine();
            char[] reverse = line.Reverse().ToArray();
            Console.WriteLine(reverse);
        }
        static void Task8_3()
        {
            Console.WriteLine("Упражнение 8.3");
            const string outputFileName = "ResultText.out";
            string inputFileName = string.Empty;

            Console.WriteLine("Введите имя файла");
            inputFileName = Console.ReadLine();

            if (File.Exists(inputFileName))
            {
                File.WriteAllText(outputFileName, File.ReadAllText(inputFileName, Encoding.UTF8).ToUpper(), Encoding.UTF8);
                Console.WriteLine($"Результат успешно записан в файл с именем {outputFileName}");
            }
            else
            {
                Console.WriteLine($"Файл с именем {inputFileName} не найден!");
            }
        }
        static void Task8_4()
        {
            Console.WriteLine("Упражнение 8.4");
            Console.WriteLine("Введите число");
            int number = checkingint();
            Console.WriteLine("Введите строку");
            string obj = Console.ReadLine();
            Console.WriteLine($"Реализует ли интерфейс число {ImplementsIFormattable(number)}");
            Console.WriteLine($"Реализует ли интерфейс строка {ImplementsIFormattable(obj)}");
        }
        public static bool ImplementsIFormattable(object obj)
        {
            return obj is IFormattable || (obj as IFormattable) != null;
        }
    }
}
