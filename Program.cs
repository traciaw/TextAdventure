using System;
using System.Threading.Tasks;

namespace ChooseYourOwnAdventure
{
    class Program
    {
        public static List<string> MainMethodArgs = new List<string>();
        static void Main(string[] args)
        {
            MainMethodArgs = args.ToList();
            Run(MainMethodArgs.ToArray());
        }

        public static void ReStart()
        {
            Console.WriteLine("Try Again? Press R to restart the game...");
            string restart = Console.ReadLine();
            if (restart.ToUpper() == "R")
            {
                Run(MainMethodArgs.ToArray());
            }
        }

        public static void Run(string[] arg)
        {
            Console.Clear();
            // Start by asking for the user's name:
            Console.Write("What is your name?: ");
            string name = Console.ReadLine();
            Thread.Sleep(1000);
            Console.WriteLine($"{name}~~ {name}~~ BOOM!");
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.WriteLine($"{name}~~ {name}~~ BOOM!");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine($"{name}~~ {name}~~ BOOM!");
            Console.Clear();
            Console.WriteLine($"{name}~~ {name}~~ BOOM!");
            Thread.Sleep(1000);
            Console.WriteLine("Thunder boomed in the distance.You woke up in an unfamilar cave. Looks like it will rain soon.");
            Console.WriteLine("Do you choose to stay in the cave?");
            Console.Write("Type YES or NO: ");
            string StayCave = Console.ReadLine().ToUpper();
            if (StayCave == "NO" || StayCave == "N")
            {
                Console.Clear();
                Console.WriteLine("You choose to leave the cave.");
                Console.WriteLine("Whoever brought me here might return soon. We should leave now!");
                Thread.Sleep(1000);
                Console.WriteLine("You creeped out of the cave. Straight ahead you see a town in the distance.");
                Console.WriteLine("On your left, you see a crooked-looking cottage.");
                Console.Write("Type 1 to walk towards the TOWN or 2 to go towards the COTTAGE: ");
                string PathChoice = Console.ReadLine().ToUpper();
                switch(PathChoice)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("You set out for the town in the distance");
                        Town();
                        Console.WriteLine(" ");
                        Console.WriteLine("'BOOM!' Thunder roared overhead and dark clouds spat out beads of water.");
                        Thread.Sleep(1000);
                        Console.WriteLine("Ahead you spotted a figure holding an umbrella beckoning you over.");
                        Thread.Sleep(1000);
                        Console.Write("Type 1 to APPROACH the figure or 2 to IGNORE and continue walking: ");
                        string FigureChoice = Console.ReadLine().ToUpper();
                        if(FigureChoice=="1")
                        {
                            Console.Clear();
                            Console.WriteLine("You approach the figure...");
                            Thread.Sleep(1000);
                            Console.WriteLine("As you get closer, you saw that the figure was an eyeless abomination with seven mouths...");
                            Thread.Sleep(2000);
                            Slip();
                            Wake();
                        }
                        else if(FigureChoice=="2")
                        {
                            Console.Clear();
                            Console.WriteLine("One should avoid strangers....");
                            Thread.Sleep(2000);
                            Slip();
                            Wake();
                        }
                        else
                        {ShitTyping();}
                    break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("You set out for cottage");
                        Thread.Sleep(1000);
                        Cottage();
                        Console.WriteLine("It looks abandoned...");
                        Thread.Sleep(2000);
                        Console.WriteLine("Should you walk through the front entrance or sneak around the back?");
                        Thread.Sleep(1000);
                        Console.Write("Type 1 to WALK through the entrance or or 2 to SNEAK around: ");
                        string WalkSneakChoice = Console.ReadLine().ToUpper();
                        if(WalkSneakChoice=="1")
                        {
                            Console.WriteLine("You walked into the dark cottage");
                            Thread.Sleep(1000);
                            Console.WriteLine("The wooden flooring creaks with every step...");
                            Thread.Sleep(1000);
                            WhisperRiddle();
                        }
                        else if(WalkSneakChoice=="2")
                        {
                            Console.Clear();
                            Thread.Sleep(1000);
                            Console.WriteLine("You choose to sneak around instead");
                            Thread.Sleep(2000);
                            Slip();
                            Wake();
                        }
                        else {ShitTyping();}
                    break;
                    default:
                    ShitTyping();
                    break;
                }
            }
            else if (StayCave == "YES"|| StayCave == "Y")
            {
                Console.Clear();
                Console.WriteLine("You choose to stay within the cave.");
                Thread.Sleep(2000);
                Console.WriteLine("The thunder is deafening outside. Staying sheltered is obviously the better choice.");
                Thread.Sleep(1000);
                Console.WriteLine("You spotted a narrow passageway within the cave. Should you explore?");
                Thread.Sleep(1000);
                Console.Write("Type 1 to EXPLORE or 2 to STAY where you are:");
                string PassagewayChoice = Console.ReadLine().ToUpper();
                if (PassagewayChoice == "1")
                {
                    Console.Clear();
                    Console.WriteLine("You squeezed into the damp passageway...");
                    Thread.Sleep(1000);
                    WhisperRiddle();
                }//PassagewayChoice == "1" END
                else if (PassagewayChoice == "2")
                {
                    Console.Clear();
                    Console.WriteLine("You look around and see an off drawing on the far side of the cave.");
                    Thread.Sleep(2000);
                    Console.WriteLine("Weird...The face looks like a... Monster/Ghost/Bug/Skeleton?");
                    Thread.Sleep(1000);
                    Console.WriteLine("Enter a number (1-4): ");
                    Console.WriteLine("1: Monster");
                    Console.WriteLine("2: Ghost");
                    Console.WriteLine("3: Bug");
                    Console.WriteLine("4: Skeleton");
                    Console.Write(" ");
                    string HeadChoice= Console.ReadLine().ToUpper();
                    switch (HeadChoice)
                    {
                        case "1":
                            Thread.Sleep(3000);
                            MonsterHead();
                            Console.WriteLine(" ");
                            Thread.Sleep(2000);
                            Console.WriteLine("'GRRRRRAAAA!!!' You turn to see a dark shadowy figure behind you. You should have left..");
                            Console.WriteLine(" ");
                            Thread.Sleep(2000);
                            BuildACreature("Monster","Monster","Monster");
                            Console.WriteLine("    THE END");
                            ReStart();
                            
                            break;
                        case "2":
                            Thread.Sleep(3000);
                            GhostHead();
                            Console.WriteLine("  ");
                            Thread.Sleep(2000);
                            Console.WriteLine("'GRRRRRAAAA!!!' You turn to see a dark shadowy figure behind you.");
                            Console.WriteLine("You should have left..");
                            Console.WriteLine(" ");
                            Thread.Sleep(2000);
                            BuildACreature("Ghost","Ghost","Ghost");
                            Console.WriteLine("    THE END");
                            ReStart();
                            break;
                        case "3":
                            Thread.Sleep(3000);
                            BugHead();
                            Console.WriteLine(" ");
                            Thread.Sleep(2000);
                            Console.WriteLine("'GRRRRRAAAA!!!' You turn to see a dark shadowy figure behind you. You should have left..");
                            Console.WriteLine("You should have left..");
                            Console.WriteLine(" ");
                            Thread.Sleep(2000);
                            BuildACreature("Bug","Bug","Bug");
                            Console.WriteLine("    THE END");
                            ReStart();
                            break;
                        case "4":
                            Thread.Sleep(3000);
                            SkeletonHead();
                            Console.WriteLine("  ");
                            Thread.Sleep(2000);
                            Console.WriteLine("'GRRRRRAAAA!!!' You turn to see a dark shadowy figure behind you. You should have left..");
                            Console.WriteLine("You should have left..");
                            Console.WriteLine(" ");
                            Thread.Sleep(2000);
                            BuildACreature("Skeleton","Skeleton","Skeleton");
                            Console.WriteLine("     THE END");
                            ReStart();
                            break;
                        default:
                            ShitTyping();
                            break;
                    };//HeadChoice end

                }//PassagewayChoice == "2" END
                else { ShitTyping(); }
            }//StayCave == "YES" END
            else
            { ShitTyping();}//StayCave == "Invalid" END
        }

        //STORY Shortcuts
        static void ShitTyping()//When user cant type right. END GAME
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("Your vision blurs... You obviously can't think right. You feel an ominous aura behind you...");
            Thread.Sleep(2000);
            Console.WriteLine("The last thing you see was a monster before the darkness swallows you.");
            Thread.Sleep(2000);
            RandomMonsterMode();
            Console.WriteLine("      THE END");
            ReStart();
        }
        static void WhisperRiddle()
        {
            Console.WriteLine("A voice behind you whispers...");
            Thread.Sleep(1000);
            Console.WriteLine("It says, 'Answer this riddle: What is so fragile that saying its name breaks it?'");
            Console.Write("Type your answer: ");
            string riddleAnswer = Console.ReadLine().ToUpper();
            if (riddleAnswer.Contains("SILENCE")||riddleAnswer.Contains("SILENT")||riddleAnswer.Contains("QUIET"))
            {
                Console.Clear();
                Console.WriteLine("The same voice replies:'You answered correctly.You are safe mortal. For now...'");
                Thread.Sleep(2000);
                Console.WriteLine("You turn around and see a mouse scurrying away into the cracks...'");
                Thread.Sleep(1000);
                Mouse();
                Thread.Sleep(1000);
                Console.WriteLine("Turning back, you see a bottle with the label 'DRINK ME!' and a box of cookies with the label 'EAT ME!'");
                Console.WriteLine("Do you reach out for the BOTTLE or COOKIES first?");
                Console.Write("Type your answer: ");
                string FoodChoice = Console.ReadLine().ToUpper();
                if (FoodChoice.Contains("BOTTLE")||FoodChoice.Contains("DRINK"))
                {
                    Console.Clear();
                    Console.WriteLine("You choose to drink from tiny bottle.");
                    Console.WriteLine("");
                    Thread.Sleep(1000);
                    Drink();
                    Console.WriteLine($"The liquid that hit your tongue was thick and slimy. ");
                    Thread.Sleep(1000);
                    Console.WriteLine($"                                                      EWWW....");
                    Thread.Sleep(2000);
                    Console.WriteLine("The head starts to spin.. Oh no...");
                    Wake();
                }
                else if(FoodChoice.Contains("COOKIE")||FoodChoice.Contains("EAT")||FoodChoice.Contains("BOX"))
                {
                    Console.Clear();
                    Cookie();
                    Console.WriteLine("Choosing to eat from the box of cookies, you found it dry and chalky.");
                    Thread.Sleep(1000);
                    Console.WriteLine("                                                                      YUCK!");
                    Console.WriteLine("");
                    Thread.Sleep(2000);
                    Console.WriteLine("The head starts to spin.. Oh no...");
                    Thread.Sleep(2000);
                    Wake();
                }
                else
                {ShitTyping();}
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                Console.WriteLine("'Incorrect', the same voice whispers. The last thing you see was a monster before the darkness took you.");
                Thread.Sleep(1000);
                RandomMonsterMode();
                Console.WriteLine("     THE END");
                ReStart();
            }
        }
        static void Slip()
        {
            Console.WriteLine("'CLICKED!'");
            Thread.Sleep(2000);
            Console.WriteLine("You didn't see the bear trap on the ground as it clamps into your leg...");
            Thread.Sleep(1000);
            Console.WriteLine("AHHHHH!!");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.WriteLine("AHHHHH!!");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("AHHHHH!!");
            Thread.Sleep(5000);
        }
        static void Wake()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("You woke with a start in your bedroom.");
            Console.WriteLine("That was a weird dream...");
            Thread.Sleep(2000);
            Console.WriteLine("In the corner of your eye, a dark shadowy figure creeps");
            Thread.Sleep(1000);
            Console.WriteLine("                                                         pass");
            Thread.Sleep(1000);
            Console.WriteLine("                                                             the");
            Thread.Sleep(1000);
            Console.WriteLine("                                                                 door...");
            Thread.Sleep(2000);
            RandomMonsterMode();
            Console.WriteLine("      THE END");
            ReStart();
        }
        //MONSTER PARTS
        static void BuildACreature(string head, string body, string feet)
        {
            int headNum = TranslateToNumber(head);
            int bodyNum = TranslateToNumber(body);
            int feetNum = TranslateToNumber(feet);
            SwitchCase(headNum, bodyNum, feetNum);
        }
        static void RandomMonsterMode()
        {
            Random randomNumber = new Random();
            int head = randomNumber.Next(1, 4);
            int body = randomNumber.Next(1, 4);
            int feet = randomNumber.Next(1, 4);
            SwitchCase(head, body, feet);
        }
        static void SwitchCase(int head, int body, int feet)
        {
            switch (head)
            {
                case 1:
                    MonsterHead();
                    break;
                case 2:
                    GhostHead();
                    break;
                case 3:
                    BugHead();
                    break;
                case 4:
                    SkeletonHead();
                    break;
                default:
                    Console.WriteLine("Invalid response!");
                    break;
            }
            switch (body)
            {
                case 1:
                    MonsterBody();
                    break;
                case 2:
                    GhostBody();
                    break;
                case 3:
                    BugBody();
                    break;
                case 4:
                    SkeletonBody();
                    break;
                default:
                    Console.WriteLine("Invalid response!");
                    break;
            }
            switch (feet)
            {
                case 1:
                    MonsterFeet();
                    break;
                case 2:
                    GhostFeet();
                    break;
                case 3:
                    BugFeet();
                    break;
                case 4:
                    SkeletonFeet();
                    break;
                default:
                    Console.WriteLine("Invalid response!");
                    break;
            }
        }
        static int TranslateToNumber(string creature)
        {
            switch (creature)
            {
                case "Monster":
                    return 1;

                case"Ghost":
                    return 2;

                case "Bug":
                    return 3;

                case "Skeleton":
                    return 4;

                default:
                    return 1;

            }
        }
        static void GhostHead()
        {
            Console.WriteLine("     ..-..");
            Console.WriteLine("    ( o o )");
            Console.WriteLine("    |  O  |");
        }

        static void GhostBody()
        {
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
        }

        static void GhostFeet()
        {
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
            Console.WriteLine("    '~~~~~'");
        }

        static void BugHead()
        {
            Console.WriteLine("     /   \\");
            Console.WriteLine("     \\. ./");
            Console.WriteLine("    (o + o)");
        }

        static void BugBody()
        {
            Console.WriteLine("  --|  |  |--");
            Console.WriteLine("  --|  |  |--");
            Console.WriteLine("  --|  |  |--");
        }

        static void BugFeet()
        {
            Console.WriteLine("     v   v");
            Console.WriteLine("     *****");
        }

        static void MonsterHead()
        {
            Console.WriteLine("     _____");
            Console.WriteLine(" .-,;='';_),-.");
            Console.WriteLine("  \\_\\(),()/_/");
            Console.WriteLine("　  (,___,)");
        }

        static void MonsterBody()
        {
            Console.WriteLine("   ,-/`~`\\-,___");
            Console.WriteLine("  / /).:.('--._)");
            Console.WriteLine(" {_[ (_,_)");
        }

        static void MonsterFeet()
        {
            Console.WriteLine("    |  Y  |");
            Console.WriteLine("   /   |   \\");
            Console.WriteLine("   \"\"\"\" \"\"\"\"");
        }

        static void SkeletonHead()
        {
            Console.WriteLine("      .-.");
            Console.WriteLine("     (o.o)");
            Console.WriteLine("      |=|");
        }

        static void SkeletonBody()
        {
            Console.WriteLine("     __|__");
            Console.WriteLine("   //.=|=.\\");
            Console.WriteLine("  // .=|=. \\");
            Console.WriteLine("  \\ .=|=. //");
            Console.WriteLine("   \\(_=_)//");
        }

        static void SkeletonFeet()
        {
            Console.WriteLine("    (:| |:)");
            Console.WriteLine("     || ||");
            Console.WriteLine("     () ()");
            Console.WriteLine("     || ||");
            Console.WriteLine("     || ||");
            Console.WriteLine("    ==' '==");
        }

        static void Mouse()
        {
            Console.WriteLine("()(),~~,.");
            Console.WriteLine(" .. ___; )");
            Console.WriteLine("=`=     (_.  ");

        }

        static void Drink()
        {
            Console.WriteLine(" {_}");
            Console.WriteLine(" |(|");
            Console.WriteLine(" |=|");
            Console.WriteLine("/   |");
            Console.WriteLine("|.--|");
            Console.WriteLine("||  |");
            Console.WriteLine("||  | ");
            Console.WriteLine("|'--| ");
            Console.WriteLine("'-=-'");
        }
        static void Cookie()
        {
            Console.WriteLine("              _,._             ");
            Console.WriteLine("         __.o`   o`'-.         ");
            Console.WriteLine("      .-O o `'-.o   O )_,._    ");
            Console.WriteLine("     ( o   O  o )--.-'`O   o'-.");
            Console.WriteLine("      '--------'  (. o  O    o) ");
            Console.WriteLine("                   `----------`");
        }
        static void Cottage()
        {
            Console.WriteLine(" (')) ^v^  _           (`)_");
            Console.WriteLine("(__)_) ,--j j-------, (__)_)");
            Console.WriteLine("      /_.-.___.-.__/  |");
            Console.WriteLine("    ,8| [_],-.[_] | oOo");
            Console.WriteLine(",,,oO8|_o8_|_|_8o_|&888o,,,");
        }
        static void Town()
        {
            Console.WriteLine("            |   _   _");
            Console.WriteLine("      . | . x .|.|-|.|");
            Console.WriteLine("   || ./.|-/.|-|.|.|.|");
            Console.WriteLine("~~~|.|_|.|_|.|.|.|_|.|~~~");

        }
    };
};