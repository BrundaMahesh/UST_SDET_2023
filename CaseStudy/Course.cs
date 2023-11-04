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


        public void CourseRegistration()
        {
            throw new NotImplementedException();
        }

        public void CourseWithdrawal()
        {
            throw new NotImplementedException();
        }
    }
}
