// Autor: mgr.inż. Piotr Bilski
// Programowanie Obiektowe
using System;

namespace PO_W_503
{
    // ======== 1 ========
    struct Values
    {
        int _value;
        // konstruktor struktury
        public Values(int value)
        {
            _value = value;
        }
        // właściwość podająca wartość pola prywatnego
        public int Wartosc
        {
            get { return (_value); }
        }
        // nadpisanie operatora (--)
        public static Values operator --(Values par)
        {
            par._value--;
            return par;
        }
        // nadpisanie operatora(++)
        public static Values operator ++(Values par)
        {
            par._value++;
            return par;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            Console.WriteLine("Inkrementacja prefiksowa : " + ++a);
            a = 10;
            Console.WriteLine("Inkrementacja postfiksowa : " + a++);
            Console.ReadKey();
        }
    }

    // ======== 2 ========
    //class Values
    //{
    //    int _value;
    //    // konstruktor struktury
    //    public Values(int value)
    //    {
    //        _value = value;
    //    }
    //    // właściwość podająca wartość pola prywatnego
    //    public int Wartosc
    //    {
    //        get { return (_value); }
    //    }
    //    // nadpisanie operatora (--)
    //    public static Values operator --(Values par)
    //    {
    //        return new Values(par._value - 3);
    //    }
    //    // nadpisanie operatora(++)
    //    public static Values operator ++(Values par)
    //    {
    //        return new Values(par._value + 3);
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Values v1 = new Values(10);
    //        Values v2 = ++v1;
    //        Console.WriteLine("Inkrementacja prefiksowa : {0}", v2.Wartosc);
    //        Values v3 = --v1;
    //        Console.WriteLine("Dekrementacja prefiksowa : {0}", v3.Wartosc);
    //        v1 = new Values(10);
    //        Console.WriteLine("Aktualna wartosc v1 = {0}", v1.Wartosc);
    //        Values v4 = v1++;
    //        Console.WriteLine("Inkrementacja postfiksowa : {0}", v4.Wartosc);
    //        Values v5 = v1--;
    //        Console.WriteLine("Dekrementacja postfiksowa : {0}", v5.Wartosc);
    //        Console.ReadKey();
    //    }
    //}
}
