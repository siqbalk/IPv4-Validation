using System;

class Program
{
    static void Main(string[] args)
    {
        string ip = "192.168.0.1";
        bool isValid = ValidateIP(ip);
        Console.WriteLine($"Is {ip} a valid IPv4 address? {isValid}");
    }

    static bool ValidateIP(string ip)
    {
        string[] octets = ip.Split('.');
        if (octets.Length != 4)
        {
            return false; 
        }
        foreach (string octet in octets)
        {
            if (!byte.TryParse(octet, out byte b))
            {
                return false; // not a number between 0 and 255
            }
            if (octet.Length > 1 && octet[0] == '0')
            {
                return false; // leading zeros not allowed
            }
        }
        return true; 
    }
}