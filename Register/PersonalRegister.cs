using System;
using System.Collections.Generic;

namespace Register
{
    internal class PersonalRegister
    {
        private List<Person> personList;

        public void AddPerson(Person aPerson)
        {
            personList.Add(aPerson);
        }

        internal void WriteConsole()
        {
            foreach(Person aPerson in personList)
            {
                aPerson.WriteConsole();
            }
        }

        public void RemovePerson(Person aPerson)
        {
            personList.Remove(aPerson);
        }
    }
}