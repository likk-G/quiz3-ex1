// See https://aka.ms/new-console-template for more information


using exercise1;
using System.Globalization;

List<Subject> sub1 = new(); 
Subject Math = new("Math", sub1, 30, 4);
sub1.Add(Math);
Subject Calculus = new("Calculus", sub1, 20, 5);

Semester sem1 = new(1);
sem1.AddSubject(Math);
Semester sem2 = new(2);
sem2.AddSubject(Calculus);

Teacher T1 = new("name", "surname");
T1.AddSubject(Calculus);
T1.AddSubject(Math);
T1.ViewSubjects();

Student student1 = new("firstname", "lastname", 47382918273, 16, sem2);
Console.WriteLine(student1.FullName);
Console.WriteLine(student1.ToString());


student1.ViewSubjects();

Console.WriteLine();

student1.AddSubject(Math);
student1.ViewSubjects();



