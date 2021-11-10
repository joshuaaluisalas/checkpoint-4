walusing System;

namespace CheckPoint4Alquisalas
{
    class Person
    {
        string fName;
        string mName;
        string lName;
        int age;
        string gender;

        public string FName
        {
            set { fName = value; }
            get { return fName; }
        }
        public string MName
        {
            set { mName = value; }
            get { return mName; }
        }
        public string LName
        {
            set { lName = value; }
            get { return lName; }
        }
        public int Age
        {
            set { age = value; }
            get { return age; }
        }
        public string Gender
        {
            set { gender = value; }
            get { return gender; }
        }

        public virtual void DisplayInfo()
        {
            int count;
            count = 0;
            while (count < 4)
            {
                Console.WriteLine("\nEnter Duty and OT Hours for Employee {0}", count + 1);
                count++;
            }
        }
    }
}