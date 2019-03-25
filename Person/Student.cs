namespace InternshipTest.Person
{
    public class Student
    {
        public string StudentName { get; private set; } //Properties for name of student
        public Knowledge Knowledge { get; private set; } // Student`s level of knowledge
        public Student(string name)//Constructor without the level
        {
            StudentName = name;
            Knowledge = new Knowledge(Knowledge.Levels.NONE);
        }
        public Student(string name, Knowledge.Levels knowledge)
        {
            StudentName = name;
            Knowledge = new Knowledge(knowledge);
        }
    }
}