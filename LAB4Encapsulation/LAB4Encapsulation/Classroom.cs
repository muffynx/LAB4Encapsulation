using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4Encapsulation
{
    public class Classroom
    {
        private string name;

        private List<Person> persons = new List<Person>();

        public Classroom(string name)
        {
            this.name = name;
        }

        public void addPerson2Class(Person p)
        {
            this.persons.Add(p);
        }
        public string showAllPersoninClass()
        {
            string result = "";
            foreach (Person p in this.persons)
            {
                result += p.getName() + "\r\n";
            }
            return result;
        }
        public double getAverageGPA()
        {
            if (this.persons.Count ==0) return 0;
            double sum = 0;
            foreach (Person p in this.persons)
            {
                sum += p.GetGPA();
            }
            return sum / this.persons.Count;
        }
        public Person getMaxGPA()
        {
            Person maxPerson = this.persons[0];
            double maxGPA = this.persons[0].GetGPA();
            foreach (Person p in this.persons)
            {
                if (p.GetGPA() > maxGPA)
                {
                    maxGPA = p.GetGPA();
                    maxPerson = p;
                }
            }
            return maxPerson;

        }
        public Person getMinGPA()
        {
            Person minPerson = this.persons[0];
            double minGPA = this.persons[0].GetGPA();
            foreach (Person p in this.persons)
            {
                if (p.GetGPA()< minGPA)
                {
                    minGPA= p.GetGPA();
                    minPerson = p;
                }
            }
            return minPerson;
        }


    }
}
