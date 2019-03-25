using System;
using InternshipTest.Person;
using InternshipTest.Institution;
using InternshipTest.Institution.InterLink;

namespace InternshipTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // The example of creating an object of class Student
            var student = new Student("Kindii Vasyl");

            // The example of creating an object of class University
            University univer = new University("Lviv Polytechnic");

            // Adding students to university and setting their's level of knowledge
            univer.AddStudent(new Student("Skrypnyk Denys", Knowledge.Levels.B));
            univer.AddStudent(new Student("Vladyslav Barsienko", Knowledge.Levels.C));
            univer.AddStudent(new Student("Yurii Prokopchyk", Knowledge.Levels.B));
            univer.AddStudent(new Student("Vladyslav Kotyk", Knowledge.Levels.A));
            univer.AddStudent(new Student("Oleh Halavin", Knowledge.Levels.A));

            
            Internship internship = new Internship("Interlink");
            internship.AddUniversity(univer); // Adding university to Internship
            Console.WriteLine("List of internship's students:");
            //Get string of students whose level of knowledge is higher than the average
            Console.WriteLine(internship.GetStudents());

            Console.ReadKey();
        }
    }
}
