using System;
using System.Collections.Generic;
using System.Text;

namespace HW_3
{
    class Queue
    {
        //--------data fields--------
        Animal [] healthAnimals; // queue array of animals
        int emptyCell; //index of empty cell  =0?

        //---------constructors---------
        public Queue(int sizeArr)
        {
            emptyCell = 0;
            this.healthAnimals = new Animal[sizeArr];
        }
        public Queue () :this(1)
        {
           
        }

        //----------methods------------
        public bool IsEmpty()
        {
            if (emptyCell == 0)
                return true;
            return false;
        }
        public bool IsFull()
        {
            if (emptyCell >= healthAnimals.Length)
                return true;
            return false;
        }
        public int GetLastPos()
        {
            return emptyCell;
        }
        public void SetDownAllAnimalPos()
        {
            for (int i = 0; i < GetLastPos(); i++)
                healthAnimals[i].SetPosition(i - 1);
        }
        public void Enqueue(Animal[] heakthAnimals, ref int emptyCell, Animal temp)
        {
           if(IsEmpty()==false) 
           {
                Console.WriteLine("The queue is FULL");
                return;
           }
            healthAnimals[emptyCell] = temp; 
            emptyCell++;
            return;
        }
        public Animal Dequeue () 
        {
            if (IsEmpty())
                return null;
            Animal animalTemp = healthAnimals[0];
            for (int i = 0; i < GetLastPos() - 1; i++)
                healthAnimals[i] = healthAnimals[i + 1];
            SetDownAllAnimalPos();
            //Animal.helth_anim--;
            emptyCell--;
            return animalTemp;
        }
    }
}
