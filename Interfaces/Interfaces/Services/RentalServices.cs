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

        private ITaxServices _taxServices;
        public RentalServices(double pricePorHour, double pricePerDay, ITaxServices taxServices)
        {
            PricePorHour = pricePorHour;
            PricePerDay = pricePerDay;
            _taxServices = taxServices;
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

            double tax = _taxServices.Tax(basicPayment);

            carRental.Invoice = new Invoice(basicPayment, tax);

        }
    }
}
