using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25abril_2024
{
    internal class Nodes
    {
        private Person value;
        private Nodes next;

        public Nodes(Person value)
        {
            this.value = value;
            this.next = null;
        }

        public void setValue (Person value) { this.value = value; }
        public void setNext (Nodes next) { this.next = next; }
        public Person getValue () { return this.value;}
        public Nodes getNext () { return this.next;}
    }
}
