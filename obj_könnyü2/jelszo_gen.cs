using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obj_könnyü2
{
    internal class jelszo_gen
    {
        public int _hossz;
        public int _biztonsag;
        public int _specialischar;
        public jelszo_gen(int hossz, int biztonsag, int specialischar)
        {
            _hossz = hossz;
            _biztonsag = biztonsag;
            _specialischar = specialischar;
        }
        public void bekeres()
        {
            try
            {
                Console.WriteLine("Milyen hosszú legyen a jelszó?(Hány karakter): ");
                _hossz = int.Parse(Console.ReadLine());
                Console.WriteLine("Mekkora legyen a biztonsági szint?");
                Console.WriteLine("1. Könnyebb");
                Console.WriteLine("2. Normál");
                Console.WriteLine("3. Őrzött");
                _biztonsag = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Helytelen bevitel!");
            }
        }
        public void muvelet()
        {
            StringBuilder result = new StringBuilder();
            string karakterek = "qwertzuiopasdfghjkléáíyxcvbnm";  //Kellet 3 darab string, a fokozatok miatt.
            string karakterek_n = "qwertzuiopasdfghjkléáíyxcvbnm12345678910";
            string karakterek_h = "qwertzuiopasdfghjkléáíDDHSAADSKyxcvbnm12345678910YXCZUIKLÉMTR#&$ß*<<đÄß÷×¤";
            Random veletlen = new Random();   //Randommal lesznek kiválasztva a karakterek.
            string valami = "";
            int index = -1;
            if(_biztonsag == 1)
            {
                for (int i = 0; i < _hossz; i++)
                {
                    result.Append(karakterek[veletlen.Next(karakterek.Length)]);
                }
            }
            if(_biztonsag == 2)
            {
                for (int i = 0; i < _hossz; i++)
                {
                    result.Append(karakterek_n[veletlen.Next(karakterek_n.Length)]);
                }
            }
            if(_biztonsag == 3)
            {
                for (int i = 0; i < _hossz; i++)
                {
                    result.Append(karakterek_h[veletlen.Next(karakterek_h.Length)]);
                }
            }
            Console.WriteLine("A jelszó generátor eredménye: " + result);
        }
    }
}
