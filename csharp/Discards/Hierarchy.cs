namespace PatternMatching
{
    abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void Deconstruct(out string firstName, out string lastName)
        {
            firstName = FirstName;
            lastName = LastName;
        }
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

        public void Deconstruct(out string firstName, out string lastName,
            out (double leftEye, double rightEye) sightDefect)
        {
            base.Deconstruct(out firstName, out lastName);
            sightDefect = SightDefect;
        }
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
