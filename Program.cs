using System.Drawing;

namespace GPACalculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            GPACalculations gpaCalculations = new GPACalculations();
            List<Course> courses = gpaCalculations.GetCourseData();

            PrintGPA.PrintTable(courses);

            double gpa = GPACalculations.CalculateGPA(courses);
            double totalCourseUnit = GPACalculations.CalculateGPA(courses);
            double totalCourseUnitPassed = GPACalculations.CalculateGPA(courses);
            double totalWeightPoint = GPACalculations.CalculateGPA(courses);


            Console.WriteLine($"Total Course Unit Registered is: {totalCourseUnit}");
            Console.WriteLine($"Total Course Unit Passed is: {totalCourseUnitPassed}");
            Console.WriteLine($"Total Weight Point is: {totalWeightPoint}");
            Console.WriteLine($"Your GPA for the courses above is: {gpa:F2} to 2 decimal places.");
            
        }
    }
}
