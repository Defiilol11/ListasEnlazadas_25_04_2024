using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _25abril_2024
{
    internal class Person
    {
        private String name;
        private String lastName;
        private String birthday;

        public Person(string name, string lastName, string birthday)
        {
            this.name = name;
            this.lastName = lastName;
            this.birthday = birthday;
        }

        public void setName(String name) { this.name = name; }
        public void setLastName(String lastName) { this.lastName = lastName; }
        public void setBirthday(String birthday) { this.birthday = birthday; }
        public String getName () { return this.name; }
        public String getLastName () { return this.lastName; }
        public String getBirthday () { return this.birthday; }
    }
}
