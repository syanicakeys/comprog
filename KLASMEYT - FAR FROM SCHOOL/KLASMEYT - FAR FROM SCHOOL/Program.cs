﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace KLASMEYT___FAR_FROM_SCHOOL
{
    
        class Program
        {
            static string school = @"           .
          /_\
          |Q|
    .-----' '-----.                                 
   /___[ADAMSON]___\                              O 
    | [] .-.-. [] |                              /|\                       
  ..|____|_|_|____|............................  / \";

            static string text = @"  _  ___                                _                                    
 | |/ / | __ _ ___ _ __ ___   ___ _   _| |_ _                                
 | ' /| |/ _` / __| '_ ` _ \ / _ \ | | | __(_)                               
 | . \| | (_| \__ \ | | | | |  __/ |_| | |_ _                                
 |_|\_\_|\__,_|___/_|_|_| |_|\___|\__, |\__(_)____       _                 _ 
 |  ___|_ _ _ __  |  ___| __ ___  |___/___   / ___|  ___| |__   ___   ___ | |
 | |_ / _` | '__| | |_ | '__/ _ \| '_ ` _ \  \___ \ / __| '_ \ / _ \ / _ \| |
 |  _| (_| | |    |  _|| | | (_) | | | | | |  ___) | (__| | | | (_) | (_) | |
 |_|  \__,_|_|    |_|  |_|  \___/|_| |_| |_| |____/ \___|_| |_|\___/ \___/|_|
                                                                             ";
            static string title = "Klasmeyt: Far From School";
            static string[] unlockeaster = new string[] { "observe", "A", "A", "take", "W", "W", "W", "D" }; //sequence
            static List<string> playerchoice = new List<string>(); //track choice ng player
                                                                   //make sure to have another copy when continue na eto HUHUH 
            static string name;
            static string choice;
            static int moves = 0;
            static double sanity = 80;  //starting sanity



            static void Main(string[] args)
            {


                PlayGame();



            }

            static void PlayGame()
            {
                Introduction();
                HomeScene();
                Kalaw();


            }

            //INTRODUCTION
            static void Introduction()
            {
                Console.WriteLine(school);
                Console.WriteLine(text);
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine($"Welcome to {title}, an interactive text-based adventure where you’ll\n" +
                     $"navigate the bustling streets and intricate pathways on the way \n" +
                     $"to Adamson University. As Klasmeyt, your journey is not a \n" +
                     $"simple task; it’s a psychological odyssey fraught with challenges.");
                Console.WriteLine("\nPress any key...");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("To navigate through the game, only enter \n" +
                    "the words you see in between the brackets [-----].");
                Console.WriteLine("\nIf at any point you feel like exiting the game, just type \"quit\". ");
                Console.WriteLine("\nYou may also opt to restart the game, just type \"restart\". ");
                Console.WriteLine("\nPress any key...");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Your choices will impact Klasmeyt’s mindset and progress.\n\n" +
                    "Your sanity level is also crucial. Make sure that Klasmeyt does not get their sanity below 20% \n" +
                    "to be able to progress through the game.");

                Console.WriteLine("\nAdditionally, your goal is to reach Adamson in as few moves as possible.\n" +
                    "each ROUTE you make will be a move, so choose wisely.");

                Console.WriteLine("\nPress any key...");
                Console.ReadKey();
                EnterName();

            }

            static void EnterName()
            {

                bool isValidName = false;

                while (!isValidName)
                {
                    Console.Clear();
                    Console.WriteLine("Enter Klasmeyt’s name to start your adventure....");
                    Console.Write("\n> ");

                    name = Console.ReadLine().ToUpper().Trim();

                    if (string.IsNullOrWhiteSpace(name))
                    {
                        Console.Clear();
                        Console.WriteLine("Enter Klasmeyt’s name to start your adventure....");
                        Console.WriteLine("\nPlease enter a valid name.");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine($"\nAre you sure to set Klasmeyt to {name}?");
                        Console.WriteLine("[Y] or [N]");
                        Console.Write("\n> ");
                        string choice = Console.ReadLine().ToUpper();

                        switch (choice)
                        {
                            case "Y":
                                Console.WriteLine($"\nHello Klasmeyt {name}. Good luck on your journey to Adamson University.");
                                Console.ReadKey();
                                isValidName = true;
                                break;

                            case "N":
                                // Continue loop to enter name again
                                break;

                            default:
                                Console.WriteLine("\nInvalid option. Try again.");
                                Console.ReadKey();
                                break;
                        }
                    }
                }
            }
            static void FasterEffect(string text)
            {
                foreach (char c in text)
                {
                    Console.Write(c);
                    Task.Delay(90).Wait(); // Adjust the delay time as desired
                }
            }
            static void HomeScene()
            {
                Console.Clear();
                CheckSanity();
                Console.WriteLine("Location: Home\n" +
                                  "Sanity: --\n" +
                                  "Number of Moves: --");
                Console.WriteLine("\n------------------------------\n");
                Console.WriteLine($"It is the finals season at Adamson University, and everyone is busy preparing\n" +
              $"for the exams as the semester is about to end. This includes {name}, a scholar at Adamson University.\n" +
              $"The final term weighs the heaviest percentage, triumphing over the prelims and the midterms.\n" +
              $"{name} must pass their final examination to maintain their grade and keep their scholarship,\n" +
              $"so they decided to stay up and review with vigor; after they were satisfied, they proceeded\n" +
              $"to get some rest.");


                Console.WriteLine("\nPress any key...");
                 Console.ReadKey();

                Console.Clear();
                CheckSanity();
                Console.WriteLine("Location: Home\n" +
                                  "Sanity: --\n" +
                                  "Number of Moves: --");
                Console.WriteLine("\n------------------------------\n");
            Console.WriteLine($"It is the finals season at Adamson University, and everyone is busy preparing\n" +
        $"for the exams as the semester is about to end. This includes {name}, a scholar at Adamson University.\n" +
        $"The final term weighs the heaviest percentage, triumphing over the prelims and the midterms.\n" +
        $"{name} must pass their final examination to maintain their grade and keep their scholarship,\n" +
        $"so they decided to stay up and review with vigor; after they were satisfied, they proceeded\n" +
        $"to get some rest.");

            Task.Delay(1200);
                FasterEffect("\nBEEP!....BEEP!...BEEP!....BEEP!");

                Console.WriteLine($"\n\nStill groggy from staying up, they switched to their side and looked at their clock, stating\n" +
                    $"\"6:13 AM\". OH NO! THEY SLEPT THROUGH THEIR ALARM!!");

                Console.WriteLine($"\nThey have an exam, and they are running late. {name} hurriedly got ready\n" +
                    $"and headed to Kalaw Avenue.");


                Console.ReadKey();
            }


            static bool KalawScene = false;

            static void Kalaw()

            {
                if (KalawScene == false)
                {
                    Console.Clear();
                    CheckSanity();
                    Console.WriteLine($"Location: Kalaw Ave.\n" +
                        $"Sanity: {sanity}%\n" +
                        $"Number of moves: {moves}");
                    Console.WriteLine("\n------------------------------\n");
                    Console.WriteLine($"\n{name} stands at the intersection of Kalaw Avenue,\n" +
                        "just a few meters away from the entrance of Adamson University Walkway\n");
                    Console.WriteLine($"{name}: Here I am, just a few steps away. I can almost feel it");

                    Console.WriteLine($"\nWhat will {name} do next?");
                    Console.WriteLine($"\n[Observe] surroundings\n");
                    Console.Write("\n> ");
                    choice = Console.ReadLine().ToLower();
                    HandleChoice(choice);




                    if (choice == "observe")
                    {
                        moves++;
                        KalawScene = true;
                        ObservefrKalaw();
                    }

                    else
                    {
                        Console.WriteLine("Invalid option. Try again.");
                        Console.ReadKey();
                        Kalaw();
                    }

                }



                else
                {
                    Console.Clear();
                    CheckSanity();
                    Console.WriteLine($"Location: Kalaw Ave.\n" +
                     $"Sanity: {sanity}%\n" +
                     $"Number of moves: {moves}");
                    Console.WriteLine("\n------------------------------\n");
                    Console.WriteLine($"\n[Observe] surroundings\n");
                    Console.Write("\n> ");
                    choice = Console.ReadLine().ToLower();
                    HandleChoice(choice);

                    if (choice == "observe")
                    {
                        moves++;
                        ObservefrKalaw();
                    }

                    else
                    {
                        Console.WriteLine("Invalid option. Try again.");
                        Console.ReadKey();
                        Kalaw();
                    }
                }

            }

            static void ObservefrKalaw()
            {
                Console.Clear();
                CheckSanity();
                Console.WriteLine($"Location: Kalaw Ave.\n" +
                       $"Sanity: {sanity}%\n" +
                       $"Number of moves: {moves}");
                Console.WriteLine("\n------------------------------\n");
            Console.WriteLine($"\nAs {name} observed their surroundings, they\n" +
                    "noticed that they can go to 3 directions:");

            Console.WriteLine("\n[W] Go forward" +
                    "\n[A] Go left\n[D] Go right ");
                Console.Write("\n> ");
                choice = Console.ReadLine().ToUpper();
                HandleChoice(choice);

                switch (choice)
                {
                    case "W":
                        moves++;
                        Highway4();
                        break;
                    case "A":
                        moves++;
                        Riz3();

                        break;
                    case "D":

                        Wall();
                        ObservefrKalaw();

                        break;
                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        Console.ReadKey();
                        ObservefrKalaw();
                        break;
                }
            }



            static bool ObserveScene = false;

            static void Observe()
            {
                Console.Clear();
                if (ObserveScene == false)
                {
                    CheckSanity();
                    Console.WriteLine($"Location: Walkway Entrance\n" +
                    $"Sanity: {sanity}%\n" +
                    $"Number of moves: {moves}");
                    Console.WriteLine("\n------------------------------\n");
                      Console.WriteLine($"\nAs {name} observe their surroundings, they\n" +
                    "noticed that they have different routes that they may able to take to Adamson University.");
                Console.WriteLine("\n[W] Go forward\n[A] Go left\n[S] Go backward\n[D] Go right");
                    Console.Write("\n> ");
                    choice = Console.ReadLine().ToUpper();
                    HandleChoice(choice);

                    if (Hwy3 == true)
                    {
                        switch (choice)
                        {
                            case "W":
                                moves++;
                                Entrance();
                                break;

                            case "A":
                            Console.WriteLine("The area you chose is restricted. 2 moves were added.");
                            Console.ReadKey();
                            moves += 2;
                            Observe();
                                break;
                            case "S":
                                moves++;
                                Highway3();
                                break;
                            case "D":
                                moves++;
                                UN2();
                                break;
                            default:
                                Console.WriteLine("Invalid option. Try again.");
                                Console.ReadKey();
                                Observe();
                                break;
                        }
                    }

                    else
                    {
                        switch (choice)
                        {
                            case "W":
                                moves++;
                                Entrance();
                                break;

                            case "A":
                            Console.WriteLine("The area you chose is restricted. 2 moves were added.");
                            Console.ReadKey();
                            moves += 2;
                            Observe();
                                break;
                            case "S":
                                moves++;
                                Highway3();
                                break;
                            case "D":
                                moves++;
                                UN2();
                                break;
                            default:
                                Console.WriteLine("Invalid option. Try again.");
                                Console.ReadKey();
                                Observe();
                                break;
                        }
                    }



                }

                else
                {
                    Console.Clear();
                    CheckSanity();
                    Console.WriteLine($"Location: Walkway Entrance\n" +
                   $"Sanity: {sanity}%\n" +
                   $"Number of moves: {moves}");
                    Console.WriteLine("\n------------------------------\n");
                    Console.WriteLine($"\nAs {name} observe their surroundings, they\n" +
                        "noticed that they can go to 4 directions:");
                    Console.WriteLine("\n[W] Go forward\n[A] Go left\n[S] Go backward\n[D] Go right");
                    Console.Write("\n> ");
                    choice = Console.ReadLine().ToUpper();
                    HandleChoice(choice);

                    switch (choice)
                    {
                        case "W":
                            moves++;
                            Walkway2();
                            break;

                        case "A":
                        Console.WriteLine("The area you chose is restricted. 2 moves were added.");
                        Console.ReadKey();
                        moves += 2;
                        Observe();
                            break;
                        case "S":
                            moves++;

                            Highway3();
                            break;
                        case "D":
                            moves++;
                            UN2();
                            break;
                        default:
                            Console.WriteLine("Invalid option. Try again.");
                            Console.ReadKey();
                            Observe();
                            break;


                    }
                }



            }




            static void Persuade()
            {
                Console.Clear();
                CheckSanity();
                Console.WriteLine($"Location: Walkway Entrance\n" +
                     $"Sanity: {sanity}%\n" +
                     $"Number of moves: {moves}");
                Console.WriteLine("\n------------------------------\n");

           
            Console.WriteLine($"\n{name} didn't persuade the guard enough causing their sanity to decrease.\n" +
                    $"It also seems like {name} need get their ID, but where?");
                Console.ReadKey();
                
                Entrance();




            }


            static bool EWScene = false;
            static bool sane = false;
            static void Entrance()
            {

                if (EWScene == false && Hwy3 == false)
                {
                    Console.Clear();
                    CheckSanity();
                    Console.WriteLine($"Location: Walkway Entrance\n" +
                        $"Sanity: {sanity}%\n" +
                        $"Number of moves: {moves}");
                    Console.WriteLine("\n------------------------------\n");
                    Console.WriteLine($"\n{name} arrives at the entrance of the walkway,\n" +
                        "a crucial path towards Adamson University.\n" +
                        "However, an imposing security guard stands at the gate, checking IDs.");
                    Console.WriteLine("\nGuard: Hold on! You are wearing an incomplete uniform, where is your ID?");
                    Console.WriteLine($"\n{name}: I'm sorry, I don't have it.");
                    Console.WriteLine("\nGuard: Then you cannot enter. Rules are rules.");
                Console.WriteLine("\nPress any key...");



                if (sane == false)
                    {

                        Console.ReadKey();
                        Console.Clear();
                        CheckSanity();
                        sanity -= 10;
                        Console.WriteLine($"Location: Walkway Entrance\n" +
                            $"Sanity: {sanity}%\n" +
                            $"Number of moves: {moves}");
                        Console.WriteLine("\n------------------------------\n");
                        Console.WriteLine($"\n{name} feels a surge of anxiety, their determination clouded by the\n" +
                            $"guard's refusal. Their sanity decreased.");
                        sane = true;
                    }

                    else if (sane == true)
                    {
                        Console.ReadKey();
                        Console.Clear();
                        CheckSanity();

                        Console.WriteLine($"Location: Walkway Entrance\n" +
                            $"Sanity: {sanity}%\n" +
                            $"Number of moves: {moves}");
                        Console.WriteLine("\n------------------------------\n");
                        Console.WriteLine($"\n{name} feels a surge of anxiety, their determination clouded by the\n" +
                            $"guard's refusal.");
                    }


                    Console.WriteLine($"\nWhat will {name} do next?");
                    Console.WriteLine($"\n[Search] for another route\n[Persuade] the guard\n");
                    Console.Write("> ");
                    choice = Console.ReadLine().ToLower();
                    HandleChoice(choice);

                    if (choice == "search")
                    {

                        Observe();

                    }

                    else if (choice == "persuade")
                    {
                    sanity -= 15;
                    Persuade();
                    }

                    else
                    {
                        Console.WriteLine("Invalid option. Try again.");
                        Console.ReadKey();
                        Entrance();

                    }


                }

                else if (EWScene == false && Hwy3 == true)
                {
                    Console.Clear();
                    CheckSanity();
                    Console.WriteLine($"Location: Walkway Entrance\n" +
                        $"Sanity: {sanity}%\n" +
                        $"Number of moves: {moves}");
                    Console.WriteLine("\n------------------------------\n");
                    Console.WriteLine($"\n{name} arrives at the entrance of the walkway,\n" +
                        "a crucial path towards Adamson University.\n" +
                        "However, an imposing security guard stands at the gate, checking IDs.");
                    Console.WriteLine("\nGuard: Do you have your ID?");

                    Console.WriteLine($"\nWhat will {name} do next?");
                    Console.WriteLine($"\n[Search] for another route\n[Give] the ID to the guard\n");
                    Console.Write("> ");
                    choice = Console.ReadLine().ToLower();
                    HandleChoice(choice);

                    if (choice == "search")
                    {
                        Hwy3 = true;
                        Observe();

                    }

                    else if (choice == "give")
                    {
                        Console.WriteLine("\nGuard: This matches the one on the system. You may go.");
                    Console.WriteLine("\nPress any key...");
                         Console.ReadKey();
                        moves++;
                        Walkway2();
                    }

                    else
                    {
                        Console.WriteLine("Invalid option. Try again.");
                        Console.ReadKey();
                        Entrance();

                    }

                }

                else
                {
                    Console.Clear();
                    CheckSanity();
                    Console.WriteLine($"Location: Walkway Entrance\n" +
                        $"Sanity: {sanity}%\n" +
                        $"Number of moves: {moves}");
                    Console.WriteLine("\n------------------------------\n");
                    Console.WriteLine($"\n{name} is now in Walkway Entrance.");
                    Console.WriteLine($"\nWhat do you want {name} to do?");
                    Console.WriteLine("\n[W] Go forward \n[A] Go left\n[S] Go backward\n[D] Go right");

                    Console.Write("\n> ");
                    choice = Console.ReadLine().ToUpper();
                    HandleChoice(choice);

                    switch (choice)
                    {

                        case "W":
                            moves++;
                            Walkway2();
                            break;


                        case "A":
                        Console.WriteLine("The area you chose is restricted. 2 moves were added.");
                        Console.ReadKey();
                        moves += 2;
                        Observe();
                            break;
                        case "S":
                            moves++;
                            Highway2();
                            break;
                        case "D":
                            moves++;
                            UN2();
                            break;

                        default:
                            Console.WriteLine("Invalid option. Try again.");
                            Console.ReadKey();
                            Entrance();
                            break;
                    }
                }


            }

            static bool chapel = false;
            static void SVChapel()
            {

                if (chapel == false)
                {
                    Console.Clear();
                    sanity += 10;
                    CheckSanity();
                    Console.WriteLine($"Location: SV Chapel\n" +
                                $"Sanity: {sanity}%\n" +
                                $"Number of moves: {moves}");
                    Console.WriteLine("\n------------------------------\n");
                    Console.WriteLine($"\n{name} is now in SV Chapel.");
                    Console.WriteLine($"\n{name} prayed and gained a bit of their percentage.");
                    Console.WriteLine($"\nWhat do you want {name} to do?");
                    Console.WriteLine("\n[W] Go forward\n[A] Go left\n[S] Go backward\n[D] Go right");
                    Console.Write("\n> ");
                    choice = Console.ReadLine().ToUpper();
                    HandleChoice(choice);

                    switch (choice)
                    {
                        case "W":
                            moves++;
                            chapel = true;
                            Highway5();
                            break;
                        case "A":
                            moves++;
                            chapel = true;
                            Gated();
                            break;
                        case "S":
                            moves++;
                            chapel = true;
                            Walkway2();
                            break;
                        case "D":
                            Wall();
                            chapel = true;
                            SVChapel();

                            break;
                        default:
                            Console.WriteLine("Invalid option. Try again.");
                            Console.ReadKey();
                            SVChapel();
                            break;

                    }





                }

                else
                {
                    Console.Clear();
                    CheckSanity();
                    Console.WriteLine($"Location: SV Chapel\n" +
                                $"Sanity: {sanity}%\n" +
                                $"Number of moves: {moves}");
                    Console.WriteLine("\n------------------------------\n");
                    Console.WriteLine($"{name} is now in SV Chapel.");
                    Console.WriteLine($"What do you want {name} to do?");
                    Console.WriteLine("\n[W] Go forward\n[A] Go left\n[S] Go backward\n[D] Go right");
                    Console.Write("\n> ");
                    choice = Console.ReadLine().ToUpper();
                    HandleChoice(choice);

                    switch (choice)
                    {
                        case "W":
                            moves++;

                            Highway5();
                            break;
                        case "A":
                            moves++;

                            Gated();
                            break;
                        case "S":
                            moves++;

                            Walkway2();
                            break;
                        case "D":
                            Wall();
                            SVChapel();

                            break;
                        default:
                            Console.WriteLine("Invalid option. Try again.");
                            Console.ReadKey();
                            SVChapel();
                            break;

                    }
                }


            }

            static bool TUPSchool = false;
            static void tup()
            {
                if (TUPSchool == false)
                {
                    Console.Clear();
                    sanity += 10;
                    CheckSanity();
                    Console.WriteLine($"Location: TUP" +
                                $"\nSanity: {sanity}%\n" +
                                $"Number of moves: {moves}");
                    Console.WriteLine("\n------------------------------\n");
                    Console.WriteLine($"\n{name} is now  beside TUP. For some reason, they feel ecstatic.");
                    Console.WriteLine($"\nWhat do you want {name} to do?");
                    Console.WriteLine("\n[W] Go forward\n[A] Go left\n[S] Go backward\n[D] Go right");
                    Console.Write("\n> ");
                    choice = Console.ReadLine().ToUpper();
                    HandleChoice(choice);

                    switch (choice)
                    {
                        case "W":
                            Wall();
                            tup();
                            break;
                        case "A":
                            Console.WriteLine($"\nTry again.");
                            tup();
                            break;
                        case "S":
                            moves++;
                            TUPSchool = true;
                            Ayala1();

                            break;
                        case "D":
                            moves++;
                            TUPSchool = true;
                            Adamson().GetAwaiter().GetResult(); ;
                            break;
                        default:
                            Console.WriteLine("Invalid option. Try again.");
                            Console.ReadKey();
                            tup();
                            break;

                    }


                }

                else
                {
                    Console.Clear();
                    CheckSanity();
                    Console.WriteLine($"Location: SV Chapel\n" +
                                $"Sanity: {sanity}%\n" +
                                $"Number of moves: {moves}");
                    Console.WriteLine("\n------------------------------\n");
                    Console.WriteLine($"\n{name} is now  beside TUP.");
                    Console.WriteLine($"\nWhat do you want {name} to do?");
                    Console.WriteLine("\n[W] Go forward\n[A] Go left\n[S] Go backward\n[D] Go right");
                    Console.Write("\n> ");
                    choice = Console.ReadLine().ToUpper();
                    HandleChoice(choice);

                    switch (choice)
                    {
                        case "W":
                            Wall();
                            tup();
                            break;
                        case "A":
                            Console.WriteLine($"\n{name} just went farther. Try again");
                            Console.ReadKey();
                            Wall();
                            tup();
                            break;
                        case "S":
                            moves++;
                            TUPSchool = true;
                            Ayala1();

                            break;
                        case "D":
                            moves++;
                            TUPSchool = true;
                            Adamson().GetAwaiter().GetResult(); ;
                            break;
                        default:
                            Console.WriteLine("Invalid option. Try again.");
                            Console.ReadKey();
                            tup();
                            break;

                    }
                }



            }
            static void Ayala1()
            {
                Console.Clear();
                CheckSanity();
                Console.WriteLine($"Location: Ayala Blvd. 1" +
                            $"\nSanity: {sanity}%\n" +
                            $"Number of moves: {moves}");
                Console.WriteLine("\n------------------------------\n");
                Console.WriteLine($"{name} is in Ayala Blvd.");
                Console.WriteLine($"What do you want {name} to do?");
                Console.WriteLine("\n[W] Go forward \n[S] Go backward\n[D] Go right");
                Console.Write("\n> ");
                choice = Console.ReadLine().ToUpper();
                HandleChoice(choice);

                switch (choice)
                {
                    case "W":
                        moves++;
                        tup();
                        break;
                    case "S":
                        moves++;
                        Ayala2();
                        break;
                    case "D":
                        Console.WriteLine($"\nThis is a gated area, {name} cannot enter. A move is added.");
                        moves++;
                        Console.ReadKey();
                        Ayala1();
                        break;
                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        Console.ReadKey();
                        Ayala1();
                        break;

                }



            }

            static bool ayala = false;
            static void Ayala2() //reward
            {
                if (ayala == false)
                {
                    Console.Clear();
                    sanity += 5;
                    CheckSanity();
                    Console.WriteLine($"Location: Ayala Blvd. 2\n" +
                                $"Sanity: {sanity}%\n" +
                                $"Number of moves: {moves}");
                    Console.WriteLine("\n------------------------------\n");
                    Console.WriteLine($"\nThe sight of blue building makes {name} happy. A percentage of their sanity came back.");
                    Console.WriteLine($"\nWhat do you want {name} to do?");
                    Console.WriteLine("\n[W] Go forward\n[A] Go left\n[S] Go backward\n[D] Go right");
                    Console.Write("\n> ");
                    choice = Console.ReadLine().ToUpper();
                    HandleChoice(choice);

                    switch (choice)
                    {
                        case "W":
                            moves++;
                            ayala = true;
                            Ayala1();

                            break;
                        case "A":
                            Wall();
                            Ayala2();
                            break;
                        case "S":
                            moves++;
                            ayala = true;
                            Ayala3();

                            break;
                        case "D":
                        Wall();
                        ayala = true;
                            Ayala2();
                            break;
                        default:
                            Console.WriteLine("Invalid option. Try again.");
                            Console.ReadKey();
                            ayala = true;
                            Ayala2();
                            break;

                    }


                }

                else
                {
                    Console.Clear();
                    CheckSanity();
                    Console.WriteLine($"Location: Ayala Blvd. 2\n" +
                                $"Sanity: {sanity}%\n" +
                                $"Number of moves: {moves}");
                    Console.WriteLine("\n------------------------------\n");
                    Console.WriteLine($"\n{name} is close to their destination.");
                    Console.WriteLine($"\nWhat do you want {name} to do?");
                    Console.WriteLine("\n[W] Go forward\n[A] Go left\n[S] Go backward\n[D] Go right");
                    Console.Write("\n> ");
                    choice = Console.ReadLine().ToUpper();
                    HandleChoice(choice);

                    switch (choice)
                    {
                        case "W":
                            moves++;
                            ayala = true;
                            Ayala1();

                            break;
                        case "A":
                            Console.WriteLine($"\n{name} just went farther. Try again");
                            Console.ReadKey();
                            sanity -= 1;

                            Ayala2();
                            break;
                        case "S":
                            moves++;
                            ayala = true;
                            Ayala3();

                            break;
                        case "D":
                        Wall();
                        ayala = true;
                        Ayala2();
                            break;
                        default:
                            Console.WriteLine("Invalid option. Try again.");
                            Console.ReadKey();
                            Ayala2();
                            break;

                    }

                }
            }

            static bool ayalarizal = false;
            static void Ayala3()
            {

                if (ayalarizal == false && rizz == true)
                {
                    Console.Clear();
                    CheckSanity();
                    Console.WriteLine($"Location: Ayala Blvd. 3\n" +
                        $"Sanity: {sanity}%\n" +
                        $"Number of moves: {moves}");
                    Console.WriteLine("\n------------------------------\n");
                    Console.WriteLine($"\n{name} is  in Ayala Blvd.");


                    Console.WriteLine($"\nBecause {name} continued their current path. They reached Ayala Blvd.");

                    Console.WriteLine($"\nWhat do you want {name} to do?");

                    Console.WriteLine("\n[W] Go forward\n[A] Go left\n[S] Go backward\n[D] Go right");
                    Console.Write("\n> ");
                    choice = Console.ReadLine().ToUpper();
                    HandleChoice(choice);

                    switch (choice)
                    {
                        case "W":
                            moves++;
                            ayalarizal = true;
                            Ayala2();

                            break;
                        case "A":
                            Wall();
                            ayalarizal = true;
                            Ayala3();
                            break;
                        case "S":
                            moves++;
                            ayalarizal = true;
                            Highway1();

                            break;
                        case "D":
                        Console.WriteLine("The area you chose is restricted. 2 moves were added.");
                        Console.ReadKey();
                        moves += 2;
                        Ayala3();
                            break;
                        default:
                            Console.WriteLine("Invalid option. Try again.");
                            Console.ReadKey();
                            Ayala3();
                            break;

                    }
                }

                else
                {
                    Console.Clear();
                    CheckSanity();
                    Console.WriteLine($"Location: Ayala Blvd. 3\n" +
                        $"Sanity: {sanity}%\n" +
                        $"Number of moves: {moves}");

                    Console.WriteLine("\n------------------------------\n");
                    Console.WriteLine($"\n{name} is  in Ayala Blvd.");
                    Console.WriteLine($"\nWhat do you want {name} to do?");

                    Console.WriteLine("\n[W] Go forward\n[A] Go left\n[S] Go backward\n[D] Go right");
                    Console.Write("\n> ");
                    choice = Console.ReadLine().ToUpper();
                    HandleChoice(choice);

                    switch (choice)
                    {
                        case "W":
                            moves++;
                            Ayala2();

                            break;
                        case "A":
                            Wall();
                            Ayala3();
                            break;
                        case "S":
                            moves++;
                            Highway1();

                            break;
                        case "D":
                        Console.WriteLine("The area you chose is restricted. 2 moves were added.");
                        Console.ReadKey();
                        moves += 2;
                        Ayala3();
                            break;
                        default:
                            Console.WriteLine("Invalid option. Try again.");
                            Console.ReadKey();
                            Ayala3();
                            break;

                    }
                }
            }


            static void Walkway1()
            {
                Console.Clear();
                CheckSanity();
                Console.WriteLine($"Location: Walkway 1\n" +
                     $"Sanity: {sanity}%\n" +
                     $"Number of moves: {moves}");
                Console.WriteLine("\n------------------------------\n");
                Console.WriteLine($"\n{name} is now in Walkway");

                Console.WriteLine($"\nWhat do you want {name} to do?");

                Console.WriteLine("\n[W] Go forward\n[A] Go left\n[S] Go backward\n[D] Go right");
                Console.Write("\n> ");
                choice = Console.ReadLine().ToUpper();
                HandleChoice(choice);

                switch (choice)
                {
                    case "W":
                        Wall();
                   
                        moves++;
                        Walkway1();

                        break;
                    case "A":
                        Wall();
                   
                        moves++;
                        Walkway1();
                        break;
                    case "S":
                        Wall();
                       
                        moves++;
                        Walkway1();


                        break;
                    case "D": //valid
                        Walkway2();
                        moves++;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        Console.ReadKey();
                        Walkway1();
                        break;

                }

            }
            static void Walkway2()
            {
                Console.Clear();
                CheckSanity();
                Console.WriteLine($"Location: Walkway 2\n" +
                     $"Sanity: {sanity}%\n" +
                     $"Number of moves: {moves}");
                Console.WriteLine("\n------------------------------\n");

                Console.WriteLine($"\n{name} is now in Walkway");
                Console.WriteLine("\n[W] Go forward \n[A] Go left\n[S] Go backward\n[D] Go right");
                Console.Write("\n> ");
                choice = Console.ReadLine().ToUpper();
                HandleChoice(choice);

                switch (choice)
                {
                    case "W":
                        moves++;
                        SVChapel();
                        break;
                    case "A":
                        moves++;
                        Walkway1();
                        break;
                    case "S":
                        moves++;
                        Entrance();
                        break;
                    case "D":
                        Console.WriteLine($"{name} can't pass through here." +
                            $"A move is added");
                        Console.ReadKey();
                        moves++;
                        Walkway2();
                        break;
                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        Console.ReadKey();
                        Walkway2();
                        break;





                }

            }

            static void Highway1()
            {
                Console.Clear();
                CheckSanity();
                Console.WriteLine($"Location: Highway 1\n" +
                     $"Sanity: {sanity}%\n" +
                     $"Number of moves: {moves}");
                Console.WriteLine("\n------------------------------\n");
                Console.WriteLine($"\n{name} is standing beside the road of the highway.");
                Console.WriteLine("\n[W] Go forward \n[A] Go left\n[S] Go backward\n[D] Go right");
                Console.Write("\n> ");
                choice = Console.ReadLine().ToUpper();
                HandleChoice(choice);

                switch (choice)
                {
                    case "W":
                        moves++;
                        Ayala3();
                        break;
                    case "A": //sanity -1
                        Wall();

                        Highway1();
                        break;
                    case "S":
                        moves++;
                        Riz1();
                        break;
                    case "D":

                        moves++;
                        Highway2();
                        break;
                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        Console.ReadKey();
                        Highway1();
                        break;








                }
            }


            static void Highway2()
            {

                Console.Clear();
                CheckSanity();
                Console.WriteLine($"Location: Highway 2\n" +
                       $"Sanity: {sanity}%\n" +
                       $"Number of moves: {moves}");
                Console.WriteLine("\n------------------------------\n");
                Console.WriteLine($"\n{name} is standing beside the road of the highway.");
                Console.WriteLine("\n[W] Go forward \n[A] Go left\n[S] Go backward\n[D] Go right");
                Console.Write("\n> ");
                choice = Console.ReadLine().ToUpper();
                HandleChoice(choice);

                switch (choice)
                {
                    case "W":
                    Console.WriteLine("The area you chose is restricted. 2 moves were added.");
                    Console.ReadKey();
                    moves += 2;

                    Highway2();
                        break;
                    case "A":
                        moves++;
                        Highway1();
                        break;
                    case "S":
                        moves++;
                        Riz2();
                        break;
                    case "D":
                        moves++;
                        Highway3();
                        break;
                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        Console.ReadKey();
                        Highway1();
                        break;
                }






            }
            static bool Hwy3 = false;
            static void Highway3()
            {

                if (Hwy3 == false && EWScene == false)
                {
                    Console.Clear();
                    CheckSanity();
                    Console.WriteLine($"Location: Highway 3\n" +
                           $"Sanity: {sanity}%\n" +
                           $"Number of moves: {moves}");
                    Console.WriteLine("\n------------------------------\n");
                    Console.WriteLine($"\n{name} is standing beside the road of the highway.");
                    Console.WriteLine($"\nWhen they suddenly hear their name being yelled.");
                    Console.WriteLine($"\n???: {name}! {name}! {name}!");
                    Console.WriteLine($"\n{name}  turned to look, and it's their....");
                    Console.WriteLine("\nPress any key...");
                    Console.ReadKey();
                    Console.Clear();
                    CheckSanity();
                    Console.WriteLine($"Location: Highway 3\n" +
                           $"Sanity: {sanity}%\n" +
                           $"Number of moves: {moves}");
                    Console.WriteLine("\n------------------------------\n");
                    Console.WriteLine($"\n{name}: Mom?! What are you doing here?");
                    Console.WriteLine("\nMom: Well, I called your phone multiple times, you were not answering,\n" +
                        "so I came here quickly to give you your ID before your exam.");
                    Console.WriteLine($"\n{name}: Thanks, mom. I'll see you later at home after school.");
                    EWScene = false;
                    Hwy3 = true;
                    Console.ReadKey();
                    Highway3();
                }
                else
                {
                    Console.Clear();
                    CheckSanity();
                    Console.WriteLine($"Location: Highway 3\n" +
                                     $"Sanity: {sanity}%\n" +
                                     $"Number of moves: {moves}");
                    Console.WriteLine("\n------------------------------\n");
                    Console.WriteLine($"\n{name} is standing beside the road of the highway.");
                    Console.WriteLine("\n[W] Go forward \n[A] Go left\n[S] Go backward\n[D] Go right");
                    Console.Write("\n> ");
                    choice = Console.ReadLine().ToUpper();
                    HandleChoice(choice);

                    switch (choice)
                    {
                        case "W":
                            moves++;
                            Entrance();
                            break;
                        case "A":
                            moves++;
                            Highway2();
                            break;
                        case "S":

                            Wall();
                            Highway3();
                            break;
                        case "D":
                            moves++;
                            Highway4();
                            break;
                        default:
                            Console.WriteLine("Invalid option. Try again.");
                            Console.ReadKey();
                            Highway1();
                            break;
                    }
                }

            }

            static void Highway4()
            {
                Console.Clear();
                CheckSanity();
                Console.WriteLine($"Location: Highway 4\n" +
                    $"Sanity: {sanity}%\n" +
                    $"Number of moves: {moves}");
                Console.WriteLine("\n------------------------------\n");
                Console.WriteLine($"\n{name} is standing beside the road of the highway.");
                Console.WriteLine($"\nWhat do you want {name} to do?");
                Console.WriteLine($"\n[W] Cross the highway\n[A] Go left\n[S] Go backward\n[D] Go right\n");
                Console.Write("\n> ");
                choice = Console.ReadLine().ToUpper();
                HandleChoice(choice);

                switch (choice)
                {
                    case "W":
                        moves++;
                        UN2();
                        break;
                    case "A":
                        moves++;
                        Highway3();
                        break;
                     case "S":
                        moves++;    
                        ObservefrKalaw();
                         break;  
                    case "D":
                         Wall();
                    Highway4();
                    break;
                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        Console.ReadKey();
                        Highway4();
                        break;

                }
            }

            static void Highway5()
            {
                Console.Clear();
                CheckSanity();
                Console.WriteLine($"Location: Highway 5" +
                      $"\nSanity: {sanity}%\n" +
                      $"Number of moves: {moves}");
                Console.WriteLine("\n------------------------------\n");
                Console.WriteLine($"\n{name} is standing beside the road of the highway.");
                Console.WriteLine("\n[W] Go forward \n[A] Go left\n[S] Go backward\n[D] Go right");
                Console.Write("\n> ");
                choice = Console.ReadLine().ToUpper();
                HandleChoice(choice);

                switch (choice)
                {
                    case "W":
                        Wall();
                        Highway5();
                        break;
                    case "A":
                        moves++;
                        Adamson().GetAwaiter().GetResult();
                        break;
                    case "S":
                        moves++;
                        SVChapel();
                        break;
                    case "D":
                        Console.WriteLine($"{name}: Oh no! There's a road construction. I should go back. ");
                        Console.ReadKey();
                        moves++;
                        Highway5();
                        break;
                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        Console.ReadKey();
                        Highway1();
                        break;
                }
            }



            static void UN1()

            {
                Console.Clear();
                CheckSanity();
                Console.WriteLine($"Location: United Nations 1" +
                     $"\nSanity: {sanity}%\n" +
                     $"Number of moves: {moves}");
                Console.WriteLine("\n------------------------------\n");
                Console.WriteLine($"\n{name} is in United Nations.");
                Console.WriteLine("\n[W] Go forward \n[A] Go left\n[S] Go backward");
                Console.Write("\n> ");
                choice = Console.ReadLine().ToUpper();
                HandleChoice(choice);

                switch (choice)
                {
                    case "W":

                        UNExt();
                        break;
                    case "A":
                        Wall();
                
    
                        UN1();
                        break;
                    case "S":
                        moves++;
                        UN2();
                        break;
                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        Console.ReadKey();
                        UN1();
                        break;
                }
            }

            static bool poop = false;
            static void UN2()
            {

                if (poop == false)
                {
                    Console.Clear();

                    CheckSanity();
                    Console.WriteLine($"Location: United Nations 2" +
                        $"\nSanity: {sanity}%\n" +
                        $"Number of moves: {moves}");
                    Console.WriteLine("\n------------------------------\n");
                    Console.WriteLine($"\n{name} crossed over to United Nations.");
                    Console.WriteLine("\nPress any key...");
                    Console.ReadKey();
                    Console.Clear();
                    sanity -= 20;
                    CheckSanity();
                    Console.WriteLine($"Location: United Nations 2\n" +
                        $"Sanity: {sanity}%\n" +
                        $"Number of moves: {moves}");
                    Console.WriteLine("\n------------------------------\n");
                    Console.WriteLine($"\nWhen suddenly {name} stepped on a poop which ruined their shoes!\n" +
                        $"Their sanity decreased.");

                    Console.WriteLine($"\nWhat do you want {name} to do?");

                    Console.WriteLine("\n[W] Go forward\n[A] Go left\n[S] Go backward\n[D] Go right");
                    Console.Write("\n> ");
                    choice = Console.ReadLine().ToUpper();
                    HandleChoice(choice);

                    switch (choice)
                    {
                        case "W":
                            moves++;
                            poop = true;
                            UN1();
                            break;
                        case "A":
                            moves++;
                            poop = true;
                            Entrance();
                            break;
                        case "S":
                            moves++;
                            poop = true;
                            Highway4();
                            break;
                        case "D":
                            Wall();
                            poop = true;
                            UN2();
                            Console.ReadKey();
                            break;
                        default:
                            Console.WriteLine("Invalid option. Try again");
                            poop = true;
                            Console.ReadKey();
                            UN2();
                            break;


                    }


                }

                else
                {
                    Console.Clear();
                    CheckSanity();
                    Console.WriteLine($"Location: United Nations 2" +
                        $"\nSanity: {sanity}%\n" +
                        $"Number of moves: {moves}");
                    Console.WriteLine("\n------------------------------\n");
                    Console.WriteLine($"\n{name} crossed over to United Nations.");


                    Console.WriteLine($"\nWhat do you want {name} to do?");

                    Console.WriteLine("\n[W] Go forward\n[A] Go left\n[S] Go backward\n[D] Go right");
                    Console.Write("\n> ");
                    choice = Console.ReadLine().ToUpper();
                    HandleChoice(choice);

                    switch (choice)
                    {
                        case "W":
                            moves++;
                            poop = true;
                            UN1();
                            break;
                        case "A":
                            moves++;
                            poop = true;
                            Entrance();
                            break;
                        case "S":
                            moves++;
                            poop = true;
                            Highway4();
                            break;
                        case "D":
                            Wall();
                            poop = true;
                            UN2();
                            Console.ReadKey();
                            break;
                        default:
                            Console.WriteLine("Invalid option. Try again");
                            Console.ReadKey();
                            UN2();
                            break;


                    }
                }
            }
            static void UNExt()
            {
                Console.Clear();
                CheckSanity();
                Console.WriteLine($"Location: United Nations Extension\n" +
                     $"Sanity: {sanity}%\n" +
                     $"Number of moves: {moves}");
                Console.WriteLine("\n------------------------------\n");
                Console.WriteLine($"\n{name} is in United Nations.");
                Console.WriteLine("\n[W] Go forward \n[A] Go left\n[S] Go backward\n[D] Go right");
                Console.Write("\n> ");
                choice = Console.ReadLine().ToUpper();
                HandleChoice(choice);

                switch (choice)
                {
                    case "W":
                        Console.WriteLine($"{name}: Oh no! There's a road construction. I should go back. ");
                        Console.ReadKey();
                        moves++;
                        UNExt();
                        break;
                    case "A":
                        Wall();
          

                        UN1();
                        break;
                    case "S":
                        moves++;
                        UN2();
                        break;
                    case "D":
                        Wall();
                        UNExt();
                        break;
                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        Console.ReadKey();
                        Highway1();
                        break;
                }
            }

            static void Gated()
            {
                Console.Clear();
                CheckSanity();
                Console.WriteLine($"Location: Gated Area" +
                            $"Sanity: {sanity}%\n" +
                            $"Number of moves: {moves}");
                Console.WriteLine("\n------------------------------\n");
                Console.WriteLine($"\n{name} is in a Gated area");

                Console.WriteLine($"\nWhat do you want {name} to do?");

                Console.WriteLine("\n[W] Go forward\n[A] Go left\n[S] Go backward\n[D] Go right");
                Console.Write("\n> ");
                choice = Console.ReadLine().ToUpper();
                HandleChoice(choice);

                switch (choice)
                {
                    case "W":
                        Wall();

                        Gated();

                        break;
                    case "A":
                        Wall();
                        Gated();
                        break;
                    case "S":
                        Wall();
                        Gated();
                        break;
                    case "D": //valid option
                        SVChapel();
                        moves++;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        Console.ReadKey();
                        Walkway1();
                        break;

                }

            }

            static bool rpath = false;
            static void Riz1()
            {

                if (rpath == false && rizz == true)
                {
                    Console.Clear();
                    CheckSanity();
                    Console.WriteLine($"Location: Rizal Park 1\n" +
                                $"Sanity: {sanity}%\n" +
                                $"Number of moves: {moves}");
                    Console.WriteLine("\n------------------------------\n");
                    Console.WriteLine($"\n{name}: I may have made a mistake...\n" +
                        $"This is nowhere near Adamson!");

                    Console.WriteLine($"\nWhat do you want {name} to do?");
                    Console.WriteLine("\n[W] Go forward\n[A] Go left\n[S] Go backward\n[D] Go right");
                    Console.Write("\n> ");
                    choice = Console.ReadLine().ToUpper();
                    HandleChoice(choice);

                    switch (choice)
                    {
                        case "W":
                            moves++;
                            rpath = true;
                            Highway1();
                            break;
                        case "A":
                            Wall();
                            Riz1();
                            break;
                        case "S":
                            Wall();
                            Riz1();
                            break;
                        case "D":
                            moves++;
                            rpath = true;
                            Riz2();
                            break;
                    }

                }

                else
                {
                    Console.Clear();
                    CheckSanity();
                    Console.WriteLine($"Location: Rizal Park 1\n" +
                                $"Sanity: {sanity}%\n" +
                                $"Number of moves: {moves}");
                    Console.WriteLine("\n------------------------------\n");
                    Console.WriteLine($"\nWhat do you want {name} to do?");
                    Console.WriteLine("\n[W] Go forward\n[A] Go left\n[S] Go backward\n[D] Go right");
                    Console.Write("\n> ");
                    choice = Console.ReadLine().ToUpper();
                    HandleChoice(choice);

                    switch (choice)
                    {
                        case "W":
                            moves++;
                            rpath = true;
                            Highway1();
                            break;
                        case "A":
                            Wall();
                            Riz1();
                            break;
                        case "S":
                            Wall();
                            Riz1();
                            break;
                        case "D":
                            moves++;
                            rpath = true;
                            Riz2();
                            break;
                    }

                }

            }

            static bool rizz = false;
            static void Riz2()
            {

                if (rizz == false)
                {
                    Console.Clear();
                    CheckSanity();
                    Console.WriteLine($"Location: Rizal Park 2\n" +
                                $"Sanity: {sanity}%\n" +
                                $"Number of moves: {moves}");
                    Console.WriteLine("\n------------------------------\n");
                    Console.WriteLine("\nAfter walking around in Rizal Park, you got lost. Their sanity decreased.");
                    sanity -= 20;
                    Console.WriteLine($"\n{name}: Oh no, I don't know where I am");
                    Console.WriteLine($"\n???: Hello! Are you lost?");
                    Console.WriteLine($"\n{name}: Yes, can you help me?");
                    Console.WriteLine($"\n???: Well, just take the right path, you'll be in Adamson.");
                    Console.WriteLine($"\n{name}: Thank you so much!");
                    Console.WriteLine("\nPress any key...");
                    Console.ReadKey();
                    Console.Clear();
                    CheckSanity();
                    Console.WriteLine($"Location: Rizal Park\n" +
                                $"Sanity: {sanity}%\n" +
                                $"Number of moves: {moves}");
                    Console.WriteLine("\n------------------------------\n");
                    Console.WriteLine($"\n{name} continued on walking, but suddenly stopped.");
                    Console.WriteLine($"They suddenly saw another path, which confuses them from the current path\n" +
                        $"they are walking at.");
                    Console.WriteLine($"\n{name}: Is this the right path? or do I take the right path?");

                    Console.WriteLine("\n[Continue] on the current path");
                    Console.WriteLine("\n[Take] the other path");
                    Console.Write("\n> ");
                    choice = Console.ReadLine().ToLower();
                    HandleChoice(choice);

                    if (choice == "continue")
                    {
                        moves++;
                        rizz = true;
                        Riz1();

                    }

                    else if (choice == "take")
                    {
                        moves++;
                        rizz = true;
                        Ayala3();
                    }


                }

                else
                {

                    Console.Clear();
                    CheckSanity();
                    Console.WriteLine($"Location: Rizal Park 2\n" +
                                $"Sanity: {sanity}%\n" +
                                $"Number of moves: {moves}");
                    Console.WriteLine("\n------------------------------\n");
                    Console.WriteLine($"\nWhat do you want {name} to do?");
                    Console.WriteLine("\n[W] Go forward\n[A] Go left\n[S] Go backward\n[D] Go right");
                    Console.Write("\n> ");
                    choice = Console.ReadLine().ToUpper();
                    HandleChoice(choice);

                    switch (choice)
                    {
                        case "W":
                            moves++;
                            Highway2();
                            break;
                        case "A":
                            moves++;
                            Riz1();
                            break;
                        case "S":
                            Wall();
                            Riz2();
                            break;
                        case "D":
                            moves++;
                            Riz3();
                            break;
                    }
                }
            }

            static void Riz3()
            {
                Console.Clear();
                CheckSanity();
                Console.WriteLine($"Location: Rizal Park 3\n" +
                            $"Sanity: {sanity}%\n" +
                            $"Number of moves: {moves}");
                Console.WriteLine("\n------------------------------\n");
                Console.WriteLine($"\n{name} arrived at Rizal Park, they feel patriotic");
                Console.WriteLine($"\n{name} it's not the time to feel patriotic. I need to go to school!");

                Console.WriteLine($"\nWhat do you want {name} to do?");
                Console.WriteLine("\n[W] Go forward\n[A] Go left\n[S] Go backward\n[D] Go right");
                Console.Write("\n> ");
                choice = Console.ReadLine().ToUpper();
                HandleChoice(choice);

                switch (choice)
                {
                    case "W":
                        moves++;
                        Wall();
                        Riz3();
                        break;
                    case "A":
                        moves++;
                        Riz2();
                        break;

                    case "S":
                        Wall();
                        Riz3();
                        break;
                    case "D":
                        moves++;
                        ObservefrKalaw();
                        break;

                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        Console.ReadKey();
                        Riz3();
                        break;

                }
            }
            static void Effect(string text)
            {
                foreach (char c in text)
                {
                    Console.Write(c);
                    Task.Delay(50).Wait(); // adjust delay time for effect
                }
            }
            static async Task Adamson()
            {

                if (IsCorrectSequence(playerchoice, unlockeaster))
                {

                    DisplaySecretEnding();
                }

                else if (moves <= 12 && sanity >= 20)
                {
                    Console.Clear();
                    CheckSanity();
                    Console.WriteLine($"Location: Adamson" +
                                $"\nSanity: {sanity}%\n" +
                                $"Number of moves: {moves}");
                    Console.WriteLine("\n------------------------------\n");
                    Effect($"\n\n{name} arrives at the Gate of Adamson University; they look at their clock stating\n" +
                        $"\"6:55.\" they breathe a sigh of relief.");
                    await Task.Delay(1000);
                    Effect($"\n\n{name}: I arrive just in the nick of time.");
                    await Task.Delay(1000);
                    Effect($"\n\n{name} walked past the gates and into the university, half running up the stairs " +
                        $"and arriving at their class.");
                    await Task.Delay(1000);
                    Effect($"\n\nTheir classmates greeted them, and {name} sat down just in time as \n" +
                        $"the bell rang, and their professor entering the room with papers in their hand.");
                    await Task.Delay(1000);
                    Effect("\n\nProf: Good morning everyone! Let's start the exam.\n");
                    await Task.Delay(1500);
          
                    Console.Clear();
                    CheckSanity();
                    Console.WriteLine($"Location: Adamson" +
                                $"\nSanity: {sanity}%\n" +
                                $"Number of moves: {moves}");
                    Console.WriteLine("\n------------------------------\n");
                    Effect($"\n\nCONGRATULATIONS! {name} arrived just in time to take their exam!\n");
                    await Task.Delay(1000);
                    Console.WriteLine("\nType restart if you would like to play again.");
                    Console.Write("\n> ");
                    choice = Console.ReadLine().ToUpper();
                    HandleChoice(choice);

                    if (choice == "RESTART")
                    {
                        RestartGame();
                    }


                    else
                    {
                        Environment.Exit(0);
                    }
                }

                else if (moves > 12 && sanity >= 20)
                {
                    Console.Clear();
                    CheckSanity();
                    Console.WriteLine($"Location: Adamson" +
                               $"\nSanity: {sanity}%\n" +
                               $"Number of moves: {moves}");
                    Console.WriteLine("\n------------------------------\n");
                    Effect($"\n\n{name} arrives at Adamson University; their heart sank as they saw the\n" +
                        $"clock \"7:34.\" indicating they were late for their exam.");
                    await Task.Delay(1000);
                    Effect($"\n\nWith a heavy heart, {name} enters the building and up the staircase towards\n" +
                        $"their classroom.");
                    Effect("\n\nThey opened the door and were immediately met with their professor's frowning face.");
                    await Task.Delay(1000);
                    Effect("\n\nProf: You're late. The exam has already started, and I'm afraid I cannot let you\n" +
                        "take it anymore.\n");
                    await Task.Delay(1000);
                    Effect($"\n\nThe professor's words hit {name}'s heart like a bullet, and they were filled with despair.\n" +
                     $"Their hard work and scholarship went down the drain.\n");
                    await Task.Delay(1500);

                    Console.Clear();
                    CheckSanity();
                    Console.WriteLine($"Location: Adamson" +
                                $"\nSanity: {sanity}%\n" +
                                $"Number of moves: {moves}");
                    Console.WriteLine("\n------------------------------\n");
                    Effect($"\n\nBETTER LUCK NEXT TIME! {name} failed to arrive at Adamson on time, resulting in them\n" +
                        $"missing their exam and losing their scholarship.\n");
                    await Task.Delay(1000);
                    Console.WriteLine("\nType restart if you would like to play again.");
                    Console.Write("\n> ");

                    choice = Console.ReadLine().ToUpper();
                    HandleChoice(choice);

                    if (choice == "RESTART")
                    {
                        RestartGame();
                    }


                    else
                    {
                        Environment.Exit(0);
                    }
                }
            }


            static void Wall()
            {
                Console.WriteLine($"{name} cannot enter the premises. A move is added.");
                Console.ReadKey();
                sanity -= 7;
                moves++;
            }

            static void HandleChoice(string choice1)
            {
                playerchoice.Add(choice1);
                // Console.WriteLine("Current appended choices: " + string.Join(" ", playerchoice)); // this is to debug the code
                //Console.ReadKey();

                if (choice == "quit" || choice == "QUIT")
                {
                    Environment.Exit(0);
                }

                else if (choice == "restart" || choice == "RESTART")
                {
                    RestartGame();
                }

            }


            static bool IsCorrectSequence(List<string> choices, string[] sequence)
            {
                if (choices.Count < sequence.Length)
                {
                    return false; // Player's choices haven't reached the length of the correct sequence
                }

                for (int i = 0; i < sequence.Length; i++)
                {
                    if (choices[i] != sequence[i])
                    {
                        return false; // Appended choices don't match the correct sequence
                    }
                }

                return true; // Entire sequence matches the correct sequence
            }

            static void DisplaySecretEnding()
            {
                Console.Clear();
                CheckSanity();
                Console.WriteLine($"Location: Adamson" +
                           $"\nSanity: {sanity}%\n" +
                           $"Number of moves: {moves}");
                Console.WriteLine("\n------------------------------\n");

                Effect($"\n\n{name} arrives at Adamson University just in the nick of time as they rushed towards\n" +
                    $"their room.");
                Task.Delay(1000);
                Effect("\n\nSir Paul: Ok guys, before we start our final exam, a few things lang. \n" +
                    "Let's take our attendance. Abesamis-");
                Task.Delay(1000);
                Effect($"\n\n{name} opened the door in a hurry, interrupting the attendance.");
                Task.Delay(1000);
                Effect("\n\nClassmate: Oh, you just arrived in time. We thought you were going to be late.");
                Effect("\n\nSir Paul: *clapping* Congratulations! You're right in time. I just started the attendance.");
                Task.Delay(1000);
                sanity = 100;
                Effect($"\n\n{name} feels relieved");
                Task.Delay(1000);
                Effect("\n\nSir Paul: Take a seat, we're starting the exam soon");
                Task.Delay(1000);
                Effect($"\n\n{name}: Yes sir!");
                Task.Delay(1000);
                Effect($"\n\n{name} felt happy that their Prof congratulated them. They aced the exam.\n");
                Task.Delay(1500);
                Console.Clear();
                CheckSanity();
                Console.WriteLine($"Location: Adamson" +
                           $"\nSanity: {sanity}%\n" +
                           $"Number of moves: {moves}");
                Console.WriteLine("\n------------------------------\n");

                Effect($"\n\nCONGRATULATIONS! {name} arrived just in time to take their exam!\n");
                Console.WriteLine("\nType restart if you would like to try again.");
                Console.Write("\n> ");
                choice = Console.ReadLine().ToUpper();
                HandleChoice(choice);

                if (choice == "RESTART")
                {
                    RestartGame();
                }


                else
                {
                    Environment.Exit(0);
                }
            }

            static void RestartGame()
            {
                playerchoice.Clear();
                sanity = 80;
                moves = 0;
                EWScene = false;
                TUPSchool = false;
                KalawScene = false;
                ObserveScene = false;
                sane = false;
                chapel = false;
                ayala = false;
                ayalarizal = false;
                poop = false;
                rpath = false;
                rizz = false;
                Hwy3 = false;
                Console.Clear();
                PlayGame();
            }
            static void CheckSanity()
            {
                if (sanity > 80 && sanity <= 100)
                {
                    Console.WriteLine($"{name}'s sanity % is: Excellent \n");
                }

                else if (sanity > 65 && sanity <= 80)
                {
                    Console.WriteLine($"{name}'s sanity % is: Satisfactory\n");
                }

                else if (sanity > 50 && sanity <= 65)
                {
                    Console.WriteLine($"{name}'s sanity % is: Fair\n");
                }

                else if (sanity > 30 && sanity <= 50)
                {
                    Console.WriteLine($"{name}'s sanity % is: Poor\n");
                }

                else if (sanity >= 20 && sanity <= 30)
                {
                    Console.WriteLine($"{name}'s sanity % is: Critical\n");
                }



                else if (sanity >= 0 && sanity < 20)
                {
                    Console.Clear();
                    Console.WriteLine($"{name}'s sanity % is Severe\n");
                    Console.WriteLine($"Location: Adamson" +
                               $"\nSanity: {sanity}%\n" +
                               $"Number of moves: {moves}");
                    Console.WriteLine("\n------------------------------\n");
                    Effect($"\n\n{name}'s sanity is critically low. {name} went home.");
                    Task.Delay(800);
                    Effect($"\n\nYou failed to make {name} reach Adamson.");
                    Task.Delay(1000);
                    Console.WriteLine("\nType restart if you would like to try again.");
                    choice = Console.ReadLine().ToUpper();

                    if (choice == "RESTART")
                    {

                        RestartGame();
                    }
                    else
                    {
                        Environment.Exit(0);
                    }
                }
            }




        }
    

}
