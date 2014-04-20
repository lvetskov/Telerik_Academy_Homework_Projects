using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework01
{
    public enum BatteryType 
    {
        LiIon, NiMH, NiCd
    }
    public class Battery
    {
        private string batteryModel;
        private float? hoursIdle;
        private float? hoursTalk;
        private BatteryType type;

        public Battery()
        {
        }
        public Battery(string model = null, float? hoursIdle = 0, float? hoursTalk = 0)
        {
            this.batteryModel = model;
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
            
        }
        public Battery(BatteryType type)
        { 
            this.type = type;
        }

        public string Model
        {
            get { return batteryModel; }
            set { batteryModel = value; }
        }
        public float? HoursIdle
        {
            get { return hoursIdle; }
            set { hoursIdle = value; }
        }
        public float? HoursTalk
        {
            get { return hoursTalk; }
            set { hoursTalk = value; }
        }
        public BatteryType Type
        {
            get { return type; }
            set { type = value; }
        }
    }
}
