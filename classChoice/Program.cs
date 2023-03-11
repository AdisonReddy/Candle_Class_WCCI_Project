using classOfMyChoice;

Candle usersCandle = new Candle("", "", "", "", false, "");  //instantiates new candle


bool keepThinking = true;  // variable to control menu While loop
while (keepThinking)
{
    Console.Clear();
    Console.WriteLine("WELCOME TO ADISON'S CANDLE SHOP!!\n");
    Console.WriteLine("create your candle below\n");
    Console.WriteLine("1. What's the name of your candle?");
    Console.WriteLine("2. What color's your candle?");
    Console.WriteLine("3. What's it smell like?");
    Console.WriteLine("4. How big's your candle,Small,Medium,or Large");
    Console.WriteLine("5. Put your candle on the shelf.");
    Console.WriteLine("6. Light your candle");
    Console.WriteLine("7. Put the candle out");
    Console.WriteLine("Type Exit to leave the shop.");
    string userChoice = Console.ReadLine().ToLower();
    switch (userChoice)
    {
        case "1":
            usersCandle.NameYourCandle();
            break; 
        case "2":
            usersCandle.CandleColor();
            break;
        case "3":
            usersCandle.CandleScent();
            break;
        case "4":
            usersCandle.CandleSize();
            break;
        case "5":
            usersCandle.PutItOnTheShelf();
            break;
        case "6":
             usersCandle.LightMe();
             break;
        case "7":
            usersCandle.PutMeOut();
            break;
        case "exit":
            keepThinking = false;  // stops the menu while loop when user types in exit
            Console.Clear();
            Console.WriteLine("Bye, Thanks for stopping by, come back soon.");
            break;
        default:
            break;
    }
}

