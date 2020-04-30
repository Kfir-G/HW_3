using System;
using System.Collections.Generic;
using System.Text;

namespace HW_3
{
    class Service
    {
        //Animal animalTemp;
        const int SIZE = 10;
        
        //------data fields------
        public Queue Health_Animals;
        public Stack Sick_Animals;

        //-----constructors------
        public Service ()
        {
            Health_Animals = new Queue(SIZE);
            Sick_Animals = new Stack(SIZE);
        }

        //------methods--------
        public void PrintUrgentAnimals()
        {
            for (int i = 0; i < Sick_Animals.GetLastPos(); i++)
                Sick_Animals.GetSick(i).PrintAnimalInfo();
        }

        public void PrintRegularAnimals()
        {
            for (int i = 0; i < Health_Animals.GetLastPos(); i++)
                Health_Animals.GetHealth(i).PrintAnimalInfo();
        }

        public Animal TakeCareNextAnimal(bool tmp)
        {
            if (tmp == true)
               return Sick_Animals.Pop();
            else
               return Health_Animals.Dequeue();
        }
        public void AddNewAnimal()
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
            Animal animalTemp =new Animal(code, name, kind, weight, isSea, position, urgent);
            if (urgent == true)
                Sick_Animals.Push(animalTemp);
            else
                Health_Animals.Enqueue(animalTemp);
            return;
        }
    }
}