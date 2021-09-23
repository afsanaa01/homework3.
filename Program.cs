using System;

namespace ConsoleApp24
{
    class Program
    {
        static void Main(string[] args)
        {
            #region birinci
            //int number;
            //while (true)
            //{
            //    try
            //    {
            //        Console.Write("Balinizi daxil edin");

            //        number = Convert.ToInt32(Console.ReadLine());

            //        if (number >= 91 && number <= 100)
            //        {
            //            Console.WriteLine("A");
            //        }
            //        if (number >= 81 && number <= 90)
            //        {
            //            Console.WriteLine("B");
            //        }
            //        if (number >= 71 && number <= 80)
            //        {
            //            Console.WriteLine("C");
            //        }
            //        if (number >= 61 && number <= 70)
            //        {
            //            Console.WriteLine("D");
            //        }
            //        if (number >= 51 && number <= 60)
            //        {
            //            Console.WriteLine("E");
            //        }
            //        if (number >= 0 && number <= 50)
            //        {
            //            Console.WriteLine("Kesr");
            //        }
            //    }
            //    catch (Exception)
            //    {
            //        Console.WriteLine("bal yanlisdir");

            //    }
            //}
            #endregion
            #region ikinci
            //int number;
            //int divider = 1;

            //Console.Write("Enter a number: ");
            //number = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i <= number; i++, divider++)
            //{

            //    if (number % divider == 0)
            //    {
            //        Console.WriteLine(divider);
            //    }

            //}
            #endregion
            #region ucuncu

            //int number;
            //int i = 0;

            //number = Convert.ToInt32(Console.ReadLine());
            //Console.Write("mertebelerin sayi: ");
            //while (number >= 1)
            //{
            //    number /= 10;
            //    i++;
            //}
            //Console.WriteLine(i);
            #endregion
            #region dorduncu
            //int number;
            //int result = 0;

            //number = Convert.ToInt32(Console.ReadLine());
            //while (number >= 1)
            //{
            //    result += number % 10;
            //    number = (number - (number % 10)) / 10;

            //}
            //Console.WriteLine(result);
            #endregion
            #region besinci
            //    int number;
            //    int i;

            //    Console.Write("ededi daxil edin: ");
            //    number = Convert.ToInt32(Console.ReadLine());

            //    DefineNum(number);

            //}
            //static void DefineNum(int number, int i = 2)
            //{

            //    if (number % i! == 0)
            //    {
            //        Console.WriteLine("True");
            //    }
            //    else
            //    {
            //        Console.WriteLine("False");
            //    }

            //    while (i < number)
            //    {
            //        i++;
            //    }
            #endregion
            #region altinci
        //    int number;

        //    Console.Write("ededi daxil edin");
        //    number = Convert.ToInt32(Console.ReadLine());

        //    DefineNum(number);

        //}
        //static void DefineNum(int number)
        //{
        //    int result = 1;
        //    while (number >= 1)
        //    {
        //        result *= number;
        //        number--;
        //    }
        //    Console.WriteLine(result);
            #endregion
            #region yeddinci
            //int[] numbers = { 6, 78, 96, 45, 8 };
            //Console.WriteLine(GetMinMax(numbers));
            //static int GetMinMax(int[] arr)
            //{
            //    try
            //    {
            //        int min = arr[0], max = arr[0];
            //        for (int i = 0; i < arr.Length; i++)
            //        {
            //            if (arr[i] < min)
            //            {
            //                min = arr[i];

            //            }
            //            if (arr[i] > max)
            //            {
            //                max = arr[i];
            //            }
            //        }
            //        return min + max;

            //    }
            //    catch (Exception)
            //    {

            //        Console.WriteLine("error");
            //        return 0;

            //    }
            //}
            #endregion
            #region sekkizinci
            //string[] seasons = { "yaz", "yay", "payiz", "qis" };
            //int number;
            //Console.Write("eded daxil edin: ");
            //number = Convert.ToInt32(Console.ReadLine());
            //if (number >= 1 && number <= 4)
            //{
            //    switch (number)
            //    {
            //        case 1:
            //            Console.WriteLine(seasons[0]);
            //            break;
            //        case 2:
            //            Console.WriteLine(seasons[1]);
            //            break;
            //        case 3:
            //            Console.WriteLine(seasons[2]);
            //            break;
            //        case 4:
            //            Console.WriteLine(seasons[3]);
            //            break;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("eded dogru deyil");
            //}
            #endregion
            #region doqquzuncu
            //    string[] names = { "Firuze", "Nezaket", "Zeyneb", "Fatime" };
            //    Console.WriteLine(Maxstring(names));
            //static string Maxstring(string[] arry)
            //{
            //    string result = "";
            //    for (int i = 0; i < arry.Length; i++)
            //    {
            //        if (arry[i].Length > result.Length)
            //        {
            //            result = arry[i];
            //        }
            //    }
            //    return result;
            //}
            #endregion
            #region onuncu
            //int num;
            //int result;
            //num = Convert.ToInt32(Console.ReadLine());
            //Console.Write("ededi daxil edin:");

            //try
            //{
            //    if (num == 1)
            //    {
            //        for (int i = 1; i <= 10; i++)
            //        {
            //            result = i * num;
            //            Console.WriteLine(num + "*" + i + "=" + result);
            //        }
            //    }
            //    if (num == 2)
            //    {
            //        for (int i = 1; i <= 10; i++)
            //        {
            //            result = i * num;
            //            Console.WriteLine(num + "*" + i + "=" + result);
            //        }
            //    }
            //    if (num == 3)
            //    {
            //        for (int i = 1; i <= 10; i++)
            //        {
            //            result = i * num;
            //            Console.WriteLine(num + "*" + i + "=" + result);
            //        }
            //    }
            //    if (num == 4)
            //    {
            //        for (int i = 1; i <= 10; i++)
            //        {
            //            result = i * num;
            //            Console.WriteLine(num + "*" + i + "=" + result);
            //        }
            //    }

            //    if (num == 5)
            //    {
            //        for (int i = 1; i <= 10; i++)
            //        {
            //            result = i * num;
            //            Console.WriteLine(num + "*" + i + "=" + result);
            //        }
            //    }
            //    if (num == 6)
            //    {
            //        for (int i = 1; i <= 10; i++)
            //        {
            //            result = i * num;
            //            Console.WriteLine(num + "*" + i + "=" + result);
            //        }
            //    }
            //    if (num == 7)
            //    {
            //        for (int i = 1; i <= 10; i++)
            //        {
            //            result = i * num;
            //            Console.WriteLine(num + "*" + i + "=" + result);
            //        }
            //    }
            //    if (num == 8)
            //    {
            //        for (int i = 1; i <= 10; i++)
            //        {
            //            result = i * num;
            //            Console.WriteLine(num + "*" + i + "=" + result);
            //        }
            //    }
            //    if (num == 9)
            //    {
            //        for (int i = 1; i <= 10; i++)
            //        {
            //            result = i * num;
            //            Console.WriteLine(num + "*" + i + "=" + result);
            //        }
            //    }
            //    if (num == 10)
            //    {
            //        for (int i = 1; i <= 10; i++)
            //        {
            //            result = i * num;
            //            Console.WriteLine(num + "*" + i + "=" + result);
            //        }
            //    }
            //}
            //catch (Exception)
            //{

            //    Console.WriteLine("eded yanlisdir");
            //}
            #endregion
        }


    }
}

