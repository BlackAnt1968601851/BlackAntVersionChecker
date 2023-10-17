using System;
using System.Numerics;

public static class WinVer
{
    public static string Version = "1.2.5";
    public static string about = "You are running BlackAnt's Version Tool Version: " + Version;
    public static int Progress = 100;
    public static bool dll = true;
    public static string Main()
    {
    var hi2 = Environment.OSVersion.Version;
        var hi = hi2.ToString();
        if (hi.Contains("10.0"))
        {
            return "You are using Windows 10 or later.";
        }
        else if (hi.Contains("6.1"))
        {
            return "You are using Windows 7.";
        }
        else if (hi.Contains("6.2"))
        {
            return "You are using Windows 8.";
        }
        else if (hi.Contains("6.3"))
        {
            return "You are using Windows 8.1.";
        }
        else
        {
            return "Other/Unknwon";
        }
    }
}
