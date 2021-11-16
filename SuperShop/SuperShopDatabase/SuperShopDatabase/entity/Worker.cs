using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperShopDatabase.Entity
{
    public class Worker
    {
        private int id;
        private string name;
        private string surname;
        private string fatherName;
        private string gender;
        private DateTime birthday;
        private string address;
        private string phone;
        private string email;
        private string imagePath;
        private WorkSector sector;
        private int wage;
        private string startTime;
        private string endTime;

        public int Id { get => id; set => id = value; }

        public string Name { get => name; set => name = value; }

        public string Surname { get => surname; set => surname = value; }

        public string FatherName { get => fatherName; set => fatherName = value; }

        public string Gender { get => gender; set => gender = value; }

        public DateTime Birthday { get => birthday; set => birthday = value; }

        public string Address { get => address; set => address = value; }

        public string Phone { get => phone; set => phone = value; }

        public string Email { get => email; set => email = value; }

        public string ImagePath { get => imagePath; set => imagePath = value; }

        public int Wage { get => wage; set => wage = value; }

        public string StartTime { get => startTime; set => startTime = value; }

        public string EndTime { get => endTime; set => endTime = value; }

        public WorkSector Sector { get => sector; set => sector = value; }

        public override string ToString ()
        {
            return String.Format("Worker({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11}, {12}, {13})", id, 
                name, surname, fatherName, gender, birthday.ToString("yyyy-MM-dd"), address, phone, email, imagePath, 
                sector, wage, startTime, endTime);
        }
    }
}
