using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperShopDatabase.Entity
{
    public class ProductScales
    {
        private int id;
        private double weight;
        private ProductWeight productWeight;
        private DateTime measureDate;

        public int Id { get => id; set => id = value; }

        public double Weight { get => weight; set => weight = value; }

        public ProductWeight ProductWeight { get => productWeight; set => productWeight = value; }

        public DateTime MeasureDate { get => measureDate; set => measureDate = value; }

        public override string ToString ()
        {
            return String.Format("ProductScales({0}, {1}, {2}, {3})", id, weight, productWeight, measureDate);
        }
    }
}
