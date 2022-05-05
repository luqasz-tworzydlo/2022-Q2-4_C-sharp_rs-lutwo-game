using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rs_lutwo_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //The_Beginning(); // zawiera 3 instrukcje
            // kolejna klasa zawiera 7 instrukcji ( ukryte w klasie The_Beggining )
            // jeszcze kolejna klasa zawiera 5 instrukcji ( dotyczy klasy Main_Quest_A )
            // w jeszcze innej klasie zawierają się 4 instrukcje ( dotyczy klasy Main_Quest_B )
            // ostatnia klasa Main_Quest zawieraja w sobie 3 instrukcje ( dotyczy klasy Main_Quest_C )
            Main_Quest_C.The_Final_Encounter();

            Console.ReadKey();
        }
        static void The_Beginning()
        {
            // trzy instrukcje, pierwotnie zaimplementowane w klasie Program
            // zostały przeniesione do nowej klasy, nazwanej Beginning
            // [ zrobiono to w celu lepszej przejrzystości kodu ]
            Beginning.Start_End_Game();
        }
    }
}
