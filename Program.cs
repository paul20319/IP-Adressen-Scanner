using System;
using System.Buffers.Text;
using System.Globalization;
using System.Net.NetworkInformation;
using System.Threading.Tasks;


namespace _20260410_IP_Adressen_Scanner
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("IP-Scanner von Paul und Sebastian");

            string baseIp = "192.168.1.";
            ScanNetwork(baseIp);
            

            Console.WriteLine("\nScan abgeschlossen.");

        }

        static async Task ScanNetwork(string baseIP)
        {
            for (int i = 1; i < 255; i++)
            {
                string iP = baseIP + i;

                Ping ping = new Ping();
                try
                {
                    PingReply reply = await ping.SendPingAsync(iP, 100);

                    if (reply.Status == IPStatus.Success)
                    {
                        Console.WriteLine($"Aktiv: {iP}");
                    }
                }
                catch
                {

                }


            }
        }
    }
}
