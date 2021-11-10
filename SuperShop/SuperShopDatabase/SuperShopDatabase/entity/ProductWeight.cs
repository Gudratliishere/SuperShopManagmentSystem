using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperShopDatabase.Entity
{
    public class ProductWeight
    {
        private int id;
        private string name;
        private double arrivalPrice;
        private double salePrice;
        private double weight;
        private ProductCompany company;
        private ProductKind kind;
        private DateTime lastComeDate;

        public int Id { get => id; set => id = value; }

        public string Name { get => name; set => name = value; }

        public double ArrivalPrice { get => arrivalPrice; set => arrivalPrice = value; }

        public double SalePrice { get => salePrice; set => salePrice = value; }

        public double Weight { get => weight; set => weight = value; }

        public ProductCompany Company { get => company; set => company = value; }

        public ProductKind Kind { get => kind; set => kind = value; }

        public DateTime LastComeDate { get => lastComeDate; set => lastComeDate = value; }

        public override string ToString ()
        {
            return String.Format("ProductWight({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})", id, name, arrivalPrice, salePrice,
                weight, company, kind, lastComeDate);
        }
    }
}
