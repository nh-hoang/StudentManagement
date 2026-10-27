using System;

public class Login
{
    public static bool CheckLogin(string username, string password)
    {
        return username == "admin" && password == "123456";
    }
    public static void ShowResult(bool success)
    {
        if (success)
            Console.WriteLine("Dang nhap thanh cong!");
        else
            Console.WriteLine("Sai tai khoan hoac mat khau!");
    }
}