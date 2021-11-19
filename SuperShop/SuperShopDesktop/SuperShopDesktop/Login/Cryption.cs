using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperShopDesktop.Login
{
    public class Cryption
    {
        public static string Encrypt (string data)
        {
            byte[] dataByte = Encoding.ASCII.GetBytes(data);
            dataByte = new System.Security.Cryptography.SHA256Managed().ComputeHash(dataByte);
            String hash = Encoding.ASCII.GetString(dataByte);

            return hash;
        }
    }
}
