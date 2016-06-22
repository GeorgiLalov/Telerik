namespace StudentsWorkers
{
    using System;

    public class Worker : Human
    {
        private double weekSalary;
        private double workHoursPerDay;

        public Worker(string firstName, string lastName, double weekSalary, double workHoursPerDay)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public double WeekSalary
        {
            get
            {
                return this.weekSalary;
            }
            private set
            {
                if (value < 0 && value > double.MaxValue)
                {
                    throw new ArgumentException("Salary argument exception!");
                }
                this.weekSalary = value;
            }
        }

        public double WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }
            private set
            {
                if (value < 0 && value > double.MaxValue)
                {
                    throw new ArgumentException("Work hours argument exception!");
                }
                this.workHoursPerDay = value;
            }
        }

        // returns money earned per hour by the worker
        public double MoneyPerHour()
        {
            double workDaysPerWeek = 5;
            double moneyPerDay = this.weekSalary / workDaysPerWeek;
            double moneyPerHour = moneyPerDay / this.workHoursPerDay;

            return moneyPerHour; 
        }

        public override string ToString()
        {
            return $"{this.FirstName}\t{this.LastName}\t{this.MoneyPerHour()}";
        }
    }
}
