using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPROG_TEST_RUN
{
    class Program
    {
        static string title = "mekus mekus";
        static string[] unlockeaster = new string[] { "observe", "A", "A", "W", "W", "W", "D"}; //sequence
        static List<string> playerchoice = new List<string>(); //track choice ng player
        //make sure to have another copy when continue na eto HUHUH 
        static string name;
        static string choice;
        static int moves = 0;
        static int sanity = 80;  //starting sanity
 


        static void Main(string[] args)
        {

            Introduction();
            HomeScene();
            Kalaw();

           

           
            Console.ReadKey();

        }

        //INTRODUCTION
        static void Introduction()
        {

            Console.WriteLine($"Welcome to {title}, an interactive text-based adventure where you’ll\n" +
                 $"navigate the bustling streets and intricate\n" +
                 $"pathways on the way to Adamson University. As Klasmeyt, your journey\n" +
                 $"is not a simple task; it’s a psychological odyssey fraught with challenges.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("To navigate through the game, only enter \n" +
                "the words you see in between the brackets [-----].");
            Console.WriteLine("\nYour choices will impact Klasmeyt’s mindset and progress.\n\n" +
                "Your sanity level is also crucial. Make sure that Klasmeyt does not get their sanity below 20% \n" +
                "to be able to progress through the game.");
            Console.WriteLine("\nAdditionally, your goal is to reach Adamson within 9 moves. This ensures that Klasmeyt will be on time\n" +
                "for their class" );

            Console.WriteLine("\nPress enter....");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Enter Klasmeyt’s name to start your adventure....");
            Console.Write("\n> ");
            name = Console.ReadLine().ToUpper();
            Console.Clear();
            Console.WriteLine($"Hello  Klasmeyt {name}. Goodluck on your journey!");
            Console.ReadKey();
        }

        static void HomeScene()
        {
            Console.Clear();
            CheckSanity();
            Console.WriteLine("Location: Home\n" +
                              "Sanity: --\n" +
                              "Number of Moves: --");
            Console.WriteLine($"\n{name}, a dedicated student, had prepared for their journey to Adamson University.\n" +
                $"However, the previous evening, unexpected circumstances arose that disrupted\n" +
                $"their plans");
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
                Console.WriteLine($"\n{name} stands at the intersection of Kalaw Avenue,\n" +
                    "just a few meters away from the entrance of Adamson University Walkway\n");
                Console.WriteLine($"{name}: Here I am, just a few steps away. I can almost feel it");

                Console.WriteLine($"\nWhat will {name} do next?" );
                Console.WriteLine($"\n[Observe] surroundings\n");
                Console.Write("\n> ");
                choice = Console.ReadLine().ToLower();
               

              

                if(choice == "observe")
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
               
                Console.WriteLine($"\n[Observe] surroundings\n");
                Console.Write("\n> ");
                choice = Console.ReadLine().ToLower();
             
            
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
            
            Console.WriteLine("\nAs you observe your surroundings from Kalaw Avenue,\n" +
                "2 routes are available to go to Adamson University");

            Console.WriteLine("\n[W] Go towards the Highway" +
                "\n[A] Go left");
            Console.Write("\n> ");
            choice = Console.ReadLine().ToUpper();

            switch(choice)
            {
                case "W":
                    moves++;
                    Highway4();
                    break;
                case "A":
                    moves++;
                    Riz3();
                    
                    break;
                default:
                    Console.WriteLine("Invalid option. Try again.");
                    ObservefrKalaw();
                    break;
            }    
        }



        static bool ObserveScene = false;
       
        static void Observe()
        {
            Console.Clear();
            if (ObserveScene == false) {
                CheckSanity();
                Console.WriteLine($"Location: Walkway Entrance\n" +
                $"Sanity: {sanity}%\n" +
                $"Number of moves: {moves}");
                Console.WriteLine("\nAs you observe your surroundings, you\n" +
                    "noticed that you can only go to 3 directions:");
                Console.WriteLine("\n[W] Go forward\n[A] Go left\n[S] Go backward\n[D] Go right");
                Console.Write("\n> ");
                choice = Console.ReadLine().ToUpper();

                switch (choice)
                {
                    case "W":
                        moves++;
                        ObserveScene = false;
                        Caught();
                        break;

                    case "A":
                        Console.WriteLine("The area you chose is restricted. A move is added.");
                        moves++;
                        Console.ReadKey();
                        ObserveScene = true;
                        Observe();
                        break;
                    case "S":
                        moves++;
                       Highway2();
                        break;
                    case "D":
                        moves++;
                        ObserveScene = true;
                        UN2();
                       break;

                }

               
            
            }

            else
            {
                Console.Clear();
                  CheckSanity();
                Console.WriteLine($"Location: Walkway Entrance\n" +
               $"Sanity: {sanity}%\n" +
               $"Number of moves: {moves}");
                Console.WriteLine("\nAs you observe your surroundings, you\n" +
                    "noticed that you can only go to 3 directions:");
                Console.WriteLine("\n[W] Go forward\n[A] Go left\n[S] Go backward\n[D] Go right");
                Console.Write("\n> ");
                choice = Console.ReadLine().ToUpper();

                switch (choice)
                {
                    case "W":
                        moves++;
                        Walkway2();
                        break;

                    case "A":
                        Console.WriteLine("The area you chose is restricted. A move is added.");
                        moves++;
                        Console.ReadKey();
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
                        break;
                   

            }
            }

           

        }

        
        static void Caught()
        {
            Console.Clear();
            ObserveScene = false;
            sanity -= 5;
            CheckSanity();
            Console.WriteLine($"Location: Walkway Entrance\n" +
           $"Sanity: {sanity}%\n" +
           $"Number of moves: {moves}");
            Console.WriteLine($"\n{name} continued to walk to Walkway");
            Console.WriteLine("\nGuard: Hey! I told you you can't come here without your ID!");
            Console.WriteLine("\nSearch for another route again..");
            Console.ReadKey();
            Observe();
            



        }


        static string studentnum;
        static void Persuade()
        {
           Console.Clear();
          Console.WriteLine($"Location: Walkway Entrance\n" +
               $"Sanity: {sanity}%\n" +
               $"Number of moves: {moves}");

            Console.WriteLine("\nThe guard seemingly to pity you sighs in defeat.");
            Console.WriteLine("\nGuard: Fine, you're lucky it's a good day for me, can I get your student\n" +
                "number so I can check your validity?");
            Console.Write("\nEnter your student number: ");
            studentnum = Console.ReadLine();

            if (studentnum.Length !=9)
            {
                Console.WriteLine("\n Your student number should be 9 digits long. Try again.");
                Console.ReadKey();
                Persuade();
            }

            else
            {
                sanity += 5;
                moves++;
                Console.WriteLine($"{name}  gave their student number and their face matches\n" +
                    $" with the one on the system, the guard lets them go. You gained 5% sanity.");
                Console.ReadKey();
                 Walkway2();
            }
        

        }


        static bool EWScene = false;
        static void Entrance()
        {
            if (!EWScene)
            {
                Console.Clear();
                CheckSanity();
                Console.WriteLine($"Location: Walkway Entrance\n" +
                    $"Sanity: {sanity}%\n" +
                    $"Number of moves: {moves}");
                Console.WriteLine("\nKlasmeyt arrives at the entrance of the walkway,\n" +
                    "a crucial path towards Adamson University.\n" +
                    "However, an imposing security guard stands at the gate, checking IDs.");
                Console.WriteLine("\nGuard: Hold on! You are wearing an incomplete uniform, where is your ID?");
                Console.WriteLine($"\n{name}: I'm sorry, I must've forgotten it at home.");
                Console.WriteLine("\nGuard: I cannot allow you to  enter without your ID, rules are rules");

                sanity -= 10;  //sanity deduction
                Console.ReadKey();


                Console.Clear();
                CheckSanity();
                Console.WriteLine($"Location: Walkway Entrance\n" +
                    $"Sanity: {sanity}%\n" +
                    $"Number of moves: {moves}");
                Console.WriteLine($"\n{name} feels a surge of anxiety, their determination clouded by the\n" +
                    $"guard's refusal. Your sanity decreased");
                Console.WriteLine($"\nWhat will {name} do next?");
                Console.WriteLine($"\n[Search] for another route\n[Persuade] the guard\n");
                Console.Write("> ");
                choice = Console.ReadLine().ToLower();

                if (choice == "search")
                {
                    moves++;
                    CheckSanity();
                    EWScene = true;
                    Observe();

                }

                else if (choice == "persuade")
                {
                    EWScene = true;
                    Persuade();
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

                Console.WriteLine($"\n {name} is now in Walkway Entrance.");
                Console.WriteLine($"\n What do you want {name} to do?");
                Console.WriteLine("\n[W] Go forward \n[A] Go left\n[S] Go backward\n[D] Go right");

                Console.Write("\n> ");
                choice = Console.ReadLine().ToUpper();

                switch (choice)
                {

                    case "W":
                        moves++;
                        Walkway2();
                        break;


                    case "A":
                        Console.WriteLine("The area you chose is restricted. A move is added.");
                        moves++;
                        Console.ReadKey();
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
                Console.WriteLine($"Location: SV Chapel" +
                            $"Sanity: {sanity}%\n" +
                            $"Number of moves: {moves}");

                Console.WriteLine($"\n{name} is now in SV Chapel.");
                Console.WriteLine($"\nWhat do you want {name} to do?");
                Console.WriteLine("\n[W] Go forward\n[A] Go left\n[S] Go backward\n[D] Go right");
                Console.Write("\n> ");
                choice = Console.ReadLine().ToUpper();
               

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
                        Console.WriteLine("A wall blocks this area, you cannot enter. A move is added.");
                        moves++;
                        chapel = true;
                        SVChapel();
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        sanity -= 10;
                        Console.ReadKey();
                        SVChapel();
                        break;

                }





            }

            else
            {
                Console.Clear();
                CheckSanity();
                Console.WriteLine($"Location: SV Chapel" +
                            $"Sanity: {sanity}%\n" +
                            $"Number of moves: {moves}");

                Console.WriteLine($"{name} is now in SV Chapel.");
                Console.WriteLine($"What do you want {name} to do?");
                Console.WriteLine("[W] Go forward\n[A] Go left\n[S] Go backward\n[D] Go right");
                Console.Write("\n> ");
                choice = Console.ReadLine();

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
                        Console.WriteLine("A wall blocks this area, you cannot enter. A move is added.");
                        moves++;
       
                        SVChapel();
                        Console.ReadKey();
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
                sanity += 5;
                CheckSanity();
                Console.WriteLine($"Location: SV Chapel" +
                            $"Sanity: {sanity}%\n" +
                            $"Number of moves: {moves}");

                Console.WriteLine($"{name} is now  beside TUP.");
                Console.WriteLine($"What do you want {name} to do?");
                Console.WriteLine("[W] Go forward\n[A] Go left\n[S] Go backward\n[D] Go right");
                Console.Write("> ");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "W":
                        Console.WriteLine($"\n{name} just went farther. Try again");
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
                        Adamson();
                        break;
                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;

                }

         
            }

            else
            {
                Console.Clear();
                CheckSanity();
                Console.WriteLine($"Location: SV Chapel" +
                            $"Sanity: {sanity}%\n" +
                            $"Number of moves: {moves}");

                Console.WriteLine($"{name} is now  beside TUP.");
                Console.WriteLine($"What do you want {name} to do?");
                Console.WriteLine("[W] Go forward\n[A] Go left\n[S] Go backward\n[D] Go right");
                Console.Write("\n> ");
                choice = Console.ReadLine().ToUpper();

                switch (choice)
                {
                    case "W":
                        Console.WriteLine($"\n{name} just went farther. Try again");
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
                        Adamson();
                        break;
                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;

                }
            }
          


        }
        static void Ayala1()
        {
            Console.Clear();
            CheckSanity();
            Console.WriteLine($"Location: Ayala Blvd." +
                        $"Sanity: {sanity}%\n" +
                        $"Number of moves: {moves}");

            Console.WriteLine($"{name} is in Ayala Blvd.");
            Console.WriteLine($"What do you want {name} to do?");
            Console.WriteLine("[W] Go forward \n[S] Go backward\n[D] Go right");
            Console.Write("\n> ");
            choice = Console.ReadLine().ToUpper();

            switch (choice)
            {
                case "W":
                    moves++;
                    tup();
                    break;
                case "S":
                    moves++;
                    tup();
                    break;
                case "D":
                    Console.WriteLine($"\nThis is a gated area, {name} cannot enter. A move is added.");
                    moves++;
                    Console.ReadKey();
                    Ayala1();
                    break;
                default:
                    Console.WriteLine("Invalid option. Try again.");
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
                Console.WriteLine($"Location: Ayala Blvd." +
                            $"Sanity: {sanity}%\n" +
                            $"Number of moves: {moves}");

                Console.WriteLine($"The sight of blue building makes {name} happy. A percentage of your sanity came back.");
                Console.WriteLine($"What do you want {name} to do?");
                Console.WriteLine("[W] Go forward\n[A] Go left\n[S] Go backward\n[D] Go right");
                Console.Write("\n> ");
                choice = Console.ReadLine().ToUpper();

                switch (choice)
                {
                    case "W":
                        moves++;
                        ayala = true;
                        Ayala1();
                       
                        break;
                    case "A":
                        Console.WriteLine($"\nTry again.");
                        Ayala2();
                        break;
                    case "S":
                        moves++;
                        ayala = true;
                        Ayala3();
                        
                        break;
                    case "D":
                        moves++;
                        Console.WriteLine($"{name} just trespassed! A move is added. Try again.");
                        Ayala2();
                        break;
                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;

                }


            }

            else
            {
                Console.Clear();
                CheckSanity();
                Console.WriteLine($"Location: Ayala Blvd." +
                            $"Sanity: {sanity}%\n" +
                            $"Number of moves: {moves}");

                Console.WriteLine($"{name} is close to their destination.");
                Console.WriteLine($"\nWhat do you want {name} to do?");
                Console.WriteLine("[W] Go forward\n[A] Go left\n[S] Go backward\n[D] Go right");
                Console.Write("\n> ");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "W":
                        moves++;
                        ayala = true;
                        Ayala1();

                        break;
                    case "A":
                        Console.WriteLine($"\nTry again.");
                        Ayala2();
                        break;
                    case "S":
                        moves++;
                        ayala = true;
                        Ayala3();

                        break;
                    case "D":
                        moves++;
                        Console.WriteLine($"{name} just trespassed! A move is added. Try again.");
                        Ayala2();
                        break;
                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;

                }

            }
        }

        static void Ayala3() 
        {
            Console.WriteLine($"Location: Ayala Blvd." +
                      $"Sanity: {sanity}%\n" +
                      $"Number of moves: {moves}");

        }
        static void Walkway1()
        {
            Console.Clear();
            CheckSanity();
            Console.WriteLine($"Location: Walkway\n" +
                 $"Sanity: {sanity}%\n" +
                 $"Number of moves: {moves}");
        }
        static void Walkway2()
        {
            Console.Clear();
            CheckSanity();
            Console.WriteLine($"Location: Walkway\n" +
                 $"Sanity: {sanity}%\n" +
                 $"Number of moves: {moves}");


            Console.WriteLine($"\n {name} is now in Walkway");
            Console.WriteLine("\n[W] Go forward \n[A] Go left\n[S] Go backward\n[D] Go right");
            Console.Write("\n> ");
            choice = Console.ReadLine().ToUpper();

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
                    Console.WriteLine($"{name} can't pass through here" +
                        $"\na move is added");
                    moves++;
                     Walkway2();
                    break;
                        



                    

            }

        }

        static void Highway1()
        {
            Console.WriteLine($"Location: Highway\n" +
                 $"Sanity: {sanity}%\n" +
                 $"Number of moves: {moves}");
        }

        static void Highway2()
        {
            Console.Clear();
            CheckSanity();
            Console.WriteLine($"Location: Highway\n" +
                 $"Sanity: {sanity}%\n" +
                 $"Number of moves: {moves}");

            Console.WriteLine();

        }
        static void Highway3()
        {
            Console.WriteLine($"Location: Highway\n" +
                 $"Sanity: {sanity}%\n" +
                 $"Number of moves: {moves}");
        }


        static void Highway4()
        {
            Console.Clear();
            CheckSanity();
            Console.WriteLine($"Location: Highway\n" +
                $"Sanity: {sanity}%\n" +
                $"Number of moves: {moves}");
            Console.WriteLine($"\n{name} is standing beside the road of the highway.");
            Console.WriteLine($"\nWhat do you want {name} to do?");
            Console.WriteLine($"\n[W] Cross the highway\n[A] Go left\n");
            Console.Write("\n> ");
            choice = Console.ReadLine().ToUpper();

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
                default:
                    Console.WriteLine("Invalid option. Try again.");
                    Highway4();
                    break;

            }
        }

        static void Highway5()
        {
            Console.WriteLine($"Location: Highway\n" +
                 $"Sanity: {sanity}%\n" +
                 $"Number of moves: {moves}");
        }

        static void Highway6()
        {
            Console.WriteLine($"Location: Highway\n" +
                 $"Sanity: {sanity}%\n" +
                 $"Number of moves: {moves}");
        }

        static void UN1()
        {
            Console.WriteLine($"Location: United Nation" +
                 $"Sanity: {sanity}%\n" +
                 $"Number of moves: {moves}");
        }

        static bool poop = false;
        static void UN2()
        {

            if (poop == false)
            {
                Console.Clear();
                
                CheckSanity();
                Console.WriteLine($"Location: United Nations\n" +
                    $"Sanity: {sanity}%\n" +
                    $"Number of moves: {moves}");
                Console.WriteLine($"\n{name} crossed over to United Nations.");
                Console.WriteLine("\n Press enter..");
                Console.ReadKey();
                Console.Clear();
                sanity -= 15;
                CheckSanity();
                Console.WriteLine($"Location: United Nations\n" +
                    $"Sanity: {sanity}%\n" +
                    $"Number of moves: {moves}");
  
                Console.WriteLine($"\nWhen suddenly {name} stepped on a poop which ruined their shoes!\n" +
                    $"Your sanity decreased.");

                Console.WriteLine($"\nWhat do you want {name} to do?");

                Console.WriteLine("[W] Go forward\n[A] Go left\n[S] Go backward\n[D] Go right");
                Console.Write("\n> ");
                choice = Console.ReadLine().ToUpper();


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
                        Console.WriteLine("You just went away from Adamson. Your sanity decreased.");
                        Console.WriteLine("Try again");
                        sanity -= 1;
                        moves++;
                        poop = true;
                        UN2();
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Invalid option. Try again");
                          sanity+=15;
                        Console.ReadKey();
                        break;


                }

              
            }

            else
            {
                Console.Clear();
                CheckSanity();
                Console.WriteLine($"Location: United Nations\n" +
                    $"Sanity: {sanity}%\n" +
                    $"Number of moves: {moves}");
                Console.WriteLine($"\n{name} crossed over to United Nations.");


                Console.WriteLine($"\nWhat do you want {name} to do?");

                Console.WriteLine("[W] Go forward\n[A] Go left\n[S] Go backward\n[D] Go right");
                Console.Write("\n> ");
                choice = Console.ReadLine().ToUpper();

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
                        Console.WriteLine("You just went away from Adamson. Your sanity decreased.");
                        Console.WriteLine("Try again");
                        sanity -= 1;
                        moves++;
                        poop = true;
                        UN2();
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Invalid option. Try again");
                 
                        Console.ReadKey();
                        break;


                }
            }
        }
        static void UNExt()
        {
            Console.WriteLine($"Location: United Nation Extension" +
                 $"Sanity: {sanity}%\n" +
                 $"Number of moves: {moves}");
        }

        static void Gated()
        {
            Console.WriteLine($"Location: Gated Area" +
                        $"Sanity: {sanity}%\n" +
                        $"Number of moves: {moves}");
        }

        static void Riz1()
        {
            Console.WriteLine($"Location: Rizal Park" +
                        $"Sanity: {sanity}%\n" +
                        $"Number of moves: {moves}");
        }

        static void Riz2()
        {
            Console.WriteLine($"Location: Rizal Park" +
                        $"Sanity: {sanity}%\n" +
                        $"Number of moves: {moves}");
        }

        static void Riz3()
        {
            Console.WriteLine($"Location: Rizal Park" +
                        $"Sanity: {sanity}%\n" +
                        $"Number of moves: {moves}");
        }
        static void Adamson()
        {
            Console.WriteLine($"Location: Adamson" +
                        $"Sanity: {sanity}%\n" +
                        $"Number of moves: {moves}");
        }


        
        static void CheckSanity()
        {

            if (sanity >=20 && sanity<=50)
            {

                Console.WriteLine("Your sanity % is: Good\n");
            
            }

            else if (sanity > 50 && sanity <= 100)
            {
                Console.WriteLine("Your sanity % is: Perfect\n");
            }

            else if (sanity < 20)
            {
                Console.WriteLine($"{name}'s sanity is below 20%. {name} went home");
                Console.WriteLine("Restarting..");
                sanity = 80;
                Console.ReadKey();
                HomeScene();                
            }


        }

      
    
    }
}
