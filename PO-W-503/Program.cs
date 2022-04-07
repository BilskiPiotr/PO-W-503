// Autor: mgr.inż. Piotr Bilski
// Programowanie Obiektowe
using System;

namespace PO_W_503
{
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
            Values a = new Values(10);
            int b = 10;
            ++a;
            Console.WriteLine("\n\n  Inkrementacja prefiksowa obiektu: " + a.Wartosc);
            Console.WriteLine("\n  Inkrementacja prefiksowa pola: " + ++b);
            a = new Values(10);
            b = 10;
            a++;
            Console.WriteLine("\n  Inkrementacja postfiksowa obiektu: " + a.Wartosc);
            Console.WriteLine("\n  Inkrementacja postfiksowa pola: " + b++);
            Console.ReadKey();
        }
    }
}
