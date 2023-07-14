using System;
using System.Collections;

namespace day5example
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Welcome to collection!!!");
            ArrayList arrayList = new ArrayList
            {
                "sam",
                "Ravi",
                "Amitha"
            };
            Console.WriteLine("Number of Element in Array List are :\t" + arrayList.Count);
            Console.WriteLine("Capacity of Array List is:\t" +arrayList.Capacity);
            foreach(var item in arrayList)
            {
                Console.WriteLine(item);
            }
            arrayList.Add("Amit");
            arrayList.Add("sunitha");
            Console.WriteLine("After adding two more elements in array List");
            Console.WriteLine("Number of Elementin Array list are:\t"+ arrayList.Count);
            Console.WriteLine("Capacity of Array listcis :\t"+arrayList.Capacity);
            foreach(var item in arrayList)
            {
                Console.WriteLine(item);
            }
            arrayList.Add("A");
            arrayList.Add("sun");
            Console.WriteLine("After adding two more elements in array List");
            Console.WriteLine("Number of Elementin Array list are:\t" + arrayList.Count);
            Console.WriteLine("Capacity of Array listcis :\t" + arrayList.Capacity);
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            arrayList.Add("manu");
            arrayList.Add("anitha");
            Console.WriteLine("After adding two more elements in array List");
            Console.WriteLine("Number of Elementin Array list are:\t" + arrayList.Count);
            Console.WriteLine("Capacity of Array listcis :\t" + arrayList.Capacity);
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}