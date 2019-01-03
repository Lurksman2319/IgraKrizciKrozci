using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
TO DO LIST:
- main array in main();
- izris polja v PosodobiRisiPolje();
*/

/*
 * 9./III - naloga - Igra Križci krožci (18)

Proučite pravila igre "Križci-krožci" ("Tic-tac-toe" (ang. vir)) ter izdelajte program, 
ki bo igralcu omogočil igranje te igre proti inteligentnemu računalniku. 
Pri vsaki igri se naključno izbere kdo bo igral prvi.

Igra se na tabli dimenzije 3x3 polj. Igralec in računalnik izmenično podajata koordinati polja,
 kamor postavita naslednji križec ali krožec. Po vsaki potezi program posodobi (na novo izriše) 
igralno tablo. Ko eden izmed njiju doseže "tri v vrsto" (po vrsticah, stolpcih ali diagonalah) 
se izpiše zmagovalca. V primeru neodločenega izida se naj izpiše "Neodločen izid!".

Po koncu vsake igre vprašajte uporabnika, če želi igrati še eno igro.

Implementirajte dve težavnosti igre (igralec pred vsako igro izbere težavnost, 
tako da vpiše niz "Lahka" ali pa niz "Inteligentna"):
- Lahka: računalnik na vsaki potezi naključno izbere eno izmed še praznih/prostih polj,
- Inteligentna: računalnik igra igro tako, da nikoli ne izgubi (igra se lahko konča neodločeno).

*/

namespace IgraKrizciKrozci
{
    class Program
    {
        static void Pozdrav() {
            string navodila = "To so navodila. Veljavna vnosna znaka sta O ali X in veljavna polja so označena z indexi 1 do 9." +
                "\nV polje vneseš znak tako, da izbereš in vpišeš številko indexa.";
            Console.WriteLine("Dobrodošel v igro Križec Krožec");
            Console.WriteLine(navodila);
        }

        static char IzberiZnak() {
            //Console.WriteLine("Izberi znak O ali X");
            char znak = Char.Parse(Console.ReadLine());
            return znak;
        }

        static char ComputerZnak() {
            char comp_znak;
            
            if (IzberiZnak() == 'O')
            {
                comp_znak = 'X';
            }
            else
            {
                comp_znak = 'O';
            }
            return comp_znak;
        }

        static int IzbiraStopnje() {
            int stopnja = 0; // 0 = Lahka(default), 1 = Inteligentna
            string izbira;
            Console.WriteLine("Izberi stopnjo: 'Lahka' ali 'Inteligenta'.");

            izbira = Console.ReadLine();
            if (izbira == "Lahka") {
                stopnja = 0;
            }
            else if(izbira == "Inteligentna"){
                stopnja = 1;
            }
            else {
                Console.WriteLine("Vnesel si nepravilno izbiro");
                Console.WriteLine("Možne izbire: - Lahka \n -Inteligentna.");
            }

            return stopnja;
        }

        static void Taktika() {
            if (IzbiraStopnje() == 0)
            {
                // generiranje random stevil v polje 
            }
            else // malo razmisljaj.
            {

            }

        }

        static void RisiPolje()
        {
            Console.WriteLine("-1-|--2--|-3-");
            Console.WriteLine("   |     |    ");
            Console.WriteLine("   |     |    ");
            Console.WriteLine("-4-|--5--|-6-");
            Console.WriteLine("   |     |    ");
            Console.WriteLine("   |     |    ");
            Console.WriteLine("-7-|--8--|-9-");
            Console.WriteLine("   |     |    ");
            Console.WriteLine("   |     |    ");
        }

        static char[] PisiVPolje(char lik)
        {
            char[] podlaga = new char[9];
            int index = 0;

            Console.WriteLine("Izberi na kam hoces vnesti znak.");
            index = int.Parse(Console.ReadLine());
            if (podlaga[index] != '\0') {
                podlaga[index] = IzberiZnak();
            }

            return podlaga;
        }

        static string PosodobiRisiPolje() {
            
            string prvi_del = "-1-|--2--|-3-\n";
            string drugi_del = "   |     |       \n";
            string tretji_del = "   |     |      \n";
            string cetrti_del = "-4-|--5--|-6-\n";
            string peti_del = "-7-|--8--|-9-";
            string slika = prvi_del + drugi_del + tretji_del + cetrti_del + tretji_del + tretji_del + peti_del + "\n" + tretji_del + tretji_del;

            /*
            Console.WriteLine("-1-|--2--|-3-");
            Console.WriteLine("   |     |    ");
            Console.WriteLine("   |     |    ");
            Console.WriteLine("-4-|--5--|-6-");
            Console.WriteLine("   |     |    ");
            Console.WriteLine("   |     |    ");
            Console.WriteLine("-7-|--8--|-9-");
            Console.WriteLine("   |     |    ");
            Console.WriteLine("   |     |    ");
            */
            return slika;

        }

        static void Main(string[] args)
        {


            //char crka; IzberiCrko

            /*
             * int igraj = True;
             *while(igraj) {
             *
             *   spilaj
             *   
             *   igreKonce()
             *   want to play again yes/no if no igraj = false => Exit();
             * } 
             * 
             * 
             * */


            Pozdrav();
            Console.WriteLine("Izberi znak O ali X");
            IzberiZnak();
            Console.WriteLine(PosodobiRisiPolje());
            //RisiPolje();
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
