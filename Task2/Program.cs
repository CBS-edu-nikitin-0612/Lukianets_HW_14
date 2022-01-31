using System;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GoodPupil gp1 = new GoodPupil("Good", "Pupil");
            BadPupil bp1 = new BadPupil("Bad", "Pupil");
            ExcelentPupil exp1 = new ExcelentPupil("Bad", "Pupil");
            GoodPupil gp2 = new GoodPupil("Second Goog", "Pupil");

            ClassRoom classRoom1 = new ClassRoom(1, gp1, gp2);
            Console.WriteLine(classRoom1);

            ClassRoom classRoom2 = new ClassRoom(2, gp1, gp2, bp1, exp1);
            Console.WriteLine(classRoom2);
        }
    }
}
