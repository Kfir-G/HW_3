using System;
using System.Collections.Generic;
using System.Text;

namespace HW_3
{
    class Queue
    {
        //--------data fields--------
        readonly Animal [] HealthAnimals; // queue array of animals
        int emptyCell; //index of empty cell  =0?

        //---------constructors---------
        public Queue(int sizeArr)
        {
            emptyCell = 0;
            this.HealthAnimals = new Animal[sizeArr];
        }
        public Queue () :this(1)
        {
           
        }

        //----------methods------------
        public Animal GetHealth(int idx)
        {
            return HealthAnimals[idx];
        }
        public bool IsEmpty()
        {
            if (emptyCell == 0)
                return true;
            return false;
        }
        public bool IsFull()
        {
            if (emptyCell >= HealthAnimals.Length)
                return true;
            return false;
        }
        public int GetLastPos()
        {
            return emptyCell;
        }
        public void SetDownAllPos()
        {
            for (int i = 0; i < GetLastPos(); i++)
                HealthAnimals[i].SetPosition(i - 1);
        }
        public void Enqueue(Animal temp)
        {
           if(IsEmpty()==false) 
           {
                Console.WriteLine("The queue is FULL");
                return;
           }
            HealthAnimals[emptyCell] = temp; 
            emptyCell++;
            return;
        }
        public Animal Dequeue() 
        {
            if (IsEmpty())
                return null;
            Animal animalTemp = HealthAnimals[0];
            for (int i = 0; i < GetLastPos() - 1; i++)
                HealthAnimals[i] = HealthAnimals[i + 1];
            SetDownAllPos();
            //Animal.helth_anim--;
            emptyCell--;
            return animalTemp;
        }
        public void PrintQueue()
        {
            foreach (Animal animal in HealthAnimals)
                animal.PrintAnimalInfo();
        }
    }
}
