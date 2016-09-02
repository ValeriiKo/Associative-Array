using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociableArray
{
    class AssArr
    {
        string [] a;
        public AssArr (int am)//конструктор динамического массива
        {
            if (am > 0) a = new string[am];
            else Console.WriteLine("Кол-во элементов должно быть больше нуля.");
        }

        public string this[char key]
        { //get; set;
            get// вызов элемента массива по ключу
            {
                return a[key];
            }
            set
            {
                a[key] = value;
            }
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            AssArr F = new AssArr(3);
            F['a'] = "Hello!";
            F['b'] = "I";
            F['c'] = "5";
            Console.WriteLine("F['a']=" + F['a'] + "\nF['b']=" + F['b'] + "\nF['c']=" + F['c']);
            Console.ReadKey();
        }
    }
}
