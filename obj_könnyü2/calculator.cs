using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obj_könnyü2
{
    internal class calculator
    {
        public int _elsoszam;    //Az input változók.
        public string _operátor;
        public int _masodikszam;
        public calculator(int elsoszam, string operátor, int masodikszam)
        {
            _elsoszam = elsoszam; //Konstruktor
            _operátor = operátor;
            _masodikszam = masodikszam;
        }
        public void bekérés()
        {
            try
            {
                Console.WriteLine("Üdvözöllek a kalkulátorban.");   //Input bekérések, átváltások.
                Console.WriteLine("Írja be az első számot: ");
                _elsoszam = int.Parse(Console.ReadLine());
                Console.WriteLine("Írja be az operátort.");
                Console.WriteLine("Elérhető operátorok: +, -, /, %, *: ");
                _operátor = Console.ReadLine();
                Console.WriteLine("Írja be a második számot: ");
                _masodikszam = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Helytelen bevitel!"); //try & and catch, crashelés elkerülése érdekében.
            }
        }
        public void calc()
        {
            if (_operátor == "+")   //Ha az operátor xxy, csináld ezt.
            {
                Console.WriteLine("Eredmény: {0}", _elsoszam + _masodikszam);
            }
            if (_operátor == "-")
            {
                Console.WriteLine("Eredmény: {0}", _elsoszam - _masodikszam);
            }
            if (_operátor == "*")
            {
                Console.WriteLine("Eredmény: {0}", _elsoszam * _masodikszam);
            }
            if (_operátor == "/")
            {
                Console.WriteLine("Eredmény: {0}", _elsoszam / _masodikszam);
            }
            if (_operátor == "%")
            {
                Console.WriteLine("Eredmény: {0}", _elsoszam % _masodikszam);
            }
        }
        public void cw()
        {
            Console.WriteLine("Melyik programot akarja futtatni? "); //Szövegelés a program elején, ne a main programban legyen.
            Console.WriteLine("1. Számológép");
            Console.WriteLine("2. Random szám generátor");
            Console.WriteLine("3. Jelszó generátor");
        }
    }
}