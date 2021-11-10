using System;

namespace CheckPoint4Alquisalas
{
    class Salary
    {
        double teamLead;
        double asstTeamLead;
        double programmer;
        double teamSalary;

        public double TeamLead
        {
            get { return teamLead; }
            set { teamLead = value; }
        }
        public double AsstTeamLead
        {
            get { return asstTeamLead; }
            set { asstTeamLead = value; }
        }
        public double Programmer
        {
            get { return programmer; }
            set { programmer = value; }
        }
    }
    public double ComputeSalary(int position, double regularHours, double OTHours, int individualOrTeam)
    {
        //INSERT CODES HERE
        double netSalary;
        double rate;

        if (this.individualOrTeam == 1)
        {
            if (position == 1)
            {
                netSalary = rate  * regularHours + rate * OTHours * 0.80;
            }
            else if (position == 2)
            {
                netSalary = rate * regularHours + rate * OTHours * 0.80;
            }
            else if (position == 3)
            {
                netSalary = rate * regularHours + rate * OTHours * 0.80;
            }
        }
        return netSalary;
    }
    public double ComputeTeamSalary(Employee[] employees)
    {
        //INSERT CODES HERE
        double teamSalary;

        int count = 0;
        while (count < 2)
        {
            teamSalary = employees[count].Rate * employees[count].RegularHoursDuty + employees[count].Rate * employees[count].OTHoursDuty * 0.80;
            count++;
        }
        return teamSalary;
    }
}
