using System;
using System.Net.Sockets;
using System.Text;
using System.Windows;

namespace WPF_TestTwo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //// Client Setup
            //TcpClient client = new TcpClient();

            //string ipAddress = IpAddressBox.Text;
            //int port = 27015;
            //client.Connect(ipAddress, port);

            //NetworkStream dataStream = client.GetStream();
            //do
            //{
            //    string keyInput = Console.ReadLine();

            //    byte[] data = Encoding.ASCII.GetBytes(keyInput);

            //    dataStream.Write(data, 0, data.Length);
            //} while (true);
        }
    }
}
