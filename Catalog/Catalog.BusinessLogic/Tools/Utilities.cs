using System;
using System.Security.Cryptography;
using System.Text;

namespace Catalog.BusinessLogic.Tools
{
    public static class Utilities
    {
        public static string GetHash(string plainTextPassword) {
            using (SHA512 hash512 = SHA512.Create())
            {
                byte[] parolaBytes = Encoding.UTF8.GetBytes(plainTextPassword);
                byte[] hashBytes = hash512.ComputeHash(parolaBytes);
                return BitConverter.ToString(hashBytes);
            }
        }
    }
}
