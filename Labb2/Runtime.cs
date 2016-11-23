using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2
{
    class Runtime
    {
        public void Start()
        {
            Dog myDog = new Dog
            {
                
                Age = 12,
                Weight = 80,
                WarmBlooded = "Yes",
                CanRun = "Run",
                NumberOfLegs = 4,
                CanBark = "Bark",

            };

            Monkey myMonkey = new Monkey
            {
                
                Age = 35,
                Weight = 50,
                WarmBlooded = "Yes",
                CanRun = "Run",
                NumberOfLegs = 2,
                CanLaugh = "Laugh"
            };

            Snake mySnake = new Snake
            {
                Age = 6,
                Weight = 12,
                ColdBlooded = "Yes",
                CanRun = "can't run",
                NumberOfLegs = 0,
                CanBite = "bite"
            };

            Lizzard myLizzard = new Lizzard
            {
                Age = 8,
                Weight = 4,
                ColdBlooded = "Yes",
                CanRun = "Run",
                NumberOfLegs = 4,
                CanLoseTail = "tail"
            };

            Parrot myParrot = new Parrot
            {
                Age = 80,
                Weight = 9,
                WarmBlooded = "Yes",
                CanFly = "fly",
                NumberOfLegs = 2,
                CanTalk = "talk"

            };

            Eagle myEagle = new Eagle
            {
                Age = 56,
                Weight = 13,
                WarmBlooded = "Yes",
                CanFly = "fly",
                NumberOfLegs = 2,
                CanHunt = "hunt"

            };

            List<Mammal> mammals = new List<Mammal>()
            {
                myDog,
                myMonkey
                           
            };

            List<Reptile> reptiles = new List<Reptile>()
            {
                mySnake,
                myLizzard
            };

            List<Bird> birds = new List<Bird>()
            {
                myParrot,
                myEagle
            };

            bool loop = false;
            do
            {
                loop = false;
                Console.WriteLine("Welcome to your animal collection");
                Console.WriteLine("------------------------------");
                Console.WriteLine("1: Add new animal");
                Console.WriteLine("2: Remove animal");
                Console.WriteLine("3: Show aniamal lists");
                Console.WriteLine("4: Show special ability ");
                Console.WriteLine("5: Exit");
                int input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1:

                        
                        Console.WriteLine("1. Mammal");
                        Console.WriteLine("2. Reptile");
                        Console.WriteLine("3. Bird");
                        int choice = int.Parse(Console.ReadLine());

                        if (choice == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("What kind of mammal is it?:");
                            string kind = Console.ReadLine();

                            Console.WriteLine("Age: ");
                            int age = int.Parse(Console.ReadLine());

                            Console.WriteLine("Weight: ");
                            int weigth = int.Parse(Console.ReadLine());

                            Console.WriteLine("Can your animal run?: ");
                            string canRun = Console.ReadLine();

                            Console.WriteLine("How many legs does your animal have?:");
                            int numberOfLegs = int.Parse(Console.ReadLine());

                            Console.WriteLine("Is it warmblooded?:");
                            string warmBlooded = Console.ReadLine();

                            Mammal newMammal = new Mammal
                            {

                                Kind = kind,
                                Age = age,
                                Weight = weigth,
                                CanRun = canRun,
                                NumberOfLegs = numberOfLegs,
                                WarmBlooded = warmBlooded,
                            };

                            mammals.Add(newMammal);
                        }

                        else if (choice == 2)
                        {
                            Console.Clear();
                            Console.WriteLine("What kind of reptile is it?:");
                            string kind = Console.ReadLine();

                            Console.WriteLine("Age: ");
                            int age = int.Parse(Console.ReadLine());

                            Console.WriteLine("Weight: ");
                            int weigth = int.Parse(Console.ReadLine());

                            Console.WriteLine("Can your animal run?: ");
                            string canRun = Console.ReadLine();

                            Console.WriteLine("How many legs does your animal have?:");
                            int numberOfLegs = int.Parse(Console.ReadLine());

                            Console.WriteLine("Is it coldblooded?:");
                            string coldBlooded = Console.ReadLine();

                            Reptile newReptile = new Reptile
                            {
                                Kind = kind,
                                Age = age,
                                Weight = weigth,
                                CanRun = canRun,
                                NumberOfLegs = numberOfLegs,
                                ColdBlooded = coldBlooded
                            };

                            reptiles.Add(newReptile);
                        }

                        else if (choice == 3)
                        {
                            Console.Clear();
                            Console.WriteLine("What kind of bird is it?:");
                            string kind = Console.ReadLine();

                            Console.WriteLine("Age: ");
                            int age = int.Parse(Console.ReadLine());

                            Console.WriteLine("Weight: ");
                            int weigth = int.Parse(Console.ReadLine());

                            Console.WriteLine("Can your animal fly?: ");
                            string canFly = Console.ReadLine();

                            Console.WriteLine("How many legs does your animal have?:");
                            int numberOfLegs = int.Parse(Console.ReadLine());

                            Console.WriteLine("Is it warmblooded?:");
                            string warmBlooded = Console.ReadLine();

                            Bird newBird = new Bird
                            {
                                Kind = kind,
                                Age = age,
                                Weight = weigth,
                                CanFly = canFly,
                                NumberOfLegs = numberOfLegs,
                                WarmBlooded = warmBlooded,
                            };

                            birds.Add(newBird);

                        }

                        break;

                    case 2:

                        Console.WriteLine("What kind of animal do you want to remove?");
                        Console.WriteLine("------------------------------------------");
                        Console.WriteLine("1. Mammal");
                        Console.WriteLine("2. Reptile");
                        Console.WriteLine("3. Bird");
                        int secondchoice = int.Parse(Console.ReadLine());

                        switch (secondchoice)
                        {
                            case 1:

                                Console.WriteLine("What mammal do you want to remove? Choose a number");

                                foreach (var mammal in mammals)
                                {
                                    Console.WriteLine("Kind: " + mammal.Kind + " Age: " + mammal.Age + " Weight:  " + mammal.Weight + " Can it run? " + mammal.CanRun + " Number of legs? " + mammal.NumberOfLegs + "Is it warmblooded? " + mammal.WarmBlooded);
                                }                               
                                int index = int.Parse(Console.ReadLine());
                                index = index - 1;
                                mammals.RemoveAt(index);
                                break;

                            case 2:

                                Console.WriteLine("What reptile do you want to remove? Choose a number");

                                foreach (var reptile in reptiles)
                                {
                                    Console.WriteLine("Kind: " + reptile.Kind + " Age: " + reptile.Age + " Weight:  " + reptile.Weight + " Can it run? " + reptile.CanRun + " Number of legs? " + reptile.NumberOfLegs + "Is it warmblooded? " + reptile.ColdBlooded);
                                }
                                
                                int index1 = int.Parse(Console.ReadLine());
                                index1 = index1 - 1;
                                reptiles.RemoveAt(index1);
                                break;

                            case 3:

                                Console.WriteLine("What bird do you want to remove? Choose a number");

                                foreach (var bird in birds)
                                {
                                    Console.WriteLine("Kind: " + bird.Kind + " Age: " + bird.Age + " Weight:  " + bird.Weight + " Can it run? " + bird.CanFly + " Number of legs? " + bird.NumberOfLegs + "Is it warmblooded? " + bird.WarmBlooded);
                                }
                             
                                int index2 = int.Parse(Console.ReadLine());
                                index2 = index2 - 1;
                                birds.RemoveAt(index2);
                                break;

                            default:
                                break;
                        }

                        break;


                    case 3:

                        Console.WriteLine("Which animals do you want to see?");
                        Console.WriteLine("---------------------------------");
                        Console.WriteLine("1. Mammals");
                        Console.WriteLine("2. Reptiles");
                        Console.WriteLine("3. Birds");
                        int thirdchoice = int.Parse(Console.ReadLine());

                        if (thirdchoice == 1)
                            
                            foreach (var mammal in mammals)
                            {
                                Console.WriteLine("Kind: " + mammal.Kind + " Age: " + mammal.Age + " Weight:  " + mammal.Weight + " Can it run? " + mammal.CanRun + " Number of legs? " + mammal.NumberOfLegs + "Is it warmblooded? " + mammal.WarmBlooded);
                            }

                         else if (thirdchoice == 2)
                            
                            foreach (var reptile in reptiles)
                            {
                                Console.WriteLine("Kind: " + reptile.Kind + " Age: " + reptile.Age + " Weight:  " + reptile.Weight + " Can it run? " + reptile.CanRun + " Number of legs? " + reptile.NumberOfLegs + "Is it warmblooded? " + reptile.ColdBlooded);
                            }

                          else if (thirdchoice == 3)
                            
                            foreach (var bird in birds)
                            {
                            Console.WriteLine("Kind: " + bird.Kind + " Age: " + bird.Age + " Weight:  " + bird.Weight + " Can it run? " + bird.CanFly + " Number of legs? " + bird.NumberOfLegs + "Is it warmblooded? " + bird.WarmBlooded);
                            }                 

                                

                            break;
                    case 4:

                        Console.WriteLine("Which animals special ability do you want to see?");
                        Console.WriteLine("-------------------------------------------------");
                        Console.WriteLine("1. Dog:");
                        Console.WriteLine("2. Monkey");
                        Console.WriteLine("3. Snake");
                        Console.WriteLine("4. Lizzard");
                        Console.WriteLine("5. Parrot");
                        Console.WriteLine("6. Eagle");
                        int fourthchoice = int.Parse(Console.ReadLine());

                        if (fourthchoice == 1)
                        {
                            Console.Clear();
                            Console.WriteLine(myDog.Move());
                            Console.WriteLine(myDog.Talk());
                            Console.WriteLine(" ");
                        }
                        else if (fourthchoice == 2)
                        {
                            Console.Clear();
                            Console.WriteLine(myMonkey.Move());
                            Console.WriteLine(myMonkey.Talk());
                            Console.WriteLine(" ");
                        }

                        else if (fourthchoice == 3)
                        {
                            Console.Clear();
                            Console.WriteLine(mySnake.Move());
                            Console.WriteLine(mySnake.Talk());
                            Console.WriteLine(" ");
                        }

                        else if (fourthchoice == 4)
                        {
                            Console.Clear();
                            Console.WriteLine(myLizzard.Move());
                            Console.WriteLine(myLizzard.Talk());
                            Console.WriteLine(" ");
                        }

                        else if (fourthchoice == 5)
                        {
                            Console.Clear();
                            Console.WriteLine(myParrot.Move());
                            Console.WriteLine(myParrot.Talk());
                            Console.WriteLine(" ");
                        }

                        else if (fourthchoice == 6)
                        {
                            Console.Clear();
                            Console.WriteLine(myEagle.Move());
                            Console.WriteLine(myEagle.Talk());
                            Console.WriteLine(" ");
                        }
                        break;

                    case 5:

                        Environment.Exit(0);

                        break;

                    default:
                        Console.WriteLine("Please pick a valid nubmber");
                        
                        break;
                }

               
            } while (true);
        }
    }
}
