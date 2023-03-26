using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;

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



            #endregion

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

            #region task6
            //l1:
            //    Console.Write("1-ci massivin uzunlugunu daxil edin");
            //    string struzunluq = Console.ReadLine();
            //    bool uzun = int.TryParse(struzunluq, out int uzunluq);
            //    if (!uzun)
            //    {
            //        goto l1;
            //    }
            //    int[] a = new int[uzunluq];
            //    for (int i = 0; i < a.Length; i++)
            //    {
            //    l2:
            //        Console.Write($"[{i + 1}]=");
            //        string strarray = Console.ReadLine();
            //        bool tr = int.TryParse(strarray, out int array);
            //        if (!tr)
            //        {
            //            goto l2;
            //        }
            //        a[i] = array;

            //        int[] b = new int[uzunluq];

            //    l4:
            //        Console.Write($"[{i + 1}]=");
            //            string strarray1 = Console.ReadLine();
            //            bool tr1 = int.TryParse(strarray1, out int array1);
            //            if (!tr1)
            //            {
            //                goto l4;
            //            }
            //            b[i] = array1;


            //    if (a[i] == Math.Pow(b[i], 2))
            //    {
            //            Console.WriteLine($"x[{i}]={a[i]}");
            //            Console.WriteLine($"y[{i}]={b[i]}");
            //    }

            //}
            #endregion

            #region task7
            //l1:
            //    Console.Write("Massivin uzunlugunu daxil edin");
            //    string struzunluq = Console.ReadLine();
            //    bool uzun = int.TryParse(struzunluq, out int uzunluq);
            //    if (!uzun)
            //    {
            //        goto l1;
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

            //        int max = a[0];
            //        int min = a[0];
            //        for (int i = 0; i < a.Length; i++)
            //        {
            //            if (max < a[i])
            //            {
            //                max = a[i];
            //            }
            //            else if (min > a[i])
            //            {
            //                min = a[i];
            //            }
            //        }
            //        int avarage=(min+max)/2;
            //        double geoMan = Math.Pow(min * max, 1.0 / 2);
            //        Console.WriteLine($"ededi orta:{avarage}; hendesi silsile:{geoMan}");








            #endregion

            #region task 8
            int[] mass = new int[14];
            int[] mass1 = new int[14];

            for (int i = 0; i < mass.Length; i++)
            {

            l3:
                Console.Write($"[{i + 1}]=");
                string strarray = Console.ReadLine();
                bool tr = int.TryParse(strarray, out int array);
                if (!tr)
                {
                    goto l3;
                }
                mass[i] = array;
            }

            #endregion
            #region task 10
            //Console.Write("Massivin uzunlugun daxil edin:");  
            //string struzun=Console.ReadLine();
            //bool tr=int.TryParse(struzun, out int uzunluq);
            //int[]mass=new int[uzunluq];
            //int enkicik = 0;
            //for (int i = 0; i < mass.Length; i++)
            //{
            //    Console.Write($"[{i + 1}]=");
            //    string strarray=Console.ReadLine();
            //    bool tru=int.TryParse(strarray, out int array);
            //    mass[i]=array;
            //    if (mass[i]<0)
            //    {
            //        if (enkicik > mass[i])
            //        {
            //            enkicik = mass[i];
            //        }
            //    }

            //}
            //Console.WriteLine(enkicik);
            #endregion

            #region task 11
            //Console.Write("Massivin uzunlugun daxil edin:");
            //string struzun = Console.ReadLine();
            //bool tr = int.TryParse(struzun, out int uzunluq);
            //int[] mass = new int[uzunluq];
            //Random random= new Random();
            //int enkicik = 0;
            //for (int i = 0; i < mass.Length; i++)
            //{
            //    Console.Write($"[{i + 1}]=");


            //    mass[i] = random.Next(0,101);
            //    Array.Sort(mass);
            //    Console.WriteLine(mass[i]);

            //}
            #endregion

        }
    }   }