using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25abril_2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            linkedList myList = new linkedList("Estudiantes");
            Nodes node = new Nodes(new Person("Pablo", "Paredes", "23/09/2005"));
            myList.addNode(node);
            node = new Nodes(new Person("Jose", "De Leon", "31/1/2001"));
            myList.addNode(node);
            node = new Nodes(new Person("Luis", "Paz", "23/5/2004"));
            myList.addNode(node,5);

            myList.inversePrintData();

            Console.WriteLine("------------------------");

            myList.printData();

            Console.WriteLine("------------------------");

            //myList.removeNode();
            //myList.printData();


            Console.ReadKey();
        }
    }
}
