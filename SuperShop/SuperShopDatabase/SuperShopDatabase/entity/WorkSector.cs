
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperShopDatabase.Entity
{
    public class WorkSector
    {
        private int id;
        private string name;

        public int Id { get => id; set => id = value; }

        public string Name { get => name; set => name = value; }

        public override string ToString ()
        {
            return String.Format("WorkSector({0}, {1})", id, name);
        }
    }
}
