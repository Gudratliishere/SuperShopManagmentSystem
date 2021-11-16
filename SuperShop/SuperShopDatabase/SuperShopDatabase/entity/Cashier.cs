using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperShopDatabase.Entity
{
    public class Cashier
    {
        private int id;
        private string name;
        private Worker worker;
        private double sales;
        private DateTime lastResetTime;

        public int Id { get => id; set => id = value; }

        public string Name { get => name; set => name = value; }

        public Worker Worker { get => worker; set => worker = value; }

        public double Sales { get => sales; set => sales = value; }

        public DateTime LastResetTime { get => lastResetTime; set => lastResetTime = value; }

        public override string ToString ()
        {
            return String.Format("Cashier({0}, {1}, {2}, {3}, {4}", id, name, worker, sales, lastResetTime);
        }
    }
}
