using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class CallRecord
    {
        public int CallId {  get; set; }
        public long PhoneNumber {  get; set; }
        public long CallTime {  get; set; }

        public static List<CallRecord> CallRecords = new List<CallRecord>()
        { 
            new CallRecord { CallId = 145, PhoneNumber = 9846745678, CallTime = 2 },
            new CallRecord { CallId = 746, PhoneNumber = 9647476453, CallTime = 4 },
            new CallRecord { CallId = 567, PhoneNumber = 9745698563, CallTime = 7 },
        };
        public void CallHistory(long phoneNumber)
        {
            var found=CallRecords.FindAll(x => x.PhoneNumber == phoneNumber);
            if (found.Count>0) 
            {
                foreach(var record in found)
                {
                    Console.WriteLine("Call Id:" + record.CallId);
                    Console.WriteLine("Call Time:" + record.CallTime);
                }   
            }
            else
            {
                Console.WriteLine("Call history not found");
            }
        }

        //public void TotalNoOfCalls()
        //{
        //    foreach (var record in CallRecords)
        //    {
                
                
        //    }
        //}

    }
}
