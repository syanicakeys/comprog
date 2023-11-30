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
            Console.Write("> ");
            name = Console.ReadLine();
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
                Console.WriteLine($" {name}: Here I am, just a few steps away. I can almost feel it");

                Console.WriteLine($"\nWhat will {name} do next?" );
                Console.WriteLine($"\n[Observe] surroundings\n");
                Console.Write("> ");
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
                Console.WriteLine($"\nWhat will {name} do next?");
                Console.WriteLine($"\n[Observe] surroundings\n");
                Console.Write("> ");
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
            Console.WriteLine("As you observe your surroundings from Kalaw Avenue,\n" +
                "2 routes are available to go to Adamson University");

            Console.WriteLine("\n[W] Go towards the Highway" +
                "\n[A] Go left");

            choice = Console.ReadLine().ToUpper();

            switch(choice)
            {
                case "W":
                    moves++;
                    Highway4();
                    break;
                case "A":
                    //rizal park 3;
                    break;
                default:
                    ObservefrKalaw();
                    break;
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
                Console.WriteLine("\n[W] Go forward \n[A] Go left\n[S] Go backward\n[D] Go right");

                Console.Write("> ");
                choice = Console.ReadLine().ToUpper();

                switch (choice)
                {

                 case "W":
                        //walkway2;
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
                        //   UN2();
                        break;

                 default:
                        Console.WriteLine("Invalid option. Try again.");
                        Entrance();
                        break;
                }
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
                Console.Write("> ");
                choice = Console.ReadLine().ToUpper();

                switch (choice)
                {
                    case "W":
                        moves++;
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
                        //   UN2();
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
                Console.Write("> ");
                choice = Console.ReadLine().ToUpper();

                switch (choice)
                {
                    case "W":
                        moves++;
                       //ww;
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
                        //   UN2();
                        break;

                }
            }

           

        }

        
        static void Caught()
        {
            Console.Clear();
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
           

            Walkway2();
            }
        

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
            Console.Write("> ");

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

        static void Highway2()
        {
            Console.Clear();
            CheckSanity();
            Console.WriteLine($"Location: Highway\n" +
                 $"Sanity: {sanity}%\n" +
                 $"Number of moves: {moves}");

            Console.WriteLine();

        }

        static void Highway4()
        {
            Console.Clear();
            CheckSanity();
            Console.WriteLine($"Location: Kalaw Ave.\n" +
                $"Sanity: {sanity}%\n" +
                $"Number of moves: {moves}");
            Console.WriteLine($"\n{name} is standing beside the road of the highway.");
            Console.WriteLine($"What do you want {name} to do?");
            Console.WriteLine($"[W] Cross the highway\n
        }

    
    }
}
