using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformation
{
    public class Student
    {
        #region property Injection

        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int RollNo { get; set; }
        public DateTime AdmissionDate { get; set; }
        public bool IsUG { get; set; }
        public string? IsPG { get; set; }

        #endregion property Injection



        #region constructor

        //////empty constuctor
        public Student()
        {

        }


        /////Passing one parameter
        public Student(string firstname)
        {
            FirstName = firstname;
        }


        /////Passing two parameters
        public Student(string firstname, string lastname)
        {
            FirstName = firstname;
            LastName = lastname;
        }


        ////////passing three parameters
        public Student(string firstname, string lastname, int rollno)
        {
            FirstName = firstname;
            LastName = lastname;
            RollNo = rollno;
        }

        ////////Passing four parameters
        public Student(string firstname, string lastname, int rollno, DateTime admissiondate)
        {
            FirstName = firstname;
            LastName = lastname;
            RollNo = rollno;
            AdmissionDate = admissiondate;
        }

        ////////Passing five parameters
        public Student(string firstname, string lastname, int rollno, DateTime admissiondate, bool ug)
        {
            FirstName = firstname;
            LastName = lastname;
            RollNo = rollno;
            AdmissionDate = admissiondate;
            IsUG = ug;
        }

        ////////Passing six parameters
        public Student(string firstname, string lastname, int rollno, DateTime admissiondate, bool ug, String pg)
        {
            FirstName = firstname;
            LastName = lastname;
            RollNo = rollno;
            AdmissionDate = admissiondate;
            IsUG = ug;
            IsPG = pg;
        }

        #endregion constructor



        #region method

        /////creating method
        /* public void displaystudentdetails(string firstname, string lastname, int rollno, DateTime admissiondate, bool ug)
         {
             Console.WriteLine("Firstname:->" + firstname + "Lastname:->"+ lastname + "Rollno:->" + rollno + "Admission Date:->" + admissiondate + "IsUG:->"+ ug);
         }*/

        ///insted of writing whole thing like above we just take student as an object inside method for below method

        public void displaystudentdetails(Student student)
        {
            Console.WriteLine("Firstname:->" + student.FirstName);
            Console.WriteLine("Lastname:->" + student.LastName);
            Console.WriteLine("Rollno:->" + student.RollNo);
            Console.WriteLine("Admission Date:" + student.AdmissionDate.ToString("dddd, dd MMMM yyyy"));
            Console.WriteLine("IsUG:->" + student.IsUG);
            Console.WriteLine("IsPG:->" + student.IsPG);
        }

        public void studentisinug(Student student)
        {
            if (student.IsUG)
                Console.Write("Firstname:" + student.FirstName + ",Lastname:" + student.LastName + ",Is in UG");
            else
                Console.WriteLine("Firstname:" + student.FirstName + ",Lastname:" + student.LastName + ",Is not in UG");
        }
        #endregion method
    }
}

