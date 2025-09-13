using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1.Services
{
    public class Logger
    {
        //name of the logfile
        private static string logfile = "debug_log.txt";


        //METHOD FOR SIMPLE LOG WRITTING WITH NAME OF ERROR + NAME OF METHOD  (2 Param one for the logmessage, one special attribute for methodname) 
        public static void WriteLog(string logmessage, [CallerMemberName] string callername = "")
        {
            //if the file exist 
            if (File.Exists(Path.Combine(AppContext.BaseDirectory,logfile )) == true) 
            { 
                //Concatenation of the logline (horodatage)
                string line = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - {callername} - {logmessage}";
                //writting of the file
                File.AppendAllText(logfile, line + Environment.NewLine);


            }

            else 
            { 
                //create file called debug_log.txt
                File.Create(Path.Combine(AppContext.BaseDirectory, logfile));
                //Concatenation of the logline (horodatage)
                string line = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - {logmessage}";
                //writting of the file
                File.AppendAllText(logfile, line + Environment.NewLine);

            }


        }
                




     }

}

