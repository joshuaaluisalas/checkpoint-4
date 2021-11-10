using System;

namespace CheckPoint4Alquisalas
{
    class Employee : Person
    {
        string empID;
        int position;
        double rate;
        double regularHoursDuty = 0;
        double otHoursDuty = 0;

        public string EmpID
        {
            get { return empID; }
            set { empID = value; }
        }
        public int Position
        {
            get { return position; }
            set { position = value; }
        }
        public double Rate
        {
            get { return rate; }
            set { rate = value; }
        }

        public double RegularHoursDuty
        {
            get { return regularHoursDuty; }
            set { regularHoursDuty = value; }
        }
        public double OTHoursDuty
        {
            get { return otHoursDuty; }
            set { otHoursDuty = value; }
        }
        public override void DisplayInfo()
        {

            base.DisplayInfo();
        }
    }
}

//        public void DisplayInfo(int forSalaryEntry)
//        {
//            //INSERT CODES HERE

//        }

//    }
//}