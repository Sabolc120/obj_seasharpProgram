using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obj_könnyü2
{
    internal class random_szam
    {
        public int _mennyitől;  //Honnan indúljon a random szám
        public int _meddig; //Mekkora szám lehet maximum
        public int _mennyi; //Hány darab kell, input bekérés.
        public random_szam(int mennyitől, int meddig, int mennyi)
        {
            _mennyitől = mennyitől;  //Konstruktor
            _meddig = meddig;
            _mennyi = mennyi;
        }
        public void bekeres()
        {
            Console.WriteLine("Figyelem! A kezdő érték nem lehet nagyobb mint a terjedési nagyság.");
            Console.WriteLine("Mennyitől indúljon a random szám?");  //Bekérések elvégzése.
            Console.WriteLine("(bekérés(1)- ,másik_bekérésig(2)");
            _mennyitől = int.Parse(Console.ReadLine());
            Console.WriteLine("Meddig terjedjen ki a random szám?");
            Console.WriteLine(_mennyitől+"-től, ig(2): ");
            _meddig = int.Parse(Console.ReadLine());
            Console.WriteLine("Mennyi random szám legyen?: ");
            _mennyi = int.Parse(Console.ReadLine());
        }
        public void muvelet()
        {
            Random veletlen = new Random();          
            for (int i = 0; i < _mennyi; i++)  //Egy számláló ciklussal végigfut annyiszor, amennyiszer a felhasználó kérte.
            {
                int szam = veletlen.Next(_mennyitől, _meddig);
                Console.WriteLine("A random szám "+i+". eleme: "+szam);
            }
        }
    }
}
