using InternshipTest.Person;
using System.Collections.Generic;

namespace InternshipTest.Institution.InterLink
{
    public class Internship
    {
        public string IntershipName { get; private set; }
        private List<University> Universities; //List of universities
        private List<Student> Students; //List of students whose are accepted for recruitment
        public Internship(string name)
        {
            IntershipName = name; //Set name of Intership
            Universities = new List<University>();
            Students = new List<Student>();
        }

        public void AddUniversity(University university)
        {
            Universities.Add(university);
        }

        private void AcceptStudent() //Find students for intership
        {
            foreach (University university in Universities)
            {
                var lst = university.GetStudetsForIntership();
                if (lst.Count == 0)
                {
                    continue;
                }
                Students.AddRange(lst);
            }
        }

        public string GetStudents() //return intern-students
        {
            string acceptedStr = string.Empty;
            AcceptStudent();
            foreach (Student student in Students)
            {
                acceptedStr += student.StudentName + "\n";
            }
            return acceptedStr;
        }
    }
}
