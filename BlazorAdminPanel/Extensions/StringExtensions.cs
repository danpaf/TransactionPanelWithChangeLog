using System;
using System.Security.Cryptography;
using System.Text;

namespace BlazorAdminPanel.Extensions;

public static class StringExtensions
{
    public static string GetSha512(this string value)
    {
        var bytes = Encoding.UTF8.GetBytes(value);
        using (var hash = SHA512.Create())
        {
            var hashedInputBytes = hash.ComputeHash(bytes);

            // Convert to text
            // StringBuilder Capacity is 128, because 512 bits / 8 bits in byte * 2 symbols for byte 
            var hashedInputStringBuilder = new StringBuilder(128);
            foreach (var b in hashedInputBytes)
                hashedInputStringBuilder.Append(b.ToString("X2"));
            return hashedInputStringBuilder.ToString();
        }
    }
}