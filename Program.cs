using System;

namespace CheckPoint4Alquisalas
{
    class Program
    {
        static void Main(string[] args)
        {
            Salary theSalary = new Salary();
            Employee[] employees = new Employee[4];
            Employee employee = new Employee();
            Team team = new Team();
            int loop;

            Console.Write("Enter Rate per hour for Team Lead(e.g. 625): ");
            theSalary.TeamLead = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Rate per hour for Asst. Lead(e.g. 375): ");
            theSalary.AsstTeamLead = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Rate per hour for Team Programmer(e.g. 187.50): ");
            theSalary.Programmer = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("------------------------------------------------");

            loop = 0;
            while (loop < 4)
            {
                employees[loop] = new Employee();
                loop++;
            }

            loop = 0;
            while (loop < 4)
            {
                Console.WriteLine("Information For Employee {0}", loop + 1);
                Console.Write("First Name: ");
                employees[loop].FName = Console.ReadLine();
                Console.Write("Middle Name: ");
                employees[loop].MName = Console.ReadLine();
                Console.Write("Last Name: ");
                employees[loop].LName = Console.ReadLine();
                Console.Write("Age: ");
                employees[loop].Age = Int32.Parse(Console.ReadLine());
                Console.Write("Gender(Type 1 for Male, 2 for Female): ");
                employees[loop].Gender = Console.ReadLine();
                Console.Write("Select Position Type( [1] Team Lead , [2] Asst. Lead , [3]Programmer ): ");
                employees[loop].Position = Int32.Parse(Console.ReadLine());
                Console.WriteLine("------------------------------------------------");
                loop++;
            }

            loop = 0;
            while (loop < 4)
            {
                if (employees[loop].Position == 1)
                {
                    employees[loop].Rate = theSalary.TeamLead;
                }
                else if (employees[loop].Position == 2)
                {
                    employees[loop].Rate = theSalary.AsstTeamLead;
                }
                else if (employees[loop].Position == 3)
                {
                    employees[loop].Rate = theSalary.Programmer;
                }
                loop++;
            }
            team.DisplayTeamMembers(employees);

            employee.DisplayInfo();



        }
    }
}