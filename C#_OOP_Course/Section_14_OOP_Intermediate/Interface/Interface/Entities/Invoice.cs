using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Entities
{
    class Invoice
    {
        public double basicPayment { get; set; }
        public double tax { get; set; }
        public Invoice() { }

        public Invoice(double basicPayment, double tax)
        {
            this.basicPayment = basicPayment;
            this.tax = tax;
        }

        public double totalPayment()
        {
            return basicPayment + tax;
        }

        public override string ToString()
        {
            return "Basic payment: "
                + basicPayment.ToString("F2")
                + "\nTax: "
                + tax.ToString("F2")
                + "\nTotal payment: "
                + totalPayment().ToString("F2");
        }
    }
}
