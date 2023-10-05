using System;

namespace task05._10;
class Program
{
    #region Task_1
    //static void Main(string[] args)
    //{
    //    int[] numbers = { 1, 2, 3 };
    //    Console.Write("Kohne array: ");

    //    for (int i = 0; i < numbers.Length; i++)
    //    {
    //        Console.Write(numbers[i] + " ");
    //    }

    //    Console.WriteLine();

    //    Console.Write("Yeni array: ");
    //    GetNewArray(ref numbers, 5, 6, 7, 8, 9);
    //    for (int i = 0; i < numbers.Length; i++)
    //    {
    //        Console.Write(numbers[i] + " ");
    //    }
    //}

    //public static void GetNewArray(ref int[] array, params int[] AddValue)
    //{
    //    int newlength = array.Length + AddValue.Length;
    //    int[] NewArray = new int[newlength];

    //    for (int i = 0; i < array.Length; i++)
    //    {
    //        NewArray[i] = array[i];
    //    }

    //    for (int i = 0; i < AddValue.Length; i++)
    //    {
    //        NewArray[array.Length + i] = AddValue[i];
    //    }

    //    array = NewArray;
    //}
    #endregion

    #region Task_2

    //static void Main(string[] args)
    //{
    //    int balance = 500;
    //    int inp = 1;
    //    while (inp!=0)
    //    {
    //        DrawInterface();

    //        inp = int.Parse(Console.ReadLine());

    //        if (inp==1)
    //        {
    //            ShowBalance(balance);
    //        }
    //        if (inp==2)
    //        {
    //            Console.Write("Mebleg: ");
    //            int value= int.Parse(Console.ReadLine());
    //            CashOut(ref balance, value);
    //        }
    //        if (inp==3)
    //        {
    //            Console.Write("Mebleg: ");
    //            int value = int.Parse(Console.ReadLine());
    //            CashIn(ref balance, value);
    //        }
    //    }



    //}


    //public static void DrawInterface()
    //{
    //    Console.WriteLine("----------");
    //    Console.WriteLine("ATM");
    //    Console.WriteLine("----------");

    //    Console.WriteLine();

    //    Console.WriteLine("Emeliyyati sec:");
    //    Console.WriteLine("[1] Balans");
    //    Console.WriteLine("[2] Cash out");
    //    Console.WriteLine("[3] Cash in");
    //    Console.WriteLine("[0] Cix");

    //    Console.WriteLine();

    //    Console.Write(">>>");
    //}


    //public static void ShowBalance(int balance)
    //{
    //    Console.WriteLine("Balans: " + balance);
    //    Console.WriteLine();
    //}

    //public static void CashOut(ref int balance, int value)
    //{
    //    balance -= value;
    //    Console.WriteLine();
    //    Console.WriteLine("Balans: " + balance);

    //}

    //public static void CashIn(ref int balance, int value)
    //{
    //    balance += value;
    //    Console.WriteLine();
    //    Console.WriteLine("Balans: " + balance);

    //}
    #endregion

}
