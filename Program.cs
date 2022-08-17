using StudentInformation;




List<Student> studentslist = new List<Student>();

Student obj = new Student();

studentslist.Add(obj);

obj.FirstName = "Abhishek";
obj.LastName = "G";
obj.RollNo = 1;
obj.AdmissionDate = new DateTime(2008, 03, 12);
obj.IsUG = false;
obj.IsPG = "Yes";
obj.displaystudentdetails(obj);
obj.studentisinug(obj);

studentslist.Add(obj);

obj.FirstName = "Adarsh";
obj.LastName = "H";
obj.RollNo = 2;
obj.AdmissionDate = new DateTime(2008, 03, 2);
obj.IsUG = true;
obj.IsPG = "No";
obj.displaystudentdetails(obj);
obj.studentisinug(obj);


studentslist.Add(obj);

obj.FirstName = "Bharath";
obj.LastName = "J";
obj.RollNo = 3;
obj.AdmissionDate = new DateTime(2008, 03, 15);
obj.IsUG = false;
obj.IsPG = "Yes";
obj.displaystudentdetails(obj);
obj.studentisinug(obj);


////////looping through the list of students///////////////

foreach (Student Currentstudent in studentslist)
{
    Console.WriteLine(obj);
}
