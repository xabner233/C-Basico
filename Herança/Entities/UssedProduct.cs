using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Herança.Entities
{
    class UssedProduct : Product
    {

        public DateTime ManufactureDate { get; set; }

        public UssedProduct()
        {

        }

        public UssedProduct(string name, double price, DateTime manufactureDate) : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            return Name
                + " (used) $ "
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + " (Manufacture date: "
                + ManufactureDate.ToString("dd/MM/yyyy")
                + ")";
        }
    }

}
