using System;
using System.Collections.Generic;
using System.Text;

namespace ATS
{
    public class Call
    {
        public long Id { get; set; }
        public int DurationOfCall;
        public Client Caller { get; set; }
        public Client Answerer { get; set; }
        public DateTime TimeOfStartCall { get; set; }
        public DateTime TimeOfFinishCall { get; set; }
        public bool IsStartTalk { get; set; }
                
        public int CalculateDurationOfCall(DateTime startTime, DateTime finishTime)
        {
            int start = startTime.Second;
            int finish = finishTime.Second;
            return DurationOfCall = finish - start;
        }

        public void StartCall()
        {
            TimeOfStartCall = DateTime.Now;
        }

        public void EndCall(Random rng)
        {
            TimeOfFinishCall = DateTime.Now.AddMinutes(rng.Next(1, 60));
        }

    }
}
