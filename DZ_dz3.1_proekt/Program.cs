using System;
using System.Runtime.InteropServices;
namespace progect
{
    class Program
    {
        // Пункт 6
        struct Drink
        {
            public string Name;
            public double AlcoholPercent;
        }

        struct Student
        {
            public string LastName;
            public string FirstName;
            public int Id;
            public string BirthDate;
            public char Category;
            public Drink DrinkInfo;
            public double Volume;
        }

        static void Main(string[] args)
        {
            // Пункт 1 
            Console.WriteLine("Пункт 1");
            Console.WriteLine($"Тип данных --- Максимальное значение --- Минимальное значение");
            Console.WriteLine($"byte --- {byte.MaxValue} --- {byte.MinValue}");
            Console.WriteLine($"Sbyte --- {sbyte.MaxValue} --- {sbyte.MinValue}");
            Console.WriteLine($"short --- {short.MaxValue} --- {short.MinValue}");
            Console.WriteLine($"ushort --- {ushort.MaxValue} --- {ushort.MinValue}");
            Console.WriteLine($"int --- {int.MaxValue} --- {int.MinValue}");
            Console.WriteLine($"uint --- {uint.MaxValue} --- {uint.MinValue}");
            Console.WriteLine($"long  --- {long.MaxValue} --- {long.MinValue}");
            Console.WriteLine($"ulong --- {ulong.MaxValue} --- {ulong.MinValue}");
            Console.WriteLine($"float --- {float.MaxValue} --- {float.MinValue}");
            Console.WriteLine($"double --- {double.MaxValue} --- {double.MinValue}");
            Console.WriteLine($"decimal --- {decimal.MaxValue} --- {decimal.MinValue}");


            // Пункт 2
            Console.WriteLine("Пункт 2");
            Console.Write("Введите имя пользователя: ");
            string name = Console.ReadLine();
            Console.Write("Введите город пользователя: ");
            string sity = Console.ReadLine();
            Console.Write("Введите возраст пользователя: ");
            string age_input = Console.ReadLine();
            double age = double.Parse(age_input);
            Console.Write("Введите PIN-код пользователя: ");
            string pin = Console.ReadLine(); //оставляем в виде строки,тк если первая цифра будет 0,то она проигнорируется
            Console.WriteLine("Информация о пользователе:");
            Console.WriteLine($"Имя - {name}, город - {sity}, возраст - {age}, пин-код - {pin}");


            // Пункт 3
            Console.WriteLine("Пункт 3");
            Console.WriteLine("Введите строку:");
            string input = Console.ReadLine();
            string result = "";
            foreach (char i in input)
                if (char.IsLower(i))
                {
                    result += char.ToUpper(i);
                }
                else if (char.IsUpper(i))
                {
                    result += char.ToLower(i);
                }
                else
                {
                    result += i; //если символ будет не буквой,просто запишем в result
                }
            Console.Write("Результат:");
            Console.WriteLine(result);


            // Пункт 4
            Console.WriteLine("Пункт 4");
            Console.WriteLine("Введите строку:");
            string str = Console.ReadLine();
            Console.WriteLine("Введите подстроку:");
            string substr = Console.ReadLine();
            int count = 0;
            for (int c = 0; c <= str.Length - substr.Length; c++)
                if (str.Substring(c, substr.Length) == substr)
                {
                    count++;
                }
            Console.WriteLine($"Количество '{substr}' в '{str}' равно {count}");


            // Пункт 5
            Console.WriteLine("Пункт 5");
            Console.WriteLine("Введите стандартную цену бутылки виски:");
            string NormPriceInput = Console.ReadLine();
            int NormPrice = int.Parse(NormPriceInput);

            Console.WriteLine("Введите скидку(в процентах):");
            string SalePriceInput = Console.ReadLine();
            int SalePrice = int.Parse(SalePriceInput);

            Console.WriteLine("Введите стоимость отпуска:");
            string HolidayPriceInput = Console.ReadLine();
            int HolidayPrice = int.Parse(HolidayPriceInput);

            int saving = NormPrice * SalePrice / 100; // экономия на одной бутылке

            int bottels = HolidayPrice / saving; // сколько бутылок нужно

            Console.WriteLine($"Нужно купить {bottels} бутылок");


            // Пункт 6
            Console.WriteLine("Пункт 6");
            Student[] students = new Student[5];
            students[0] = new Student
            {
                LastName = "Назмеев",
                FirstName = "Амир",
                Id = 1,
                BirthDate = "26.02.2005",
                Category = 'a',
                DrinkInfo = new Drink { Name = "Виски", AlcoholPercent = 40 },
                Volume = 0.4
            };

            students[1] = new Student
            {
                LastName = "Дымолазова",
                FirstName = "Камилла",
                Id = 2,
                BirthDate = "18.12.2006",
                Category = 'b',
                DrinkInfo = new Drink { Name = "Пиво", AlcoholPercent = 7.2 },
                Volume = 1.5
            };

            students[2] = new Student
            {
                LastName = "Пронин",
                FirstName = "Никита",
                Id = 3,
                BirthDate = "12.09.2007",
                Category = 'b',
                DrinkInfo = new Drink { Name = "Ром", AlcoholPercent = 45 },
                Volume = 0.3
            };
            students[3] = new Student
            {
                LastName = "Шибаева",
                FirstName = "Сабина",
                Id = 4,
                BirthDate = "01.02.2005",
                Category = 'd',
                DrinkInfo = new Drink { Name = "Сок", AlcoholPercent = 0 },
                Volume = 0.9
            };
            students[4] = new Student
            {
                LastName = "Гарипова",
                FirstName = "Лиана",
                Id = 5,
                BirthDate = "25.04.2000",
                Category = 'c',
                DrinkInfo = new Drink { Name = "Вино", AlcoholPercent = 12 },
                Volume = 1.5
            };

            double TotalVolume = 0; // счетчик объема напитков
            foreach (Student c in students)
            {
                TotalVolume += c.Volume;
            }
            double TotalAlcohol = 0; // счетчик чистого алкоголя
            foreach (Student c in students)
            {
                TotalAlcohol += c.Volume * c.DrinkInfo.AlcoholPercent / 100.0;
            }
            Console.WriteLine($"Общий объем выпитой жидкости: {TotalVolume} л");
            Console.WriteLine($"Общий объем алкоголя:  {TotalAlcohol} л");
            foreach (Student c in students)
            {
                double studentAlcohol = c.Volume * c.DrinkInfo.AlcoholPercent / 100.0;
                double percentOfVolume = c.Volume / TotalVolume * 100;
                double percentOfAlcohol = studentAlcohol / TotalAlcohol * 100;

                Console.WriteLine();
                Console.WriteLine($"{c.LastName} {c.FirstName} (категория: {c.Category})");
                Console.WriteLine($"Напиток: {c.DrinkInfo.Name} ({c.DrinkInfo.AlcoholPercent}%)");
                Console.WriteLine($"Выпил жидкости: {c.Volume} л ({percentOfVolume}% от общего)");
                Console.WriteLine($"Чистого алкоголя: {studentAlcohol} л ({percentOfAlcohol}% от общего)");
            }
        }
    }
}

