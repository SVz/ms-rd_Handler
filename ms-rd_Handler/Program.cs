using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ms_rd_Handler
{
    class Program
    {
        static void Main(string[] args)
        {
            //ms-rd:subscribe?url=100.108.20.39
            //check if args is not empty
            if (args.Length > 0)
            {
                //check if args contains ms-rd:subscribe
                if (args[0].Contains("ms-rd:subscribe"))
                {
                    //get the url
                    string url = args[0].Split('=')[1];
                    //open the url in the browser
                    //launch rdp client with the url
                    System.Diagnostics.Process.Start("C:\\Windows\\System32\\mstsc.exe", "/v:" + url);
                }
                else
                {
                    //if args does not contain ms-rd:subscribe, show a message
                    Console.WriteLine("Invalid arguments passed, must be like 'ms-rd:subscribe?url=100.108.20.39'");
                }
            }
            else
            {
                //if args is empty, show a message
                Console.WriteLine("No arguments passed");
            }
        }
    }
//    Windows Registry Editor Version 5.00

//[HKEY_CLASSES_ROOT\ms-rd]
//@="URL:Remote Desktop Protocol"
//"URL Protocol"=""

//[HKEY_CLASSES_ROOT\ms-rd\shell]

//    [HKEY_CLASSES_ROOT\ms-rd\shell\open]

//    [HKEY_CLASSES_ROOT\ms-rd\shell\open\command]
//@="\"C:\\Users\\SVz\\source\\repos\\ms-rd_Handler\\ms-rd_Handler\\bin\\Release\\ms-rd_Handler.exe\" \"%1\""
}


//Windows Registry Editor Version 5.00

//[HKEY_CLASSES_ROOT\ms-rd]
//@= "URL:Remote Desktop Protocol"
//"URL Protocol" = ""

//[HKEY_CLASSES_ROOT\ms - rd\shell]

//[HKEY_CLASSES_ROOT\ms - rd\shell\open]

//[HKEY_CLASSES_ROOT\ms - rd\shell\open\command]
//@= "\"C:\\Users\\SVz\\source\\repos\\ms-rd_Handler\\ms-rd_Handler\\bin\\Release\\ms-rd_Handler.exe\" \"%1\""


