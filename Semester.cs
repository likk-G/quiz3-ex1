using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise1
{
    public class Semester
    {
        private readonly int _numOfSemester;
        private int _numOfSubjects;
        private List<Subject> _subjectsInSemester;

        public Semester()
        {
            _numOfSemester = 0;
            _numOfSubjects = 0;
            _subjectsInSemester = new List<Subject>();

        }
        public Semester(int numOfSemester)
        {
            _numOfSemester = numOfSemester;
            _numOfSubjects = 0;
            _subjectsInSemester = new List<Subject>();
        }

        public int GetNumberOfSemester() { return _numOfSemester; }
        public int GetNumberOfSubjects() { return _numOfSubjects; }
        public List<Subject> GetSubjects() { return _subjectsInSemester;}

        public void AddSubject(Subject subject)
        {
            _subjectsInSemester.Add(subject);
            _numOfSubjects++;
        }
        public void RemoveSubject(Subject subject)
        {
            for(int i=0; i<_numOfSubjects; i++)
            {
                if (_subjectsInSemester[i] == subject)
                {
                    _subjectsInSemester.Remove(subject);
                    _numOfSubjects--;
                    break;
                }
            }
        }

        public void ViewSubjects()
        {
            for(int i=0; i<_numOfSubjects; i++)
            {
                Console.WriteLine($"{_subjectsInSemester[i]} ");
            }
        }
        public override string ToString()
        {
            return $"Semester number: {_numOfSemester}";
        }

    }
}
