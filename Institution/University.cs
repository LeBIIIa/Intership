using InternshipTest.Person;
using System.Collections.Generic;

namespace InternshipTest.Institution
{
    public class University
    {
        private double AverageKnowledge = 0; //The average level of students knowledge
        private List<Student> students; // list of students
        public string UniversityName { get; private set; } //Name of university
        public University(string name)
        {
            UniversityName = name;
            students = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
            CalculateAverageKnowledge(); //update the average level of students` knowledge
        }

        private void CalculateAverageKnowledge() //Calculate average level of students
        {
            AverageKnowledge = 0;
            foreach (Student student in students)
            {
                AverageKnowledge += ((int)student.Knowledge.Level / (double)students.Count);
            }
        }

        public List<Student> GetStudetsForIntership() //returns list of students that can be accepted for intership
        {
            List<Student> students = new List<Student>();
            foreach (Student student in this.students)
            {
                if ( (double)student.Knowledge.Level >= AverageKnowledge )
                {
                    students.Add(student);
                }
            }
            return students;
        }
    }
}
