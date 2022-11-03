using System;
using System.Collections.Generic;
using System.Text;
using Interfaces.Entities;

namespace Interfaces.Services
{
    class RentalServices
    {
        public double PricePorHour { get; private set; }
        public double PricePerDay { get; set; }

        private BrazilTaxServices _brazilTaxServices = new BrazilTaxServices();
        public RentalServices(double pricePorHour, double pricePerDay)
        {
            PricePorHour = pricePorHour;
            PricePerDay = pricePerDay;
        }

        public void ProcessInvoice(CarRental carRental)
        {
            TimeSpan durantion = carRental.Finish.Subtract(carRental.Start);

            double basicPayment = 0.0;

            if(durantion.TotalHours <= 12.0)
            {
                basicPayment = PricePorHour * Math.Ceiling(durantion.TotalHours);
            }
            else
            {
                basicPayment = PricePerDay * Math.Ceiling(durantion.TotalDays);
            }

            double tax = _brazilTaxServices.Tax(basicPayment);

            carRental.Invoice = new Invoice(basicPayment, tax);

        }
    }
}
