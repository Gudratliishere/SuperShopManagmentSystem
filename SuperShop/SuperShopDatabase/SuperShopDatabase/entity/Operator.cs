using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperShopDatabase.entity
{
    class Operator
    {
        private int id;
        private string name;
        private string surname;
        private string email;
        private string password;
        private string phone;
        private bool status;

        public int Id { get => id; set => id = value; }

        public string Name { get => name; set => name = value; }

        public string Surname { get => surname; set => surname = value; }

        public string Email { get => email; set => email = value; }

        public string Password { get => password; set => password = value; }

        public string Phone { get => phone; set => phone = value; }

        public bool Status { get => status; set => status = value; }
    }
}
