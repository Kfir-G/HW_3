using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Animal
    {
        //------data fields-------
        uint code;
        string name;
        char kind; // M or F
        float weight; // 0-150 kg
        bool isSea; // if it water animal

        //------constructors------
        public Animal(uint code, string name, char kind, float weight, bool isSea)
        {
            SetCode(code);
            SetName(name);
            SetKind(kind);
            SetWeight(weight);
            SetIsSea(isSea);
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
        //print info:
        public void printAnimalInfo()
        {
            Console.WriteLine("Animal -\nCode:" + code + "\nName:" + name + "\nKind:" + kind + "\nWeight:" + weight + "\nWater Animal:" + isSea);
        }
    }
}
