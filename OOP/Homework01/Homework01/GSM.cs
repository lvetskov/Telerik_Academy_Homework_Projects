using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework01
{
    public class GSM
    {
        private static GSM iPhone4S = new GSM("Apple", "Iphone 4S", 1600, "No owner", new Battery("Rechargable", 480f, 15.5f), new Display(3.5, 16000000));

        private string manufacturer;
        private string model;
        private int? price;
        private string owner;

        public Battery battery;
        public Display display;
        public Call call = new Call(null, null);

        public GSM(string manufacturer, string model)
            : this(manufacturer, model, null, null, new Battery(), new Display())
        { }
        public GSM(string manufacturer, string model, int price)
            : this(manufacturer, model, price, null, new Battery(), new Display())
        { }
        public GSM(string manufacturer, string model, int price, string owner)
            : this(manufacturer, model, price, owner, new Battery(), new Display())
        { }
        public GSM(string manufacturer, string model, int price, string owner, Battery battery)
            : this(manufacturer, model, price, owner, battery, new Display())
        { }
        public GSM(string manufacturer, string model, int? price, string owner, Battery battery, Display display)
        {
            this.manufacturer = manufacturer;
            this.model = model;
            this.owner = owner;
            this.price = price;
            this.battery = new Battery("NA", 0f, 0f);
            this.display = new Display();
        }

        public string Manufacturer
        {
            get
            {
                return manufacturer;
            }
            set
            {
                manufacturer = value;
            }
        }
        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }
        public int? Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
        public string Owner
        {
            get
            {
                return owner;
            }
            set
            {
                owner = value;
            }
        }
        private List<Call> callHistory = new List<Call>();
        public List<Call> CallHistory
        {
            get
            {
                return callHistory;
            }   
            set
            {
                callHistory = value;
            }
        }
        public void AddCall(Call call)
        {
            this.callHistory.Add(call);
        }
        public void DeleteCall(int position)
        {
            this.callHistory.RemoveAt(position);
        }
        public void ClearCall()
        {
            this.callHistory.Clear();
        }
        public static GSM Iphone4S
        {
            get
            {
                return GSM.iPhone4S;  //Add a static property IPhone4S in the GSM class to hold the information about iPhone 4S
            }
        }
        public double GetTotalPriceOfCalls(double pricePerMinute, GSM obj)
        {
            double sum = 0;
            for (int i = 0; i < obj.callHistory.Count; i++)
            {
                sum += (double)obj.CallHistory[i].DurationInSeconds * pricePerMinute;
            }
            return sum;
        }


        //      public void PrintSpecs()
        //      { 
        //          Console.WriteLine("Manufacturer is {0}", this.Manufacturer);
        //          Console.WriteLine("Model {0}", this.Model);
        //          Console.WriteLine("The owner is {0}", this.Owner);
        //          Console.WriteLine("The price is {0}", this.Price);
        //          Console.WriteLine("Model of battery: {0}", this.battery.Model);                   overlaps the override to string
        //          Console.WriteLine("Type of battery: {0}", this.battery.Type);
        //          Console.WriteLine("Talking hours: {0}", this.battery.HoursTalk);
        //          Console.WriteLine("Idle hours: {0}", this.battery.HoursIdle);
        //          Console.WriteLine("Display size in inches: {0}", this.display.Size);
        //          Console.WriteLine("Display colours: {0}", this.display.ColoursCount);
        //      }
        public override string ToString()
        {
            return string.Format("GSM model: {0}\nManufacturer: {1}\nOwner: {2}\nPrice: {3}\nIdle Hours: {4}\nHours Talk: {5}\nDisplay Colours: {6}\n", this.Model, this.Manufacturer, this.Owner, this.Price, this.battery.HoursIdle, this.battery.HoursTalk, this.display.ColoursCount);
        }
    }
}