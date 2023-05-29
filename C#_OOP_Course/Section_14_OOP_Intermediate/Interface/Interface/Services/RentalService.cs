using System;
using Interface.Entities;

namespace Interface.Services
{
    class RentalService
    {
        public double pricePerHour { get; private set; }
        public double pricePerDay { get; private set; }

        private ITaxService _taxService;

        public RentalService() { }

        public RentalService(double pricePerHour, double pricePerDay, ITaxService taxService)
        {
            this.pricePerHour = pricePerHour;
            this.pricePerDay = pricePerDay;
            _taxService = taxService;
        }

        public void processInvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.finish.Subtract(carRental.start);

            double basicPayment = 0.0;

            if(duration.TotalHours <= 12)
            {
                basicPayment = Math.Ceiling(duration.TotalHours) * pricePerHour;
            }
            else
            {
                basicPayment = Math.Ceiling(duration.TotalDays) * pricePerDay;
            }

            double tax = _taxService.tax(basicPayment);

            carRental.invoice = new Invoice(basicPayment, tax);

        }
    }
}
