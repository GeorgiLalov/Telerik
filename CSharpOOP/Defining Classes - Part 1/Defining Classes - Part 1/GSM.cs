namespace Defining_Classes___Part_1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class GSM
    {
        public static GSM IPhone4S = new GSM("IPhone4S", "Apple");

        private string model;
        private string manufacturer;
        private double? price;
        private string owner;
        private Battery battery;
        private Display display;
        private List<Call> callHistory;

        public Display Display
        {
            get { return display; }
            set { display = value; }
        }
        public Battery Battery
        {
            get { return battery; }
            set { battery = value; }
        }
        public string Owner
        {
            get { return owner; }
            set { owner = value; }
        }
        public double? Price
        {
            get { return price; }
            set
            {
                if (value < 0)
                {
                    throw new FormatException();
                }
                price = value;
            }
        }
        public string Manufacturer
        {
            get { return manufacturer; }
            set { manufacturer = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }       
        public List<Call> Callhistory
        {
            get { return callHistory; }
            set { callHistory = value; }
        }
        
        public GSM(string model, string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = null;
            this.Owner = null;
            this.Battery = null;
            this.Display = null;
            callHistory = new List<Call>();
        }

        public GSM(string model, string manufacturer, double price, string owner, Battery battery, Display display)
                                                                                            : this(model, manufacturer)
        {
            this.Price = price;
            this.Owner = owner;
            this.Battery = battery;
            this.Display = display;
        }

        override
        public string ToString()
        {
            return $"{this.Model} {this.Manufacturer} {this.Price} {this.Owner} {this.Battery} {this.Display}";
        }

        public void AddCall(Call call)
        {
            callHistory.Add(call);
        }

        public void DeleteCall(Call call)
        {
            if (callHistory.Remove(call))
            {
                Console.WriteLine("Call removed from history.");
            }
            else
            {
                Console.WriteLine("Error removing call from history!");
            }
        }

        public void ClearCallHistory()
        {
            callHistory.Clear();
            Console.WriteLine("Call History cleared.");
        }

        public double GetTotalPriceOfAllCalls(double pricePerMinute)
        {
            double totalPrice = 0;
            const double secondsPerMinute = 60;
            double pricePerSecond = pricePerMinute / secondsPerMinute;

            foreach (Call call in callHistory)
            {
                totalPrice += (  call.Duration  * pricePerSecond );
            }

            return totalPrice;
        }

        public void DisplayAllCalls()
        {
            if (callHistory.Count == 0)
            {
                Console.WriteLine("Call History is empty.");
            }
            else
            {
                foreach (Call call in callHistory)
                {
                    Console.WriteLine(call.ToString());
                }
            }
        }

    }
}
