using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong8
{
    //demo
    public class Customer
    {
        private int id = -1;
        private string name = string.Empty;
        // constructor
        public Customer(int id, string name)
        {
            this.id = id;
            this.name = name;

        }
        // khai bao read- only properties cho field id
        public int Id
        {
            get { return id; }
        }
        public string Name
        {

            get { return name; }
        }

    }
    class Person
    {
        private string name = "Hung";
        private int age = 0;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }

        }

        public int Age
        {
            get => age;
            set => age = value;
        }
        public override string ToString()
        {
            return $"Name:{name}, age:{age}";
        }
    }
}

