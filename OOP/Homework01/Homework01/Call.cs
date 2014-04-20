using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//date, time, dialed phone number and duration (in seconds).
namespace Homework01
{
    public class Call
    {
        private DateTime date = DateTime.Today;
        private string dialedNumber;
        private int? durationInSeconds;

        public Call()
        { 
        }
        public Call(string dialedNumber, int? durationInSeconds)
        {
            this.dialedNumber = dialedNumber;
            this.durationInSeconds = durationInSeconds;
        }
        public string DialedNumber
        {
            get { return dialedNumber; }
            set { dialedNumber = value; }
        }
        public int? DurationInSeconds
        {
            get { return durationInSeconds; }
            set { durationInSeconds = value; }
        }    
    }
}
