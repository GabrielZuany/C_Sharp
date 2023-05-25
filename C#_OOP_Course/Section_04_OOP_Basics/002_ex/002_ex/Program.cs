using System;


namespace _002_ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("John", 20);
            Person p2 = new Person("Mary", 30);
            Person older = Older(p1, p2);
            Person newer = Newer(p1, p2);
            Console.WriteLine(older.GetName() + " is older than " + newer.GetName());
        }

        static Person Older(Person p1, Person p2)
        {
            if (p1.GetAge() > p2.GetAge())
            {
                return p1;
            }
            return p2;
        }
        
        static Person Newer(Person p1, Person p2)
        {
            if (p1.GetAge() < p2.GetAge())
            {
                return p1;
            }
            return p2;
        }
    }


    class Person
    {
        private string Name;
        private int Age;

        public Person(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }

        public void SetName(string Name)
        {
            this.Name = Name;
        }
        public void SetAge(int Age)
        {
            this.Age = Age;
        }

        public string GetName()
        {
            return Name;
        }

        public int GetAge()
        {
            return Age;
        }
    }
}
