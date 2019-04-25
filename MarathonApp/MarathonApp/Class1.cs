using System;
using System.Collections.Generic;
using System.Text;

namespace MarathonApp
{
    class Class1
    {

        void foo()
        {

            string firstName = "brett";
            string lastName = "sheleski";
            int age = 35;

            string fullNameAndAge = firstName + " " + lastName + " is " + age.ToString() + " years old";

            fullNameAndAge = string.Format("{0} {1} is {2:D2}", firstName, lastName, age);

            fullNameAndAge = $"{firstName} {lastName} is {age:D2} years old.";






        }

    }
}
