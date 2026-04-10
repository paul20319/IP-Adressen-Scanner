using System;
using System.Net.NetworkInformation;
using System.Threading.Tasks;


namespace _20260410_IP_Adressen_Scanner
{
    internal class Program
    {
        static async void Main(string[] args)
        {
            Console.WriteLine("IP-Scanner von Paul und Sebastian");

            string baseIp = "192.168.1."; 

            for (int i = 1; i < 255; i++)
            {
                string iP = baseIp + i;

                Ping ping = new Ping();
            }

            Console.WriteLine("\nScan abgeschlossen.");

        }
    }
}
