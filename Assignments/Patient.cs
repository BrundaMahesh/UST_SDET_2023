using Assignments.ExceptionMessages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Assignments.ExceptionMessages.MyException;

namespace Assignments
{
    internal class Patient
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Age {  get; set; }
        public string? Diagnosis {  get; set; }

        public static List<Patient> patients = new List<Patient>();
       
        public void AddPatient(int Id,string? Name,int Age,string Diagnosis)
        {
            if(Age<0 || Age>=120)
            {
                throw new CustomException(ErrorMessages["Error1"]);
            }
            if(string.IsNullOrEmpty(Name))
            {
                throw new CustomException(ErrorMessages["Error2"]);
            }
            if(string.IsNullOrEmpty(Diagnosis))
            {
                throw new CustomException(ErrorMessages["Error3"]);
            }
        }

        
        public static void Display()
        {
            Console.WriteLine("Patient details");
            foreach (var item in patients)
            {
                Console.WriteLine("Id:"+item.Id +"\n" +"Name:"+item.Name+"\n" +"Age:"+item.Age+"\n"+"Diagnosis:"+item.Diagnosis);
            }
        }
    }
    
}
