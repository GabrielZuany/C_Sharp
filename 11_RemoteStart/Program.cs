using System;
using System.Diagnostics;

namespace RemoteStart
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Process.Start("python", @"C:\Users\gabri\Desktop\WindowsWorkEnvironment\Python\Automation\01_PlaySpotify_Pyautogui\main.py");

            //Process.Start("language", @"FILEPATH\file.ext");
        }   
    }
}