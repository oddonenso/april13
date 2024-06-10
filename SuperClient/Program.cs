using System.Net;
using System.Net.Sockets;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        UdpClient clinet = new UdpClient(12345);
        IPEndPoint iPEnd = new IPEndPoint(IPAddress.Any, 12345);

        while (true)
        {
            byte[] data = clinet.Receive(ref iPEnd);
            string receivedTime = Encoding.UTF8.GetString(data);
            Console.WriteLine($"А на часах: {receivedTime}");
        }
    }
}
