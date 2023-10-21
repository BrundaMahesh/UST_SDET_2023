using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class Doctor : IDoctor
    {
        public int DoctorId { get; set; }   
        public string? DoctorName { get; set; }
        public void AddNewDoctor()
        {
            DoctorId = 1000;
            DoctorName = "Ravi";
        }
        public void ModifyDoctor()
        {
            DoctorId = 2000;
            DoctorName = "Amogh";
        }
        public void DisplayDoctorDetails()
        {
            Console.WriteLine($"Doctor Id:"+DoctorId +"\n" +"Doctor Name:"+DoctorName +"\n");
        }
    }
}
