using System;

namespace Lab09
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Console.WriteLine();
            Task2();
            Console.WriteLine();
            Task3();
            Console.WriteLine();
            Task4();
            Console.WriteLine();
            Task5();
            Console.WriteLine();
            Task6();
            Console.WriteLine();
            TaskEmail();
        }

        // Задание 1
        static void Task1()
        {
            Console.WriteLine("Задание 1");
            Console.Write("Введите слово: ");
            string word = Console.ReadLine();
            if (string.IsNullOrEmpty(word))
            {
                Console.WriteLine("Пустая строка — пропускаем.");
                return;
            }
            Console.WriteLine($"Длина: {word.Length}");
            Console.WriteLine($"Первый символ: {word[0]}");
            Console.WriteLine($"Последний символ: {word[word.Length - 1]}");
            int countA = 0;
            string lower = word.ToLower();
            foreach (char c in lower)
            {
                if (c == 'а') countA++;
            }
            Console.WriteLine($"Букв 'а' (в любом регистре): {countA}");
        }

        // Задание 2
        static void Task2()
        {
            Console.WriteLine("Задание 2");
            Console.Write("Введите имя файла: ");
            string file = Console.ReadLine() ?? "";
            string lower = file.ToLower();
            if (lower.EndsWith(".cs"))
                Console.WriteLine("Тип: файл C# (.cs)");
            else if (lower.EndsWith(".png") || lower.EndsWith(".jpg"))
                Console.WriteLine("Тип: изображение");
            else
                Console.WriteLine("Тип: неизвестный тип");

            if (file.StartsWith("Lab"))
                Console.WriteLine("Это лабораторная работа");

            if (lower.Contains("test"))
                Console.WriteLine("Тестовый файл");
        }

        // Задание 3
        static void Task3()
        {
            Console.WriteLine("Задание 3");
            Console.Write("Введите фразу: ");
            string phrase = Console.ReadLine() ?? "";
            Console.WriteLine($"Большими буквами: {phrase.ToUpper()}");
            Console.WriteLine($"Пробелы заменены: {phrase.Replace(' ', '_')}");
            if (phrase.ToLower().Contains("стоп"))
                Console.WriteLine("Стоп-слово найдено!");
        }

        // Задание 4
        static void Task4()
        {
            Console.WriteLine("Задание 4");
            Console.Write("Введите дату в формате YYYY-MM-DD: ");
            string date = Console.ReadLine() ?? "";
            if (date.Length == 10 && date[4] == '-' && date[7] == '-')
            {
                string year = date.Substring(0, 4);
                string month = date.Substring(5, 2);
                string day = date.Substring(8, 2);
                Console.WriteLine($"Дата: {day}.{month}.{year}");
            }
            else
            {
                Console.WriteLine("Неверный формат даты!");
            }
            Console.Write("Введите телефон из 11 цифр (например 89161234567): ");
            string phone = Console.ReadLine() ?? "";
            if (phone.Length == 11 && phone.StartsWith("8"))
            {
                string code = phone.Substring(1, 3);
                string p1   = phone.Substring(4, 3);
                string p2   = phone.Substring(7, 2);
                string p3   = phone.Substring(9, 2);
                Console.WriteLine($"Телефон: +7 ({code}) {p1}-{p2}-{p3}");
            }
            else
            {
                Console.WriteLine("Неверный формат телефона!");
            }
        }

        // Задание 5
        static void Task5()
        {
            Console.WriteLine("Задание 5");
            Console.Write("Введите строку: ");
            string text = Console.ReadLine() ?? "";
            int spaces = 0;
            int vowels = 0;
            string vowelLetters = "аейёиоуыэюяaeiouy";
            string lower = text.ToLower();
            foreach (char c in lower)
            {
                if (c == ' ') spaces++;
                if (vowelLetters.Contains(c.ToString())) vowels++;
            }
            Console.WriteLine($"Символов: {text.Length}");
            Console.WriteLine($"Пробелов: {spaces}");
            Console.WriteLine($"Гласных: {vowels}");
        }

        // Задание 6
        static void Task6()
        {
            Console.WriteLine("Задание 6");
            Console.Write("Введите слово: ");
            string word = Console.ReadLine() ?? "";
            if (word.Length == 0) { Console.WriteLine("Пусто."); return; }
            string reversed = "";
            for (int i = word.Length - 1; i >= 0; i--)
                reversed += word[i];
            Console.WriteLine($"Перевёртыш: {reversed}");
            string a = word.ToLower();
            string b = reversed.ToLower();
            Console.WriteLine(a == b ? "Это палиндром." : "Это не палиндром.");
        }

        // Итоговая задача
        static void TaskEmail()
        {
            Console.WriteLine("Проверка email");
            Console.Write("Введите email: ");
            string email = Console.ReadLine() ?? "";
            if (email.Length < 5)
            {
                Console.WriteLine("Адрес некорректен: длина меньше 5 символов.");
                return;
            }
            int atCount = 0;
            foreach (char c in email)
                if (c == '@') atCount++;
            if (atCount != 1)
            {
                Console.WriteLine($"Адрес некорректен: символов '@' — {atCount}, а должен быть ровно 1.");
                return;
            }
            if (email.StartsWith("@") || email.EndsWith("@"))
            {
                Console.WriteLine("Адрес некорректен: не может начинаться или заканчиваться на '@'.");
                return;
            }
            if (email.Contains(' '))
            {
                Console.WriteLine("Адрес некорректен: содержит пробелы.");
                return;
            }
            string lower = email.ToLower();
            if (!(lower.EndsWith(".ru") || lower.EndsWith(".com")))
            {
                Console.WriteLine("Адрес некорректен: должен заканчиваться на .ru или .com.");
                return;
            }
            Console.WriteLine($"Адрес корректен: {email.ToLower()}");
        }
    }
}