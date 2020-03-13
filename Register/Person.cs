using System;

namespace Register
{
    internal class Person
    {
        private string name;
        private int salary;

       

        public string GetName()
        {
            return name;
        }

        public void SetName(string aName)
        {
            name = aName;
        }

        public int GetSalary()
        {
            return salary;
        }

        public void SetSalary(int aSalary)
        {
            salary = aSalary;
        }

        public void WriteConsole()
        {
            Console.WriteLine(name + "  " + salary);
        }
    }
}