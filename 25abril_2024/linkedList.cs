using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25abril_2024
{
    internal class linkedList
    {
        private String name;
        private Nodes head;

        public linkedList(string name)
        {
            this.name = name;
            this.head = null;
        }

        public void setName (String name) { this.name = name; }
        public String getName () { return this.name; }
        public void setHead (Nodes head) { this.head = head; }
        public Nodes getHead () { return this.head; }

        public bool isEmpty()
        {
            return this.head == null;
        }

        public void addNode (Nodes newNode)
        {
            if (isEmpty())
            {
                this.head = newNode;
            } else
            {
                Nodes aux = this.head;
                while (aux.getNext() != null)
                {
                    aux = aux.getNext();
                }
                aux.setNext(newNode);
            }
        }
        public void printData()
        {
            Nodes aux = this.head;
            while (aux != null)
            {
                Console.WriteLine($"Nombre: {aux.getValue().getName()}");
                aux = aux.getNext();
            }  
        }
        
        public void removeNode()
        {
            if (!isEmpty())
            {
                Nodes aux = this.head;
                while (aux.getNext() != null)
                {
                    if(aux.getNext().getNext() == null)
                    {
                        break;
                    }
                    aux= aux.getNext();
                }
                aux.setNext(null);
            }
        }
    }
}
