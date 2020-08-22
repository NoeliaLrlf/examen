using System;

namespace ConsoleApp1
{
    public class Person
    {
        private readonly string name;
        private readonly string ci;
        private readonly int age;
        public Address address;
        public string Name { get => name; set => value = name; }

        public Person(string name) => this.name = name;
        

        public override bool Equals(object obj)
        {
            return name == ((Person)obj).name
            && ci == ((Person)obj).ci
            && age == ((Person)obj).age;
        }

        public static bool operator ==(Person a,
                                       Person b)
        {
            return a.Equals(b);
        }

        public static bool operator !=(Person a,
                                      Person b)
        {
            return !(a == b);
        }

        public Person(string name, string ci, int age, Address address)
        {
            this.name = name;
            this.ci = ci;
            this.age = age;
            this.address = address;
        }

        public override int GetHashCode() => HashCode.Combine(name, ci, age);
    }
}