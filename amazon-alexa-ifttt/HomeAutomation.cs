using System;
using System.Net.Sockets;
using System.Text;

namespace amazon_alexa_ifttt
{
    public static class HomeAutomation
    {
        /* IP of the Home Automation OS */
        private static string IP = "192.168.10.200";
        private static Int32 PORT = 8080;
        private static TcpClient server;

        public static void send_command(string command)
        {
            try
            {
                server = new TcpClient(IP, PORT);
            }
            catch (SocketException)
            {
                Console.WriteLine("Unable to connect to server");
                return;
            }
            NetworkStream ns = server.GetStream();

            ns.Write(Encoding.ASCII.GetBytes(command), 0, command.Length);
            ns.Flush();

            server.GetStream().Close();
            server.Close();
        }
    }
}