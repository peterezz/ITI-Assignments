using Day05;

Department dep01 = new() { DeptID = 1, DeptName = "SD" };
Club club01 = new() { ClubID = 1, ClubName = "test01" };
Club club02 = new() { ClubID = 2, ClubName = "test02" };

Empolyee emp01 = new() { Name = "test01", BirthDate = new DateTime(2020, 05, 09, 9, 15, 0) };
Empolyee emp02 = new() { Name = "test02", BirthDate = new DateTime(1960, 05, 09, 9, 15, 0) };
Empolyee emp03 = new() { Name = "test03", BirthDate = new DateTime(1999, 05, 09, 9, 15, 0) };

dep01.AddStuff(emp01); // event subscription
club01.AddMember(emp01);
emp01.RequestVacation(DateTime.Now, DateTime.Now.AddDays(3)); // event firing 
emp01.EndOfYearOperation();// event firing 

dep01.AddStuff(emp02);
club01.AddMember(emp02);
emp02.RequestVacation(DateTime.Now, DateTime.Now.AddDays(22));// event firing 
emp02.EndOfYearOperation(); // event firing 
Console.WriteLine(emp02.VacationStock);

emp01.RequestVacation(DateTime.Now, DateTime.Now.AddDays(19));// event firing

// doesn't print anything
dep01.AddStuff(emp03); // event subscription
club01.AddMember(emp03);
emp01.RequestVacation(DateTime.Now, DateTime.Now.AddDays(3)); // event firing 
emp01.EndOfYearOperation();// event firing

club02.AddMember(emp02);
emp02.RequestVacation(DateTime.Now, DateTime.Now.AddDays(22));// event firing 

Console.WriteLine(emp02.VacationStock);




