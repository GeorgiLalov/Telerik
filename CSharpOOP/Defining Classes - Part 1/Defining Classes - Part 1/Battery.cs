namespace Defining_Classes___Part_1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Battery
    {
        private string model;
        private BatteryType batteryType;
        private float? hoursIdle;
        private float? hoursTalk;

        public string Model
        {
            get { return model; }
            set { this.model = value; }
        }
        public BatteryType BatteryType
        {
            get { return batteryType; }
            set { this.batteryType = value; }
        }
        public float? HoursIdle
        {
            get
            {
                return hoursIdle;
            }
            set
            {
                if (value < 0)
                {
                    throw new FormatException();
                }

                this.hoursIdle = value;
            }
        }
        public float? HoursTalk
        {
            get{ return hoursTalk; }
            set
            {
                if (value < 0)
                {
                    throw new FormatException();
                }

                this.hoursTalk = value;
            }
        }

        public Battery(string model)
        {
            this.Model = model;
            this.HoursIdle = null;
            this.HoursTalk = null;
        }

        public Battery(string model, float hoursIdle, float hoursTalk) : this(model)
        {
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
        }

        public Battery(string model, float hoursIdle, float hoursTalk, BatteryType batteryType) : this(model)
        {
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
            this.BatteryType = batteryType;
        }

        override
        public string ToString()
        {
            return $"{this.Model} {this.BatteryType} {this.HoursIdle} {this.HoursTalk}";
        }

    }
}
