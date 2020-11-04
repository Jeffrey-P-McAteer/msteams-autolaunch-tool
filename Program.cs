using System;
using System.IO;
using System.Collections.Generic;

namespace msteams_autolaunch_tool
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string csv_path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            csv_path += "teams.csv";

            if (args.Length > 0) {
                csv_path = args[0];
            }

            if (!File.Exists(csv_path)) {
                Console.WriteLine(csv_path+" does not exist!");
                return;
            }

            // Keys are epoch time seconds, values are MS teams URLs
            Dictionary<long, string> meeting_data = new Dictionary<long, string>();

            string[] lines = System.IO.File.ReadAllLines(csv_path);
            foreach(string line in lines) {
                string[] columns = line.Split(',');
                if (columns.Length < 2) {
                    continue; // Ignore blank lines and lines w/o URLs
                }
                string meeting_timestamp = columns[0];
                string meeting_url = columns[1];
                // Transform the timestamp into an epoch number
                DateTime timestamp_o = DateTime.Parse(meeting_timestamp);
                long epoch_seconds = (long) (timestamp_o.ToUniversalTime() - new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds;
                // Add the meeting to our dict
                meeting_data[epoch_seconds] = meeting_url;
            }

            //DateTime now = new DateTime();

            Console.WriteLine(lines.Length+" lines = "+lines);

            // TODO sort by time

            // TODO sleep until the next meeting

            // After sleeping, use the generic process start API to open the URL:
            // https://docs.microsoft.com/en-us/troubleshoot/dotnet/csharp/start-internet-browser


        }
    }
}
