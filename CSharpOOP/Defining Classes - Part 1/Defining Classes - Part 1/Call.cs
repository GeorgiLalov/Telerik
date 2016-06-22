namespace Defining_Classes___Part_1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Call
    {
        private DateTime dateTime;
        private string dialledPhoneNumber;
        private int duration;

        public DateTime DateTime
        {
            get { return dateTime; }
            set { dateTime = value; }
        }
        public string DialledPhoneNumber
        {
            get { return dialledPhoneNumber; }
            set { dialledPhoneNumber = value; }
        }
        public int Duration
        {
            get { return duration; }
            set
            {
                if (value < 0)
                {
                    throw new FormatException();
                }
                duration = value;
            }
        }

        public Call(DateTime dateTime, string dilledPhonenumber, int duration)
        {
            this.dateTime = dateTime;
            this.dialledPhoneNumber = dilledPhonenumber;
            this.duration = duration;
        }

        override
        public string ToString()
        {
            return $"Date : {dateTime.Date}\tdialled phone : {dialledPhoneNumber}\tduration : {duration}";
        }

    }
}
