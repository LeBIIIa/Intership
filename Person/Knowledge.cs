namespace InternshipTest
{
    public class Knowledge
    {
        public enum Levels { A = 5, B = 4, C = 3, D = 2, E = 1, NONE = 0 } //Range of levels
        public Levels Level { get; private set; } //Properties for level
        public Knowledge(Levels level)
        {
            Level = level;
        }
      
    }
}
