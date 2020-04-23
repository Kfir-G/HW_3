using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_3
{
    class Animal
    {
        //------static fields------
        //healthAnimalsCounter:
        public static int healthAnimalsCounter;
        public static void ClearHealthAnimalCounter() { healthAnimalsCounter = 0; }  // switch public static**
        public static void ShowHealthAnimalCounter() { Console.WriteLine(healthAnimalsCounter); }
        //sickAnimalsCounter
        public static int sickAnimalsCounter;
        public static void ClearSickAnimalsCounter() { sickAnimalsCounter = 0; }     //**
        public static void ShowSickAnimalsCounter() { Console.WriteLine(sickAnimalsCounter); }

        //------data fields-------
        uint code;
        string name;
        char kind; // M or F
        float weight; // 0-150 kg
        bool isSea; // if it water animal
        int position; //potision in the line
        bool urgent; //urgency


        //------constructors------
        public Animal(uint code, string name, char kind, float weight, bool isSea, int position, bool urgent)
        {
            SetCode(code);
            SetName(name);
            SetKind(kind);
            SetWeight(weight);
            SetIsSea(isSea);
            SetPosition(position);
            SetUrgent(urgent);
        }

        //-------methods-------

        //sets:
        public void SetCode(uint code)
        {
            this.code = code;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public void SetKind(char kind)
        {
            if (kind == 'M' || kind == 'F')
                this.kind = kind;
            else
            {
                Console.WriteLine("ERROR- kind should be M/F");
                this.kind = 'M'; //default value
            }
        }
        public void SetWeight(float weight)
        {
            if (weight > 0 && weight <= 150)
                this.weight = weight;
            else
            {
                Console.WriteLine("ERROR- weight should be between 0-150");
                this.weight = 15; //default value
            }
        }
        public void SetIsSea(bool isSea)
        {
            this.isSea = isSea;
        }
        public void SetPosition(int position)
        {
            this.position = position;
        }
        public void SetUrgent (bool urgent)
        {
            this.urgent = urgent;
        }
        //gets:
        public uint GetCode()
        {
            return code;
        }
        public string GetName()
        {
            return name;
        }
        public char GetKind()
        {
            return kind;
        }
        public float GetWeight()
        {
            return weight;
        }
        public bool GetIsSea()
        {
            return isSea;
        }
        public int GetPosition()
        {
            return position;
        }
        public bool GetUrgent()
        {
            return urgent;
        }
        //print info:
        public void printAnimalInfo()
        {
            Console.WriteLine("Animal -\nCode:" + code + "\nName:" + name + "\nKind:" + kind + "\nWeight:" + weight + "\nWater Animal:" + isSea + "\nPosition in the line:" + position + "\nIt is urgent:" + urgent);
        }
    }
}
