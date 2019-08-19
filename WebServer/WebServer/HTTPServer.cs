using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace WebServer
{
    public class HTTPServer
    {
        private bool _running = false;
        private TcpListener _listener;

        public HTTPServer(int port)
        {
            _listener = new TcpListener(IPAddress.Any, port);
        }

        public void Start()
        {
            Thread serverThread = new Thread(new ThreadStart(Run));
            serverThread.Start();
        }

        private void Run()
        {
            _running = true;
            while (_running)
            {
                TcpClient client = _listener.AcceptTcpClient();
            }
        }

    }

}
