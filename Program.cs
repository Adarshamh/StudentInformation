using StudentInformation;


#region constructor injection

        Student obj = new Student("Bharath","J");
        obj.displayfl();
        string val = obj.displaystringfl();
        Console.WriteLine(val);

#endregion constuctor injection


#region Property injection

        Student obj2 = new Student();
        obj2.fname = "Adarsh";
        obj2.lname = "MH";
        obj2.displayfl();
        string val2 = obj2.displaystringfl();
        Console.WriteLine(val2);

        Student obj3 = new Student();
        obj3.FirstName = "Abhishek";
        obj3.LastName = "G";
        obj3.Age = 21;
        obj3.AdmissionDate = new DateTime(2008, 08, 17);
        obj3.IsUG = false;
        obj3.IsPG = "Yes";
        obj3.displaystudentdetails(obj3);
        obj3.studentanug(obj3);

        Student obj4 = new Student();
        obj4.FirstName = "Abhishek";
        obj4.LastName = "G";
        obj4.Age = 25;
        obj4.AdmissionDate = new DateTime(2008, 08, 17);
        obj4.IsUG = true;
        obj4.IsPG = "No";
        obj4.displaystudentdetails(obj4);
        obj4.studentanug(obj4);

#endregion Property injection


#region method injection

        Student obj5 = new Student();
        obj5.displayfl();
        string val5 = obj5.displaystringfl();
        Console.WriteLine(val5);

#endregion method injection