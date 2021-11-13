using System;
using System.Collections.Generic;
using System.Text;

namespace In_class_example
{
    public class Student
    {
        public int SoonerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsOnProbation { get; set; }
        public double GPA { get; set; }
        
        private double BursarBalance;

        //public List<string> Majors { get; set; }
        //public UniversityCourse course { get; set; }

        /// <summary>
        /// Default/Empty Constructor (setting above values to a default)
        /// </summary>
        //ctor + tab + tab (shortcut)
        public Student()
        {
            SoonerID = 0;
            FirstName = string.Empty;
            LastName = string.Empty;
            IsOnProbation = false;
            GPA = 0;
            BursarBalance = 0;

            //Majors = new List<string>();
            //course = new UniversityCourse();
        }

        /// <summary>
        /// Overload Constructor
        /// </summary>
        /// <param name="id"></param>
        /// <param name="fName"></param>
        /// <param name="lName"></param>
        /// <param name="BursarBalance"></param>
        public Student(int id, string fName, string lName, double BursarBalance)
        {
            SoonerID = id;
            FirstName = fName;
            LastName = lName;
            IsOnProbation = false;
            GPA = 0;
            this.BursarBalance = BursarBalance;

        }

        public void MakePayment(double amount)
        {
            if (amount < 0)
            {
                Console.WriteLine("invalid");
            }

            BursarBalance -= amount;
            //BursarBalance = BursarBalance - amount
        }

        public double CheckBalance()
        {
            return BursarBalance;
        }

        public override string ToString()
        {
            return $"{LastName}, {FirstName} ({SoonerID.ToString("N0")})";
        }

    }

    //public class UniversityCourse
    //{

    //}
}
