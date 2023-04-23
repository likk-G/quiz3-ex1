using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise1
{
    public class Teacher
    {
        private string _name;
        private string _surname;
        private Subject[] _subjects;
        private int _numOfSubjects;

        public Teacher()
        {
            _name = string.Empty;
            _surname = string.Empty;
            _subjects = new Subject[3];
        }

        public Teacher(string name, string surname)
        {
            _name = name;
            _surname = surname;
            _subjects = new Subject[3];
        }

        public void SetName(string name) { _name = name; }
        public void SetSurname(string surname) { _surname = surname; }
        public void AddSubject(Subject subject)
        {
            if (_numOfSubjects < 3)
            {
                _subjects[_numOfSubjects++] = subject;
            }
            else
            {
                Console.WriteLine("Unable to add: Teacher has already reached maximum limit of subjects");
            }
        }
        public void ReplaceSubject(Subject subjectToRemove, Subject subjectToAdd)
        {
            for (int i = 0; i < 3; i++)
            {
                if (_subjects[i] == subjectToRemove)
                {
                    _subjects[i] = subjectToAdd;
                    break;
                }
            }
        }

        public void ViewSubjects()
        {
            for (int i = 0; i < _numOfSubjects; i++)
            {
                Console.WriteLine($"{_subjects[i]} ");
            }
        }
        public override string ToString()
        {
            return $"Name: {_name}\nsurname: {_surname}\nAmount of subjects: {_numOfSubjects}";
        }

    }
}
