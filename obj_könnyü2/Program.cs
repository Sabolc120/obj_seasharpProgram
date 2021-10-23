using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obj_könnyü2
{
    //Könnyebb OBJ szint gyakorlás, tartalmazza a kövektezőket: Számológép, Random szám input.
    internal class Program
    {
        static void Main(string[] args)
        {
            calculator bekeres = new calculator(1, "+", 1);   //Alapértékek hozzárendelése, objektum létrehozása. Ha rossz az input, az eredmény mindig 2 lesz.
            random_szam randomok = new random_szam(1, 2, 1); //Alapértékek hozzárendelése, objektum létrehozása, az alapérték mindig 1-től fog kezdődni és kettőig megy, egyszer lefutva.
            jelszo_gen jelszogenerator = new jelszo_gen(1, 1, 1);
            try
            {
                bekeres.cw();     //Szövegelés előhívása a calculator classből.
                int választás = int.Parse(Console.ReadLine());
                while (választás != 1 || választás != 2)    //Ha 1-est írja felhasználó vagy kettest, legyen ez meg az.
                {
                    Console.WriteLine("Ki szeretnél lépni? ha Igen, írd be a következőt: 999");
                    Console.WriteLine("Ha nem, akkor csak írjon be valami véletlenszerűt..");
                    string kilepes = Console.ReadLine();
                    if(kilepes == "999")   //Azért, hogy ne legyen örök a loop, kell egy kilépési kód ami egy break lesz.
                    {
                        break;
                    }
                    else
                    {
                        if (választás == 1) //Ha a felhasználó 1-est írt be, előhívom a számológéppel kapcsolatos kódokat.
                        {
                            bekeres.bekérés();
                            bekeres.calc();
                        }
                        if(választás == 2)
                        {
                            randomok.bekeres(); //Ha a felhasználó 2-est írt be, előhívom a random számokkal kapcsolatos kódokat.
                            randomok.muvelet();
                        }
                        if(választás == 3)
                        {
                            jelszogenerator.bekeres();
                            jelszogenerator.muvelet();
                        }
                    }
                }
            }
            catch            {
                Console.WriteLine("Betűt adtál meg egy integer bekérésnek. Hiba");
            }         
        }
    }
}
