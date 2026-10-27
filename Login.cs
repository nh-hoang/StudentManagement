using System;

public class Login
{
    public static bool CheckLogin(string username, string password)
    {
        return username == "admin" && password == "123456";
    }
}