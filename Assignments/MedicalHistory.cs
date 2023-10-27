using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class MedicalHistory
    {
        public int RecordId {  get; set; }
        public int PatientId {  get; set; }
        public string Description {  get; set; }
        public string Date { get; set; }

        public static List<MedicalHistory> medicalHistories = new List<MedicalHistory>();   

        public void AddMedicalHistory(int RecordId,int PatientId,string Description,string Date)
        {
            medicalHistories.Add(new MedicalHistory { RecordId = RecordId, PatientId = PatientId, Description = Description, Date = Date });
        }

        public void AddRecordToFile(int RecordId, int PatientId, string Description, string Date)
        {
            FileStream fileStream = new FileStream("C:\\Users\\Administrator\\Desktop\\Files\\MedicalHistory.txt", FileMode.Create, FileAccess.Write);
            StreamWriter streamWriter = new StreamWriter(fileStream);
            streamWriter.WriteLine("Record Id:" + RecordId);
            streamWriter.WriteLine("Patient Id:" + PatientId);
            streamWriter.WriteLine("Description:" + Description);
            streamWriter.WriteLine("Date:" + Date);
            streamWriter.Close();
            fileStream.Close();

        }
        public void ViewRecordFromFile()
        {
            FileStream fileStream1 = new FileStream("C:\\Users\\Administrator\\Desktop\\Files\\MedicalHistory.txt", FileMode.Open, FileAccess.Read);
            StreamReader streamReader = new StreamReader(fileStream1);
            string str = streamReader.ReadToEnd();
            Console.WriteLine(str);
            streamReader.Close();
            fileStream1.Close();
        }
    }
}
