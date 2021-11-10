using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperShopDatabase.Entity
{
    public class Barcode
    {
        private int id;
        private ProductNumber productNumber;
        private ProductScales productScales;

        public int Id { get => id; set => id = value; }

        public ProductNumber ProductNumber { get => productNumber; set => productNumber = value; }

        public ProductScales ProductScales { get => productScales; set => productScales = value; }

        public override string ToString ()
        {
            return String.Format("Barcode({0}, {1}, {2})", id, productNumber, productScales); ;
        }
    }
}
