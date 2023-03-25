namespace Taks_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
        #region task 1
        // l1:
        // Console.Write("C ededini daxil edin:");
        // string strvalue=Console.ReadLine();
        // bool eded = int.TryParse(strvalue, out int value);
        // if (!eded)
        // {
        //     goto l1;
        // }

        //l2:
        // Console.Write("Massivin uzunlugunu daxil edin");
        // string struzunluq=Console.ReadLine();
        // bool uzun = int.TryParse(struzunluq, out int uzunluq);
        // if (!uzun)
        // {
        //     goto l2;
        // }
        // int[] a=new int[uzunluq];
        // for (int i = 0; i <a.Length; i++)
        // {
        //     l3:
        //     Console.Write($"[{i+1}]=");
        //     string strarray = Console.ReadLine();
        //     bool tr = int.TryParse(strarray, out int array);
        //     if (!tr)
        //     {
        //         goto l3;
        //     }
        //     a[i] = array;


        // }
        // for (int i = 0; i < a.Length; i++)
        // {
        //     if (a[i] < value)
        //     {
        //         Console.WriteLine($"[{i}]={a[i]}");
        //     }
        // }


        #endregion

        #region task2
        //l1:
        //    Console.Write("C ededini daxil edin:");
        //    string strvalue = Console.ReadLine();
        //    bool eded = int.TryParse(strvalue, out int value);
        //    if (!eded)
        //    {
        //        goto l1;
        //    }

        //l2:
        //    Console.Write("Massivin uzunlugunu daxil edin");
        //    string struzunluq = Console.ReadLine();
        //    bool uzun = int.TryParse(struzunluq, out int uzunluq);
        //    if (!uzun)
        //    {
        //        goto l2;
        //    }
        //    int[] a = new int[uzunluq];
        //    for (int i = 0; i < a.Length; i++)
        //    {
        //    l3:
        //        Console.Write($"[{i + 1}]=");
        //        string strarray = Console.ReadLine();
        //        bool tr = int.TryParse(strarray, out int array);
        //        if (!tr)
        //        {
        //            goto l3;
        //        }
        //        a[i] = array;


        //    }
        //    int count = 0;
        //    int silsile = 0;

        //    for (int i = 0; i < a.Length; i++)
        //    {
        //        if (a[i] < value)
        //        {
        //            silsile = silsile + a[i];
        //            count++;


        //        }
        //    }
        //   decimal orta = (decimal)silsile / count;
        //    Console.WriteLine(orta);
        #endregion

        #region task3
        //l1:
        //    Console.Write("C ededini daxil edin:");
        //    string strvalue = Console.ReadLine();
        //    bool eded = int.TryParse(strvalue, out int value);
        //    if (!eded)
        //    {
        //        goto l1;
        //    }

        //l2:
        //    Console.Write("Massivin uzunlugunu daxil edin");
        //    string struzunluq = Console.ReadLine();
        //    bool uzun = int.TryParse(struzunluq, out int uzunluq);
        //    if (!uzun)
        //    {
        //        goto l2;
        //    }
        //    int[] a = new int[uzunluq];
        //    for (int i = 0; i < a.Length; i++)
        //    {
        //    l3:
        //        Console.Write($"[{i + 1}]=");
        //        string strarray = Console.ReadLine();
        //        bool tr = int.TryParse(strarray, out int array);
        //        if (!tr)
        //        {
        //            goto l3;
        //        }
        //        a[i] = array;


        //    }
        //    double final = 0;
        //    int count = 0;
        //    int silsile = 1;
        //    for (int i = 0; i < a.Length; i++)
        //    {
        //        if (a[i] > value)
        //        {
        //            silsile = silsile * a[i];
        //            count++;

        //        }

        //    }
        //    double count2 = 1.0 / count;
        //    final = Math.Pow(silsile, count2);

        //    Console.WriteLine(final);



        //    #endregion

            #region task4 
            //l1:
            //    Console.Write("C ededini daxil edin:");
            //    string strvalue = Console.ReadLine();
            //    bool eded = int.TryParse(strvalue, out int value);
            //    if (!eded)
            //    {
            //        goto l1;
            //    }

            //l2:
            //    Console.Write("Massivin uzunlugunu daxil edin");
            //    string struzunluq = Console.ReadLine();
            //    bool uzun = int.TryParse(struzunluq, out int uzunluq);
            //    if (!uzun)
            //    {
            //        goto l2;
            //    }
            //    int[] a = new int[uzunluq];
            //    for (int i = 0; i < a.Length; i++)
            //    {
            //    l3:
            //        Console.Write($"[{i + 1}]=");
            //        string strarray = Console.ReadLine();
            //        bool tr = int.TryParse(strarray, out int array);
            //        if (!tr)
            //        {
            //            goto l3;
            //        }
            //        a[i] = array;


            //    }

            //    for (int i = 0; i < a.Length; i++)
            //    {
            //        if (a[i] > value)
            //        {
            //            Array.Sort(a);
            //            Array.Reverse(a);
            //            Console.WriteLine(a[i]);

            //        }



            //    }
            #endregion

            #region task5
            //l1:
            //    Console.Write("C ededini daxil edin:");
            //    string strvalue = Console.ReadLine();
            //    bool eded = int.TryParse(strvalue, out int value);
            //    if (!eded)
            //    {
            //        goto l1;
            //    }

            //l2:
            //    Console.Write("Massivin uzunlugunu daxil edin");
            //    string struzunluq = Console.ReadLine();
            //    bool uzun = int.TryParse(struzunluq, out int uzunluq);
            //    if (!uzun)
            //    {
            //        goto l2;
            //    }
            //    int[] a = new int[uzunluq];
            //    for (int i = 0; i < a.Length; i++)
            //    {
            //    l3:
            //        Console.Write($"[{i + 1}]=");
            //        string strarray = Console.ReadLine();
            //        bool tr = int.TryParse(strarray, out int array);
            //        if (!tr)
            //        {
            //            goto l3;
            //        }
            //        a[i] = array;


            //    }
            //    int enboyuk = 0;
            //    for (int i = 0; i < a.Length; i++)
            //    {
            //        if (a[i] < value)
            //        {
            //            if (enboyuk < a[i])
            //            {
            //                enboyuk = a[i];
            //            }
            //        }
            //    }
            //    Console.WriteLine(enboyuk);
            #endregion


            #region task10
            //l1:
            //            Console.Write("Massivin uzunlugunu daxil edin:");
            //            string struzun=Console.ReadLine();
            //            bool tr = int.TryParse(struzun, out int uzunluq);
            //            if (!tr)
            //            {
            //                goto l1;
            //            }
            //            int[] mass=new int[uzunluq];
            #endregion

        }

    }
}