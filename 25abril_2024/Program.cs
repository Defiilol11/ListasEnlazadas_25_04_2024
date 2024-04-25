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
            Nodes node1 = new Nodes(new Person("Jose", "De Leon", "31/1/2001"));
            myList.addNode(node1);

            myList.printData();
            Console.ReadKey();
        }
    }
}
