using CaseStudy.CustomException;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
    internal class Course:IEnrollable
    {
        public int CourseCode {  get; set; }    
        public string? Title { get; set; }
        public string? Instructor { get; set; }
        public int MaxCount {  get; set; }

        public static List<Course> courses = new List<Course>();    

        public List<Student> EnrolledStudent=new List<Student>();


        public void CourseRegistration(Course course, Student student)
        {
            foreach (var item in Course.courses)
            {
                Console.WriteLine("Course code:" + item.CourseCode + "\t" + "Title" + item.Title + "\t" + "Instructor:" + item.Instructor);
            }
            Console.Write("enter the course code do you want to enroll:");
            int code = Convert.ToInt32(Console.ReadLine());
            if (EnrolledStudent.Count >= MaxCount)
            {
                throw new EnrollmentException(StudentException.ErrorMessages["1"]);

            }
            else if (EnrolledStudent.Contains(student))
            {
                Console.WriteLine($"Student {student.StudentId} already enrolled in course {code}");
                throw new EnrollmentException(StudentException.ErrorMessages["2"]);
            }
            else
            {
                EnrolledStudent.Add(student);
                Console.WriteLine($"Student successfully registered for course {code} ");
            }
        }

        public void CourseWithdrawal(Course course)
        {
            throw new NotImplementedException();
        }

        
    }

   
}
