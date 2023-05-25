using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_ex.Entities
{
    class HourContract
    {
        public DateTime date { get; private set; }
        public double valuePerHour { get; private set; }
        public int hours { get; private set; }

        public HourContract(DateTime date, double valuePerHour, int hours)
        {
            this.date = date;
            this.valuePerHour = valuePerHour;
            this.hours = hours;
        }

        public double TotalValue()
        {
            return valuePerHour * hours;
        }

        
        public override string ToString()
        {
            return   $"Contract date: {date}\n" + 
                     $"Value per hour: {valuePerHour}\n" + 
                     $"Hours: {hours}\n" + 
                     $"Total value: {TotalValue()}";
        }
    }
}
