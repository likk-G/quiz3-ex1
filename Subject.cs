using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise1
{
    public class Subject
    {
        private string _subjectName;
        private List<Subject> _prerequisites;
        private int _maxStudents;
        private int _credits;
//        private Teacher _teacher;

        public Subject()
        {
            _subjectName = string.Empty;
            _prerequisites = new List<Subject>();
            _maxStudents = 0;
            _credits = 0;
        }

        public Subject(string subjectName, List<Subject> prerequisites, int maxStudents, int credits)
        {
            _subjectName = subjectName;
            _prerequisites = prerequisites;
            _maxStudents = maxStudents;
            _credits = credits;
        }

        public void SetName(string name) { _subjectName = name; }

        public void AddPrerequisites(Subject prerequisite) { _prerequisites.Add(prerequisite); }

        public void SetMaxStudents(int maxStudents) { _maxStudents = maxStudents; }

        public void SetCredits(int credits) { _credits = credits; }


        public override string ToString()
        {
            return $"Subject name: {_subjectName}\nMaximum amount of students: {_maxStudents}\nCredits: {_credits}";
        }
    }
}
