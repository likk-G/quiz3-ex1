using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise1
{
    public class Student
    {
        private string _name;
        private string _surname;
        private readonly long _ID;
        private double _GPA;
        private Semester _currentSemester;
        private List <Subject> _subjects;

        public Student()
        {
            _name = string.Empty;
            _surname = string.Empty;
            _ID = 0;
            _GPA = 0;
            _currentSemester = new Semester();
            _subjects = new List <Subject>();
        }




        public Student(string name, string surname, long ID, double GPA, Semester semester)
        {
            _name = name;
            _surname = surname;
            if (ID < 10000000000 || ID > 99999999999)
            {
                Console.WriteLine("Wrong ID");
            }
            else
            {
                _ID = ID;
            }
            if(GPA >= 0 && GPA <= 35)
            {
                _GPA = GPA;
            }
            _currentSemester = semester;
            _subjects = semester.GetSubjects();
        }

        public void SetName(string name) { _name = name; }
        public void SetSurname(string surname) { _surname = surname; }
        public string FullName
        {
            get
            {
                string Fullname = _name + " " + _surname;
                return $"Fullname: {Fullname}";
            }
        }
        public void SetGPA(double GPA)
        {
            if (GPA >= 0 && GPA <= 35)
            {
                _GPA = GPA;
            }
            else
            {
                Console.WriteLine("Incorrect GPA");
            }
        }
        public void SetCurrentSemester(Semester currentSemester)
        {
            if (currentSemester.GetNumberOfSemester() >= _currentSemester.GetNumberOfSemester())
            {
                _currentSemester = currentSemester;
                _subjects = currentSemester.GetSubjects();
            }
            else
            {
                Console.WriteLine("Wrong Semester");
            }
        }
        public void AddSubject(Subject Subject)
        {
            _subjects.Add(Subject);
            _currentSemester.AddSubject(Subject);
        }
        public void ViewSubjects()
        {
            for(int i = 0; i < _currentSemester.GetNumberOfSubjects(); i++)
            {
                Console.WriteLine($"{_subjects[i]} ");
            }
        }

       

        public override string ToString()
        {
            return $"Name: {_name}\nSurname: {_surname}\nID: {_ID}\nGPA: {_GPA}\nSemester: {_currentSemester.GetNumberOfSemester()}";
        }


    }
}
