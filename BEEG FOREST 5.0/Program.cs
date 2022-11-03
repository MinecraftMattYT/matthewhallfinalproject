using System.Runtime.InteropServices;
bool userZ = true;




if (userZ == true)
    Console.WriteLine(" ＢＥＥＧ ＦＯＲＥＳＴ");
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("Since you have bad decisioning skills you walk into a VERY suspicous forest");
Console.WriteLine("Also your names Bob.");
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("start?");

string userA = Console.ReadLine();


if (userA == "start") ;
{
    Console.WriteLine("You went into the forest");
    Console.WriteLine("");
    Console.WriteLine("Infront of you is more trees to the right of you is a cave");
    Console.WriteLine("Go forward or right?");
    string userB = Console.ReadLine();
    if (userB == "right")
    {
        Console.WriteLine("You decided not to go right and left the forest");
        Console.WriteLine("");
        Console.WriteLine("ENDING 4");
        Console.WriteLine("What a realistic ending!");
    }
    if (userB == "forward")
    {
        Console.WriteLine("You went forward");
        Console.WriteLine("Infront of you is a cabin to the right is more trees");
        Console.WriteLine("Go forward or right?");
        string userC = Console.ReadLine();
        if (userC == "right")
        {
            Console.WriteLine("You went right and then died");
            Console.WriteLine("");
            Console.WriteLine("ENDING 3");
            Console.WriteLine("wait what");
        }
        if (userC == "forward")
        {
            Console.WriteLine("You went to the cabin ");
            Console.WriteLine("Theres a table in the middle of the room with a cake on it");
            Console.WriteLine("infront of the table is the exit");
            Console.WriteLine("Eat the cake or go to the exit?");
            string userE = Console.ReadLine();
            if (userE == "exit")
            {
                Console.WriteLine("You left the cabin");
          Console.WriteLine("ifront of you is a suspicous cave and to the left of you is more trees");
                Console.WriteLine("Go forward or left?");
                string userSUS = Console.ReadLine();
                if (userSUS == "left")
                {
                    Console.WriteLine("You went left");
                    Console.WriteLine("infront of you is more trees to the left of you is a bottomless pit");
                    Console.WriteLine("go forward or left?");
                    string userP = Console.ReadLine();
                    if (userP == "forward")
                    {
                        Console.WriteLine("infront of you is more trees to the right of you is a table with dice on it");
                        Console.WriteLine("go forward or roll the dice?");
                        string userDice = Console.ReadLine();
                        if (userDice == "forward")
                        {
                            Console.WriteLine("infront of you is a BEEG mansion");
                            Console.WriteLine("Go inside?");
                            Console.WriteLine("yes or no");
                            string userMAN = Console.ReadLine();
                            if (userMAN == "yes")
                            {
                                Console.WriteLine("You went inside the mansion...");
                                Console.WriteLine("");
                                Console.WriteLine("CHAPTER 2 ");
                                Console.WriteLine("BEEG MANSION");
                                Console.WriteLine("");
                                Console.WriteLine("there are stairs to the left and to the right");
                                Console.WriteLine("right or left?");
                                string userMA = Console.ReadLine();
                                if (userMA == "left")
                                {
                                    Console.WriteLine("You went left and realized that theres only a window to the left");
                                    Console.WriteLine("");
                                    Console.WriteLine("ENDING 13");
                                    Console.WriteLine("Bob died of fall damage ...again");
                                }
                                if (userMA == "right")
                                {
                                    Console.WriteLine("You went up the stairs");
                                    Console.WriteLine("Theres a room to your left ");
                                    Console.WriteLine("Go left or forward?");
                                    string userGHOST = Console.ReadLine();
                                    if (userGHOST == "forward")
                                    {
                                        Console.WriteLine("You went forward");
                                        Console.WriteLine("Next to you there is a weird wall thats darker than the others ");
                                        Console.WriteLine("Go left or forward?");
                                        string userFOUND = Console.ReadLine();
                                        if (userFOUND == "forward")
                                        {
                                            Console.WriteLine("You went forward");
                                            Console.WriteLine("");
                                            Console.WriteLine("You walked into a kitchen");
                                            Console.WriteLine("to the left of you is a sink and to the right a door");
                                            Console.WriteLine("Go left or right?");
                                            string userSINK = Console.ReadLine();
                                            if (userSINK == "right")
                                            {
                                                Console.WriteLine("You went into a hallway");
                                                Console.WriteLine("Go forward?");
                                                Console.WriteLine("yes or no");
                                                string userFOR = Console.ReadLine();
                                                if (userFOR == "yes")
                                                {
                                                    Console.WriteLine("");
                                                    Console.WriteLine("You went into a bathroom");
                                                    Console.WriteLine("You feel a strong urge to flush yourself down the toilet");
                                                    Console.WriteLine("Do it?");
                                                    Console.WriteLine("yes or no");
                                                    string userFLU = Console.ReadLine();
                                                    if (userFLU == "yes")
                                                    {
                                                        Console.WriteLine("You flushed yourself down the toilet...");
                                                        Console.WriteLine("");
                                                        Console.WriteLine("CHAPTER 3");
                                                        Console.WriteLine("BEEG FINALE");
                                                        Console.WriteLine("");
                                                        Console.WriteLine("Go left or right?");
                                                        string userAC = Console.ReadLine();
                                                        if (userAC == "right")
                                                        {
                                                            Console.WriteLine("You went right and climbed up a ladder");
                                                            {
                                                                Console.WriteLine("You are now on the surface");
                                                                Console.WriteLine("To the left of you is a store and to the right a house");
                                                                Console.WriteLine("Go left or right?");
                                                                string STORE = Console.ReadLine();
                                                                if (STORE == "left")
                                                                {
                                                                    Console.WriteLine("You went into the store");
                                                                    Console.WriteLine("");
                                                                    Console.WriteLine("[The Cashier] Hey friend would you like to buy something?");
                                                                    Console.WriteLine("Ask for directions or buy something");
                                                                    Console.WriteLine("directions or buy?");
                                                                    string BUY = Console.ReadLine();
                                                                    if (BUY == "buy")
                                                                    {
                                                                        Console.WriteLine("You grab a rubber duck and go to the cashier");
                                                                        Console.WriteLine("");
                                                                        Console.WriteLine("[The Cashier] Thank you friend! if you want to continue forward DONT go right theres a pit of spikes there. exits right!");
                                                                        Console.WriteLine("You go right out of the store");
                                                                        Console.WriteLine("Go left or right");
                                                                        string BET = Console.ReadLine();
                                                                        if (BET == "right")
                                                                        {
                                                                            Console.WriteLine("You went right.");
                                                                            Console.WriteLine("");
                                                                            Console.WriteLine("You think you see the edge of the forest");
                                                                            Console.WriteLine("run or walk?");
                                                                            string END = Console.ReadLine();
                                                                            if (END == "walk")
                                                                            {
                                                                                Console.WriteLine("You walked out of the forest and stopped before falling off a cliff");
                                                                                Console.WriteLine("");
                                                                                Console.WriteLine("You see a village to your right ");
                                                                                Console.WriteLine("You go to it");
                                                                                Console.WriteLine("");
                                                                                Console.WriteLine("ENDING 20");
                                                                                Console.WriteLine("Good ending");
                                                                                Console.WriteLine("");
                                                                                Console.WriteLine("Once you have all the hints combine them and type them at ending 02!");
                                                                            }
                                                                            if (END == "run")
                                                                            {
                                                                                Console.WriteLine("You ran out of the forest but fell off a cliff before you could stop");
                                                                                Console.WriteLine("");
                                                                                Console.WriteLine("ENDING 19");
                                                                                Console.WriteLine("Bad ending");
                                                                            }
                                                                        }
                                                                        if (BET == "left")
                                                                        {
                                                                            Console.WriteLine("You went left and fell into a pit of spikes");
                                                                            Console.WriteLine("");
                                                                            Console.WriteLine("ENDING 17");
                                                                            Console.WriteLine("Cashiers betrayal");
                                                                        }
                                                                    }
                                                                    if (BUY == "directions")
                                                                    {
                                                                        while (BUY == "directions")
                                                                        {
                                                                            Console.WriteLine("THERE IS NO ESCAPE");
                                                                        }
                                                                    }
                                                                }
                                                                if (STORE == "right")
                                                                {
                                                                    Console.WriteLine("You went into the house and the floor broke!");
                                                                    Console.WriteLine("");
                                                                    Console.WriteLine("ENDING 16");
                                                                    Console.WriteLine("Bob fell from a high place");
                                                                }

                                                            }
                                                        }
                                                        if (userAC == "left")
                                                        {
                                                            Console.WriteLine("You went left and then fell into a acid pit");
                                                            Console.WriteLine("");
                                                            Console.WriteLine("ENDING 18");
                                                            Console.WriteLine("ded");
                                                           
                                                        }

                                                    }
                                                    if (userFLU == "no")
                                                    {
                                                        Console.WriteLine("FINE");
                                                        Console.WriteLine("YOU DIED");
                                                        Console.WriteLine("");
                                                        Console.WriteLine("ENDING 15");
                                                        Console.WriteLine("YOU DIED");
                                                    }
                                                }
                                            if (userFOR == "no")
                                                {
                                                    Console.WriteLine("No..?");
                                                    Console.WriteLine("ok fine");
                                                    Console.WriteLine("");
                                                    Console.WriteLine("ENDING 14");
                                                    Console.WriteLine("no");
                                                }
                                            }
                                            if (userSINK == "left")
                                               {
                                                Console.WriteLine("You turned on the sink");
                                                Console.WriteLine("");
                                                Console.WriteLine("ENDING 12");
                                                Console.WriteLine("You turned on the sink");
                                            }
                                        }
                                        if (userFOUND == "left")
                                        {
                                            Console.WriteLine("You touched the wall and noclipped into the backrooms!");
                                            Console.WriteLine("");
                                            Console.WriteLine("ENDING 11");
                                            Console.WriteLine("Found footage");
                                        }
                                    }
                                        if (userGHOST == "left")
                                    {
                                        Console.WriteLine("You went inside the room ");
                                        Console.WriteLine("Theres a closet to your left and a box of toys to your right");
                                        Console.WriteLine("Go left or right?");
                                        string userTOY = Console.ReadLine();
                                        if (userTOY == "right")
                                        {
                                            Console.WriteLine("You opened the closet suddenly!");
                                            Console.WriteLine("");
                                            Console.WriteLine("Psst");
                                            Console.WriteLine("You didnt look fast enough and the monster ate you");
                                            Console.WriteLine("");
                                            Console.WriteLine("ENDING 10");
                                            Console.WriteLine("the screech");
                                            Console.WriteLine("");
                                            Console.WriteLine("Hi your last hint is CRAB");
                                        }
                                        if (userTOY == "left")
                                        {
                                            Console.WriteLine("You opened the box of toys");
                                            Console.WriteLine("");
                                            Console.WriteLine("A toy jumped at you at ate your face!");
                                            Console.WriteLine("");
                                            Console.WriteLine("ENDING 9");
                                            Console.WriteLine("From now on, you must take good care of your toys. Because if you don't, we'll find out, Bob. We toys can see everything.   ");
                                            Console.WriteLine("So play nice.");

                                        }
                                    }
                                }
                            }
                            if (userMAN == "no") 
                            {
                                Console.WriteLine("");
                                Console.WriteLine("A ghost didnt like your attitude and turned you into a bean!");
                                Console.WriteLine("");
                                Console.WriteLine("ENDING 8");
                                Console.WriteLine("bro got turned into a bean");
                                Console.WriteLine("");
                                Console.WriteLine("Hey your second hit (or this might be your first or third idk) The middle of it is LY");
                            }
                        }
                        if (userDice == "roll")
                        {
                            Random random = new Random();

                            random.Next(1, 7);
                            if (random.Next(1, 7) < 6)
                            {
                                Console.WriteLine("aww no six :(");
                                Console.WriteLine("");
                                Console.WriteLine("ENDING 7");
                                Console.WriteLine("no six :(");

                            }
                            if (random.Next(1, 7) == 6)

                            {
                                    Console.WriteLine("Lucky you! you got a six!");
                                    Console.WriteLine("TO LUCKY");
                                    Console.WriteLine("");
                                    Console.WriteLine("ENDING 6");
                                    Console.WriteLine("Bob was slain by the program");
                                

                            }
                        }
                    }
                    if (userP == "left")
                    {
                        for (int i = 0; i < 10000; i++)
                        {
                            Console.WriteLine("Your falling");
                          
                        }
                    }
                }
                if (userSUS == "forward")
                {
                    Console.WriteLine("You figured out why the cave was suspicous and then died of cringe");
                    Console.WriteLine("");
                    Console.WriteLine("ENDING 1");
                    Console.WriteLine("*sigh* among us.");
                }


            }
            if (userE == "eat")
            {
                Console.WriteLine("You ate the cake and it was poisonous");
                Console.WriteLine("");
                Console.WriteLine("ENDING 02");
                Console.WriteLine("The cake is a lie");
                Console.WriteLine("");
                Console.WriteLine("Since this is related to the secret ending your first hint is it starts with WHEAT");
                string userWHEAT = Console.ReadLine();
                if (userWHEAT == "WHEATLEYCRAB")
                {
                    Console.WriteLine("Suddenly an army of wheatley crabs take you to their king");
                    Console.WriteLine("The king deems you unworthy of his presence and your executed");
                    Console.WriteLine("ENDING 0");
                    Console.WriteLine("WHEATLEY");
                }

            }
        }
    }
}

int aInt;

float aFloat;