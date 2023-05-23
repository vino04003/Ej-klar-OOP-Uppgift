using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Batman ba = new Batman();
            Joker jo = new Joker();
            bool batmanFleeing = false;
            bool fightJoker = false;
            string status = "Start scene";

            Console.WriteLine("Welcome to Gotham city. You will need to save the city from the Joker");
            Console.WriteLine("Press Y if you choose to fight. Press N if you decide to flee");
            Console.WriteLine("REMEMBER, YOU ARE THE BATMAN!!!");
            Console.WriteLine("------------------------------------------------------");
             Console.WriteLine($"Batman health {jo.BAcurrentLife}"); //printar batmans liv
            Console.WriteLine($"Joker health {jo.JOcurrentLife}"); //printar jokers liv
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Status: " + status);
            string Scene1 = Console.ReadLine();

            if (Scene1 == "Y")
            {
                fightJoker = true;
                batmanFleeing = false;
            }
            else if (Scene1 == "N")
            {
                fightJoker = false;
                batmanFleeing = true;
                Console.WriteLine("Sooo, you decided to flee pussy!");
            }
            else
            {
                Console.WriteLine("You gotta pick either Y or N");
                return;
            }

              if(fightJoker == true)
            {
                Console.WriteLine("Let's fight THE JOKER");
                Console.WriteLine("You threw your bat star at the joker and wounded him badly");
                ba.Attack(); //batman attackerar
                ba.DealDamage("Joker"); // printar hur mycket batman skadar joker
                status = "In battle";
                Console.WriteLine("Status: " + status);
            }
            else if (batmanFleeing == true)
            {
                Console.WriteLine("You decided to flee because you belive in peace. How did that turn out for THE so called BATMAN...");
                status = "Dead";
                Console.WriteLine("Status: " + status);
                return;
            }

            jo.Attack(); //joker takes big damage
            Console.WriteLine("Noo aguhhhh");
            Console.WriteLine($"Jokers health after Batmans attack {jo.JOcurrentLife}"); // printar jokers liv efter attacken

            Console.WriteLine("The Joker was very upset with your behaiveor and gets very angry.");
            Console.WriteLine("Press Y to stand and fight or N to flee");
            status = "Due or die";
            string Scene2 = Console.ReadLine();

             if (Scene2 == "Y")
        {
            Console.WriteLine("You decided to stay and fight but that didn't turn out so good. Joker whispers");
            Console.WriteLine("my turn..."); 
            jo.DealDamage("Batman"); //vissar hur mycket joker skadar batman

            Console.WriteLine("Batman gets stabbed and gets very hurt");

            jo.batmanAttack(); //subbtraherar attacken från batmans liv
            Console.WriteLine($"Batmans health is now {jo.BAcurrentLife}"); //printar ut batmans liv efter attacken
            status = "Gotham City";
            Console.WriteLine("Status: " + status);
        }
        else if (Scene2 == "N")
        {
            Console.WriteLine("So you decided to flee from the jokers");
            Console.WriteLine("HAHAHAHAHAHAHAH");
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("JOKES on you, says the joker.");
            Console.WriteLine("There is no running from THE JOKER.");
            jo.DealDamage("Batman"); //jokers deal damage to batman

            Console.WriteLine("BAtman gets stabbed and gets very hurt");

            jo.batmanAttack(); //subbtraherar från batmans liv
            Console.WriteLine($"Batmans health is now {jo.BAcurrentLife}"); //printar ut batmans liv
            Console.WriteLine("BAtman feels cold and starts to cry.");
            status = "Not dead but sad";
            Console.WriteLine("Status: " + status);
            return;
        }

            Console.WriteLine("My turn, says the Joker"); 
            jo.DealDamage("Batman"); //jokers deal damage to batman

            jo.batmanAttack(); //subbtraherar från batmans liv
            Console.WriteLine($"Batmans health is now {jo.BAcurrentLife}"); //printar ut batmans liv
        }
    }
}
//koden är ej klar, det är vissa saker som behöver fixas som poäng systemet, poäng filen och lite annat. Kanske förbättra karaktärernas egenskaper och få en bättre story. 
//Samt fixa så att man kan skriva ut allt i terminalen. Bättre att lämna in något än inget. 
