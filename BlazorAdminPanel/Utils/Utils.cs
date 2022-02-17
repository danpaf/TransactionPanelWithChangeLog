using System;
using System.Net.Mail;

namespace BlazorAdminPanel.Utils;

public class Utils
{
    public static bool IsEmailValid(string emailAddress)
    {
        try
        { 
            new MailAddress(emailAddress);
            return true;
        }
        catch (FormatException)
        {
            return false;
        }
    }
}