using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformation
{

    public class Student
    {

        #region variables

        public string fname = string.Empty;
        public string lname = string.Empty;

        #endregion variables


        #region property Injection

        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int Age { get; set; }
        public DateTime AdmissionDate { get; set; }
        public bool IsUG { get; set; }
        public string IsPG { get; set; }

        #endregion property Injection



        #region constructor

        //////empty constuctor
        public Student()
        {

        }


        /////Passing one parameter
        public Student(string sfname)
        {
            fname = sfname;
        }


        /////Passing two parameters
        public Student(string sfname, string slname)
        {
            fname = sfname;
            lname = slname;
        }

        #endregion constructor



        #region method

        public void displayfl()
        {
            Console.WriteLine("Firstname:->" + fname + " Lastname:->" + lname );
        }

        public string displaystringfl()
        {
            string val = fname + "  " + lname ;
            return val;
        }

        public void displaystudentdetails(Student student)
        {
            Console.WriteLine("Firstname:->" + student.FirstName);
            Console.WriteLine("Lastname:->" + student.LastName);
            Console.WriteLine("Age:->" + student.Age);
            Console.WriteLine("AdmissionDate:->" + student.AdmissionDate.ToString("dddd, dd MMMM yyyy"));
            Console.WriteLine("IsUG:->" + student.IsUG);
            Console.WriteLine("IsPG:->" + student.IsPG);
        }

        public void studentanug(Student student)
        {
            /* if (student.IsUG)
                 Console.WriteLine(" Firstname:-> " + student.FirstName + " Lastname:-> " + student.LastName + " an UG ");
             else
                 Console.WriteLine(" Firstname:-> " + student.FirstName + " Lastname:-> " + student.LastName + " not an UG ");*/

            bool IsUG = (student.IsUG) && (student.IsPG.Equals("No"));

            if (IsUG)
                Console.WriteLine(" Firstname:-> " + student.FirstName + " Lastname:-> " + student.LastName + " an UG ");
            else
                Console.WriteLine(" Firstname:-> " + student.FirstName + " Lastname:-> " + student.LastName + " an PG ");
        }

        public void studentagelimit(Student student)
        {
           
            if (student.Age < 24)
                Console.WriteLine(" Firstname:->" + student.FirstName + " Lastname:-> " + student.LastName + " an UG ");
            else
                Console.WriteLine(" Firstname:->" + student.FirstName + " Lastname:-> " + student.LastName + " an PG ");
        }

        public void studentYearlimitonDate(Student student)
        {

            if (student.Age < 24)
                Console.WriteLine(" Firstname:->" + student.FirstName + " Lastname:-> " + student.LastName + " an UG ");
            else
                Console.WriteLine(" Firstname:->" + student.FirstName + " Lastname:-> " + student.LastName + " an PG ");
        }



        #endregion method
    }
}

