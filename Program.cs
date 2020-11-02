using System;

using System.IO;

using System.Collections.Generic;

namespace msteams_autolaunch_tool
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string default_csv_path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            default_csv_path += "teams.csv";

            if (args.Length > 0) {
                default_csv_path = args[0];
            }

            if (!File.Exists(default_csv_path)) {
                Console.WriteLine(default_csv_path+" does not exist!");
                return;
            }

            // Keys are epoch time seconds, values are MS teams URLs
            Dictionary<long, string> meeting_data = new Dictionary<long, string>();

            // TODO read .csv file (http://www.dotnet-tutorials.net/Article/read-a-csv-file-in-csharp)

            // TODO sort by time

            // TODO sleep until the next meeting

            // After sleeping, use the generic process start API to open the URL:
            // https://docs.microsoft.com/en-us/troubleshoot/dotnet/csharp/start-internet-browser


        }
    }
}
