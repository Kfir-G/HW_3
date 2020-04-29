using System;
using System.Collections.Generic;
using System.Text;

namespace HW_3
{
    class Service
    {
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
        public void printUrgentAnimals()
        {
            for (int i = 0; i < Sick_Animals.getLastPos(); i++)
                Sick_Animals.Getsick(i).PrintAnimalInfo();
        }

        public void printRegularAnimals()
        {
            for (int i = 0; i < Health_Animals.GetLastPos(); i++)
                Health_Animals.Gethealth(i).PrintAnimalInfo();
        }

        public void TakeCareNextAnimal(bool tmp)
        {
            if (tmp == true)
                Sick_Animals.Pop();
            else
                Health_Animals.Dequeue();
        }
    }
}