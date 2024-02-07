namespace GPACalculator
{
    public class GPACalculations
    {
        public int gradeUnit = 0;
        public int weightPoint = 0;
        public List<Course> GetCourseData()
        {
            
          //  int totalGradeUnit = 0;
          //  int totalWeightPoint = 0;
            //double GPA = 0;


            Console.WriteLine(" Welcome to Flo's GPA Calculator App!!! \n Please proceed to enter your course details ");
            Console.WriteLine("Enter the number of courses you intend to calculate ");
            int numberOfCourses = int.Parse(Console.ReadLine());

            List<Course> courses = new List<Course>();


            for (int i = 1; i <= numberOfCourses; i++)
            {
                string courseCode = UserData.GetValidCourseCode();
                int courseUnit = UserData.GetValidCourseUnit();
                int courseScore = UserData.GetValidCourseScore();
                char grade;

                string remark;
                int totalCourseUnit = 0;
                int totalCourseUnitPassed = 0;

                if (courseScore >= 70 && courseScore <= 100)
                {
                    grade = 'A';
                    gradeUnit = 5;
                    remark = "Excellent";
                }
                else if (courseScore >= 60 && courseScore <= 69)
                {
                    grade = 'B';
                    gradeUnit = 4;
                    remark = "Very Good";
                }
                else if (courseScore >= 50 && courseScore <= 59)
                {
                    grade = 'C';
                    gradeUnit = 3;
                    remark = "Good";
                }
                else if (courseScore >= 45 && courseScore <= 49)
                {
                    grade = 'D';
                    gradeUnit = 2;
                    remark = "Fair";
                }
                else if (courseScore >= 40 && courseScore <= 44)
                {
                    grade = 'E';
                    gradeUnit = 1;
                    remark = "Pass";
                }
                else
                {
                    grade = 'F';
                    gradeUnit = 0;
                    remark = "Fail";
                }

                totalCourseUnit += courseUnit;

                if (grade != 'F')
                {
                    totalCourseUnitPassed += courseUnit;
                }

                weightPoint = courseUnit * gradeUnit;
            
                

                /* Console.WriteLine(totalCourseUnit);
                 Console.WriteLine(totalCourseUnitPassed);
                 Console.WriteLine(weightPoint);
                 Console.WriteLine(totalWeightPoint);*/
                /*Console.WriteLine(totalGradePoint);
                Console.WriteLine(GPA);*/

                //Console.WriteLine($"Course code: {courseCode}");

                Course course = new Course
                {
                    Code = courseCode,
                    Unit = courseUnit,
                    Grade = grade,
                    GradeUnit = gradeUnit,
                    WeightPoint = weightPoint,
                    Remark = remark
                };

                courses.Add(course);
              
            }

            return courses;
            
        }
        public static double CalculateGPA(List<Course> courses) 
        {
            double gpa;
            int totalCourseUnit = 0;
            int totalWeightPoint = 0;

            foreach (var course in courses)
            {
                totalCourseUnit += course.Unit;
                totalWeightPoint += course.WeightPoint;
            }

            //To avoid zero division errors
            if (totalCourseUnit != 0)
            {
               gpa = (double)totalWeightPoint / totalCourseUnit;
                return gpa;
            }
            else
            {
                return 0.0;
            }
           
        }
        
    }
   
}
