using System.Net;
using System.Net.Sockets;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        UdpClient udpClient = new UdpClient();
        IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Broadcast, 12345);

        while (true)
        {
            string superTime = DateTime.Now.ToString("HH:mm:ss");
            string message = superTime;

            //проверка на звонок
            if (DateTime.Now.Minute == 00 && DateTime.Now.Second == 0)
            {
                message += " - Звонок";
            }

            byte[] data = Encoding.UTF8.GetBytes(message);
            udpClient.Send(data, data.Length, iPEndPoint);
            Thread.Sleep(1000);
        }
    }
}