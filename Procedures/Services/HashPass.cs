using System.Security.Cryptography;
using System.Text;

namespace Procedures.Services;

public class HashPass
{
    
    public static string HashPassword(string password)
    {
        using (SHA256 sha256 = SHA256.Create())
        {
            byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var t in hashedBytes)
            {
                stringBuilder.Append(t.ToString("x2"));
            }
            return stringBuilder.ToString();
        }
    }

    public static bool VerifyPass(string enteredPassword, string hashedPassword)
    {
        return HashPassword(enteredPassword) == hashedPassword;
    }
}