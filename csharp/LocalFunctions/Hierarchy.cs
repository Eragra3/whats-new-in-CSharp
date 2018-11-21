namespace LocalFunctions
{
    abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Student : Person
    {
        public string Index { get; set; }
    }

    class Programmer : Person, IHasSightDefect
    {
        public SkillLevel CSharp { get; set; }
        public SkillLevel Java { get; set; }

        public (double leftEye, double rightEye) SightDefect { get; set; }
    }

    interface IHasSightDefect
    {
        (double leftEye, double rightEye) SightDefect { get; }
    }

    enum SkillLevel
    {
        None,
        Basic,
        Intermediate,
        Expert
    }
}
