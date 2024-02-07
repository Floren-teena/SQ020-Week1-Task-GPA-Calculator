namespace GPACalculator
{
    public class UserData
    {
        public static string GetValidCourseCode()
        {
            string courseCode = "";
            bool validCourseCode = false;
            while (!validCourseCode)
            {
                Console.WriteLine("Enter Course code in the format 'AAA111':");
                courseCode = Console.ReadLine();

                // Check if course code matches the format (3 letters followed by 3 numbers)
                if (courseCode.Length == 6 &&
                    char.IsLetter(courseCode[0]) && char.IsLetter(courseCode[1]) && char.IsLetter(courseCode[2]) &&
                    char.IsDigit(courseCode[3]) && char.IsDigit(courseCode[4]) && char.IsDigit(courseCode[5]) &&
                    char.IsUpper(courseCode[0]) && char.IsUpper(courseCode[1]) && char.IsUpper(courseCode[2]))
                {
                    validCourseCode = true;
                }
                else
                {
                    Console.WriteLine("Invalid course code format. Please enter a 3-letter code followed by 3 digits.");
                }
            }
            return courseCode;
        }

        public static int GetValidCourseUnit()
        {
            int courseUnit = 0;
            bool validCourseUnit = false;
            while (!validCourseUnit)
            {
                Console.WriteLine("Enter the course unit:");
                string unitInput = Console.ReadLine();

                // Check if input is a valid integer
                if (int.TryParse(unitInput, out courseUnit))
                {
                    validCourseUnit = true;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number for the course unit.");
                }
            }
            return courseUnit;
        }

        public static int GetValidCourseScore()
        {
            int courseScore = 0;
            bool validCourseScore = false;
            while (!validCourseScore)
            {
                Console.WriteLine("Enter the course score:");
                string scoreInput = Console.ReadLine();

                // Check if input is a valid integer
                if (int.TryParse(scoreInput, out courseScore))
                {
                    validCourseScore = true;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number for the course score.");
                }
            }
            return courseScore;
        }

        /*class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Welcome to Flo's GPA Calculator App!!!\nPlease proceed to enter your course details");

                string courseCode = UserDataCollector.GetValidCourseCode();
                int courseUnit = UserDataCollector.GetValidCourseUnit();
                int courseScore = UserDataCollector.GetValidCourseScore();

                // Display entered data
                Console.WriteLine($"Course code: {courseCode}");
                Console.WriteLine($"Course unit: {courseUnit}");
                Console.WriteLine($"Course score: {courseScore}");

                // Continue with GPA calculation or other operations
            }
        }*/
    }

}
