using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _25abril_2024
{
    internal class linkedList
    {
        private String name;
        private Nodes head;
        private Nodes tail;

        public linkedList(string name)
        {
            this.name = name;
            this.head = null;
            this.tail = null;
        }

        public void setName (String name) { this.name = name; }
        public String getName () { return this.name; }
        public void setHead (Nodes head) { this.head = head; }
        public Nodes getHead () { return this.head; }
        public void setTail (Nodes tail) {  this.tail = tail; }
        public Nodes getTail () { return this.tail; }

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
                newNode.setPrevious(aux);
                this.tail = newNode;
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
                Nodes last = null;
                Nodes aux = this.head;
                while (aux.getNext() != null)
                {
                    if(aux.getNext().getNext() == null)
                    {
                        last = aux.getNext();
                        break;
                    }
                    aux = aux.getNext();
                }
                last.setPrevious(null);
                aux.setNext(null);
                this.tail = aux;
            }
        }

        public void inversePrintData()
        {
            Nodes aux = this.tail;
            while (aux != null)
            {
                Console.WriteLine($"Nombre: {aux.getValue().getName()}");
                aux = aux.getPrevious();
            }
        }

        public void addNode(Nodes newNode, int index)
        {
            if (index < 0)
            {
                throw new ArgumentOutOfRangeException("Index cannot be negative.");
            }

            if (index == 0)
            {
                if (isEmpty())
                {
                    this.head = newNode;
                    this.tail = newNode;
                }
                else
                {
                    newNode.setNext(this.head);
                    this.head.setPrevious(newNode);
                    this.head = newNode;
                }
            }
            else
            {
                Nodes current = this.head;
                int currentIndex = 0;

                while (current != null && currentIndex < index - 1)
                {
                    current = current.getNext();
                    currentIndex++;
                }

                if (current == null)
                {
                    current = this.tail;
                    //throw new ArgumentOutOfRangeException("Index is out of range.");
                }

                newNode.setNext(current.getNext());
                if (current.getNext() != null)
                {
                    current.getNext().setPrevious(newNode);
                }
                newNode.setPrevious(current);
                current.setNext(newNode);

                if (newNode.getNext() == null)
                {
                    this.tail = newNode;
                }
            }
        }


    }
}
