using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperShopDatabase.Entity
{
    public class ProductCompany
    {
        private int id;
        private string name;
        private string email;
        private string phone;
        private DateTime beginDate;
        private DateTime endDate;
        private DateTime lastComeDate;

        public int Id { get => id; set => id = value; }

        public string Name { get => name; set => name = value; }

        public string Email { get => email; set => email = value; }

        public string Phone { get => phone; set => phone = value; }

        public DateTime BeginDate { get => beginDate; set => beginDate = value; }

        public DateTime EndDate { get => endDate; set => endDate = value; }

        public DateTime LastComeDate { get => lastComeDate; set => lastComeDate = value; }

        public override string ToString ()
        {
            return String.Format("ProductCompany({0}, {1}, {2}, {3}, {4}, {5}, {6})", id, name, email,
                phone, beginDate, endDate, lastComeDate);
        }
    }
}
