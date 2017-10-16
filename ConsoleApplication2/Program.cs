using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba dyrektor = new Osoba();
            dyrektor.imie = "Hubert";
            dyrektor.nazwisko = "Włoch";
            dyrektor.rokUrodzenia = 1997;
            dyrektor.waga = 90;
            dyrektor.wzrost = 180;
            dyrektor.okulary = true;
            dyrektor.plec = "M";

            Console.WriteLine(dyrektor.imie+ "\n" + dyrektor.nazwisko);
            Console.WriteLine(dyrektor.ObliczWiek());
            Console.WriteLine(dyrektor.Info());
            Console.ReadKey();
        }
    }
}
