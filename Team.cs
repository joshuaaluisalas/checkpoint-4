using System;

namespace CheckPoint4Alquisalas
{
    class Team
    {
        public void DisplayTeamMembers(Employee[] employees)
        {
            //INSERT CODES HERE
            int count;

            count = 0;

            while (count < 4)
            {
                Console.WriteLine("---------------------------------------------------------");
                Console.WriteLine("Information for Employee {0} \n", count + 1);
                Console.WriteLine("Full Name: {0} , {1} {2}", employees[count].LName, employees[count].FName, employees[count].MName);
                Console.WriteLine("Age: {0}", employees[count].Age);
                Console.Write("Gender: ");
                if (employees[count].Gender == "1")
                {
                    Console.Write("Male\n");
                }
                if (employees[count].Gender == "2")
                {
                    Console.Write("Female\n");
                }
                Console.Write("Employee Position: ");
                if (employees[count].Position == 1)
                {
                    Console.Write("Team Lead\n");
                }
                else if (employees[count].Position == 2)
                {
                    Console.Write("Asst. Lead\n");
                }
                else if (employees[count].Position == 3)
                {
                    Console.Write("Programmer\n");
                }
                Console.Write("Salary Rate: ");
                if (employees[count].Position == 1)
                {
                    Console.Write("{0}\n", employees[count].Rate);
                }
                else if (employees[count].Position == 2)
                {
                    Console.Write("{0}\n", employees[count].Rate);
                }
                else if (employees[count].Position == 3)
                {
                    Console.Write("{0}\n", employees[count].Rate);
                }
                count++;
            }
        }
    }
}