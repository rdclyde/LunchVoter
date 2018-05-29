using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LunchVoter
{
    public class Common
    {

        public static void LogSave(String routine, String message)
        {
            String dir = HttpRuntime.AppDomainAppPath;
            System.IO.StreamWriter file = new System.IO.StreamWriter(dir + "/files/logs.txt",true);
            file.WriteLine(DateTime.Now.ToString("yyyyMMdd.HHmmss") + ", " + routine + ", " + message);
            file.Close();
        }
    }
}