using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiChat_Server
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();

            CheckForIllegalCrossThreadCalls = false;
            connect();

        }

        //Địa chỉ
        IPEndPoint IP;
        Socket server;

        List<Socket> clientList;

        //Kết nối tới server
        void connect()
        {
            clientList = new List<Socket>();
            //Địa chỉ Server
            IP = new IPEndPoint(IPAddress.Any, 5656);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

            server.Bind(IP);

            Thread listen = new Thread(() =>
            {
                try
                {
                    while (true)
                    {
                        server.Listen(100);
                        Socket client = server.Accept();
                        clientList.Add(client);

                        Thread recieve = new Thread(receive);
                        recieve.IsBackground = true;
                        recieve.Start(client);
                    }
                }
                catch
                {
                    IP = new IPEndPoint(IPAddress.Any, 5656);
                    server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                }
            });
            listen.IsBackground = true;
            listen.Start();
        }

        //Đóng kết nối hiện thời
        void close()
        {
            server.Close();
        }

        //Gửi tin
        void send(Socket client)
        {
            if (txtMess.Text != string.Empty)
                client.Send(serialize(txtMess.Text));
            
        }

        //Nhận tin
        void receive(object obj)
        {
            Socket client = obj as Socket; 
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);

                    string mess = (string)deserialize(data);

                    addMess(mess);
                }
            }
            catch
            {
                clientList.Remove(client);
                client.Close();
            }
        }

        //Đưa tin nhắn vào khung chat
        void addMess(string s)
        {
            lvwMess.Items.Add(new ListViewItem(s) { Text = s });

        }// add chi tiêu

        //Phân mảnh
        byte[] serialize(object obj)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(stream, obj);

            return stream.ToArray();
        }

        ////Gom mảnh lại
        object deserialize(byte[] data)
        {
            MemoryStream stream = new MemoryStream(data);
            BinaryFormatter formatter = new BinaryFormatter();

            return formatter.Deserialize(stream);

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            foreach (Socket item in clientList)
            {
                send(item);
            }
            addMess(txtMess.Text);
            txtMess.Text = string.Empty;
        }

        private void Server_FormClosed(object sender, FormClosedEventArgs e)
        {
            close();
        }
    }
}
