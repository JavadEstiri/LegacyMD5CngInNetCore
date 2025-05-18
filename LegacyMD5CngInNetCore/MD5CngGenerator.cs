using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
namespace LegacyMD5CngInNetCore
{
    public class MD5CngGenerator
    {
        /// <summary>
        ///     The MD5Cng class (part of the .NET Framework's System.Security.Cryptography namespace) 
        ///     was a CNG (Cryptography Next Generation)-based implementation of the MD5 hashing algorithm. 
        ///     However, it has been deprecated and discouraged in favor of more secure alternatives.
        ///     The MD5Cng class remains in older .NET Framework versions .
        ///     This method Gives You Same Output as MD5Cng Using "System.Security.Cryptography.CngAlgorithm.MD5" Which
        ///     Is Available in .NET Core and .NET 5+ .
        /// </summary>
        /// <param name="input"></param>
        /// <returns>Hashed String Same As Legacy 'MD5Cng'</returns>
        public string HashWithCngAlgorithm(string input)
        {
            var hashObject = HashAlgorithm.Create(CngAlgorithm.MD5.ToString());

            byte[] inputBytes = Encoding.Unicode.GetBytes(input);

            byte[] hashBytes = hashObject.ComputeHash(inputBytes);

            string hash = Encoding.Default.GetString(hashBytes);

            return hash;
        }
    }
}
