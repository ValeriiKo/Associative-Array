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
        char[] k;
        int i = 0;
        int l, c;
        public AssArr (int am)//конструктор динамического массива
        {
            if (am > 0) a = new string[am];
            else Console.WriteLine("Кол-во элементов должно быть больше нуля.");
            k = new char[am];
            l = am;
        }


        public string this[char key]
        {
            get// вызов элемента массива по ключу
            {
                bool b = false;
                for (int j = 0; j < l; j++)
                {
                    if (k[j] == key)
                    {
                        c = j;
                        b = true;
                    }
                    
                   
                    
                }
                if (b) return a[c];
                else
                {
                    string m="No this key in array!";
                    a[c] = m;
                    return a[c];
                }

            }
            set//присваивание значений по ключу
            {
                bool b = true;
                for (int j = 0; j < l; j++)
                {
                    if (k[j] == key)
                    {
                        a[j] = value;
                        b = false;
                    }
                }
                    if (b)
                    {
                    if (i >= l) Console.WriteLine("В массиве больше нет места!");
                    else
                    {
                        k[i] = key;
                        a[i] = value;
                        i++;
                    }
                }
            }
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            AssArr F = new AssArr(3);
            F['a'] = "1";
            F['b'] = "2";
            F['c'] = "3";
            F['c'] = "4";
            F['b'] = "5";
            F['d'] = "6"; 
            Console.WriteLine("F['a']=" + F['a'] + "\nF['b']=" + F['b'] + "\nF['c']=" + F['c']+ "\nF['b']=" + F['b']);
            Console.WriteLine("F['z']= " + F['z']);
            Console.WriteLine("F['0']= " + F['0']);
            Console.WriteLine("F['d']= " + F['d']);
            Console.ReadKey();
        }
    }
}
