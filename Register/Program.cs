using System;

namespace Register
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonalRegister persReg = new PersonalRegister();

            Person aPerson = new Person();
            aPerson.SetName("Jörgen");
            aPerson.SetSalary(400000);

            persReg.AddPerson(aPerson);

            persReg.WriteConsole();
        }
    }
}
