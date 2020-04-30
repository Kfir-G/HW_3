using System;

namespace HW_3
{
    enum MenuAnimal { ADD_ANIMAL=1, TAKE_CARE, PRINT, EXIT };
    class Program
    {
        static void Main(string[] args)
        {
            MenuAnimal menuChoice;
            Service service = new Service();
            do
            {
                Console.Clear();
                string Menu = "\nAnimal Manager \n\n\t1 - Add New Animal \n\t2 - Take care of next animal\n\t3 - Print animals List \n\t4 - Exit\n\t\t\t\t\t*\n\t\t\t\t\t *\n\t\t\t\t\t*";
                Console.WriteLine(Menu);
                menuChoice = (MenuAnimal)(int.Parse(Console.ReadLine()));
                if (menuChoice == MenuAnimal.EXIT)
                {
                    Console.WriteLine("Have a good day!");
                    break;
                }
                switch (menuChoice)
                {
                    case MenuAnimal.ADD_ANIMAL: // Add New animal
                        {
                            Console.WriteLine("\n\t Add New Animal ");
                            service.AddNewAnimal();
                            break;
                        }
                    case MenuAnimal.TAKE_CARE: // take care next animal
                        {
                            Animal ani;
                            Console.Write("\n\tpress R for regulal animals or U for urgent animals: ");
                            char urgent = char.Parse(Console.ReadLine());
                            if (urgent == 'R')
                                ani = service.TakeCareNextAnimal(false);
                            else
                                ani = service.TakeCareNextAnimal(true);
                            if (ani != null)
                            {
                                Console.WriteLine("Take care of animal:");
                                ani.PrintAnimalInfo();
                            }
                            else
                                Console.WriteLine("\n\t - There are no waiting animals in list");
                            break;
                        }
                    case MenuAnimal.PRINT: // Print animals
                        Console.WriteLine("Which animal list do you want to display?");
                        Console.WriteLine("Regular animal list - press R\nUrgent animal list - press U");
                        char type = char.Parse(Console.ReadLine());
                        if (type == 'R')
                            service.PrintRegularAnimals();
                        else
                            service.PrintUrgentAnimals();
                        break;
                    case MenuAnimal.EXIT: // Exit
                        Console.WriteLine("Have a nice day!");
                        break;
                    default:
                        Console.WriteLine("\n\t{{ Wrong Selection }}");
                        break;
                }
                Console.WriteLine("\n\n\tPress Anykey For The Menu");
                Console.ReadLine();
            } while (menuChoice != MenuAnimal.EXIT);

        }
    }     
}