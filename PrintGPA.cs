namespace GPACalculator
{
    public class PrintGPA
    {
        public static void PrintTable(List<Course> courses)
        {
            Console.WriteLine("|----------------------------|-----------------------|------------|---------------------|-------------------|-------------------|");
            Console.WriteLine("| COURSE & CODE              | COURSE UNIT           | GRADE      | GRADE-UNIT          | WEIGHT Pt.        | REMARK            |");
            Console.WriteLine("|----------------------------|-----------------------|------------|---------------------|-------------------|-------------------|");

            foreach (var course in courses)
            {
                Console.WriteLine($"| {course.Code,-26} | {course.Unit,-21} | {course.Grade,-10} | {course.GradeUnit,-19} | {course.WeightPoint,-17} | {course.Remark,-17} |");
            }

            Console.WriteLine("|----------------------------|-----------------------|------------|---------------------|-------------------|-------------------|");
            /*GPACalculations gPACalculations = new GPACalculations();
            double GPA = GPACalculations.GetGpa();
            Console.WriteLine($"Your GPA for the above courses is {GPA}");*/
        }
    }

}
