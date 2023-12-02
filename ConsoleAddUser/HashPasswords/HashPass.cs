using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HashPasswords
{
    public class HashPass
    {
        public string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] sourceBytePassword = Encoding.UTF8.GetBytes(password);
                byte[] hashSourceBytePassw = sha256Hash.ComputeHash(sourceBytePassword);
                string hadhPassw = BitConverter.ToString(hashSourceBytePassw).Replace("-", String.Empty);
                return hadhPassw;
            }
        }
    }
}
