using System;

namespace HW_3
{
    enum MenuAnimal { ADD_ANIMAL, TAKE_CARE, PRINT, EXIT };
    class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue(10);
            Stack stack = new Stack(10);
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

        //-----functions-----
        static Animal AddNewAnimal()
        {
            uint code; string name; float weight; char kind, t; bool isSea, urgent; int position;
            Console.WriteLine("\tAdd new animal:");
            Console.WriteLine("Insert code number:");
            code = uint.Parse(Console.ReadLine());
            Console.WriteLine("Insert name:");
            name = Console.ReadLine();
            Console.WriteLine("Insert weight number:");
            weight = float.Parse(Console.ReadLine());
            Console.WriteLine("The kind animal is Female?-press F\nThe kind animal is Male ? -prees M");
            kind = char.Parse(Console.ReadLine());
            Console.WriteLine("The animal live in water?-press Y\nother - press N");
            t = char.Parse(Console.ReadLine());
            if (t == 'Y')
                isSea = true;
            else
            {
                isSea = false;
                if (t != 'N')
                    Console.WriteLine("Worng input");
            }
            Console.WriteLine("Enter if it is urgent Y/N");
            t = char.Parse(Console.ReadLine());
            if (t == 'Y')
                urgent = true;
            else
            {
                urgent = false;
                if (t != 'N')
                    Console.WriteLine("Worng input");
            }
            Console.WriteLine("Insert The position:");
            position = int.Parse(Console.ReadLine());                     
            return new Animal(code, name, kind, weight, isSea, position, urgent);
        }
        static Animal FindAnimalByCode(Animal[] arr, uint code)
        {
            if (arr[0] == null)
            {
                Console.WriteLine("There's no animals");
                return null; ;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == null)
                {
                    Console.WriteLine("Did NOT find");
                    return null;
                }
                if (arr[i].GetCode() == code)
                {
                    arr[i].PrintAnimalInfo();
                    return arr[i];
                }
            }
            Console.WriteLine("Did NOT find");
            return null; //the code dont match to any animal's code
        }
        static bool EditAnimal(Animal[] arr, uint code)
        {
            if (arr[0] == null)
            {
                Console.WriteLine("There's no animals");
                return false;
            }
            char tempIsSea;
            Animal temp = FindAnimalByCode(arr, code);
            if (temp is null)
            {
                Console.WriteLine("The animal does not exist");
                return false;
            }
            Console.WriteLine("Insert animal new information except kind");
            temp.SetCode(uint.Parse(Console.ReadLine()));
            temp.SetName(Console.ReadLine());
            temp.SetWeight(float.Parse(Console.ReadLine()));
            tempIsSea = char.Parse(Console.ReadLine());
            if (tempIsSea == 'Y')
                temp.SetIsSea(true);
            else
                temp.SetIsSea(false);
            return true;
        }
        static void PrintAnimalByIsSea(Animal[] arr)
        {
            if (arr[0] == null)
            {
                Console.WriteLine("There's no animals");
                return;
            }
            string[] temp = new string[arr.Length + 1]; // array of water animal
            int idxTemp = 0, j;
            bool check = true;
            Console.WriteLine("-------------------------------------------------------------\nThe water animals:");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == null)
                    return;
                if (arr[i].GetIsSea() == true)
                {
                    for (j = 0; j <= idxTemp; j++)
                    {
                        if (arr[i].GetName() == temp[j])
                        {
                            check = false;
                            j = idxTemp;
                        }
                    }
                    if (check == true)
                    {
                        arr[i].PrintAnimalInfo();
                        Console.WriteLine("----------------------------");
                        temp[idxTemp] = arr[i].GetName();
                        idxTemp++;
                    }
                }
                check = true;
            }
        }
    }     
}