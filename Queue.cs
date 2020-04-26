using System;
using System.Collections.Generic;
using System.Text;

namespace HW_3
{
    class Queue
    {
        //--------data fields--------
        Queue <Animal> Animals; // queue array of animals
        int emptyCell; //index of empty cell

        //---------constructors---------
        public Queue(int sizeArr)
        {
            emptyCell = 0;
            Animals = new Queue <Animal>(sizeArr);
        }
        public Queue () :this(1)
        {
           
        }

        //----------methods------------
        public void Enqueue(Queue <Animal> Animals, int emptyCell)
        {
           if(emptyCell<0 || Animals.Count<emptyCell) //check if Animals is full
           {
                Console.WriteLine("The queue is FULL");
                return;
           }
            Animals[emptyCell] = new Animal(); //---?----
            emptyCell++;
            return;
        }
    }
}
