using System.Net;
using System.Threading;


namespace WebServer
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpListener httpListener = new HttpListener();
            HTTPServer hTTPServer = new HTTPServer(httpListener);
            hTTPServer.AddPrefix("http://localhost:8080/");
            hTTPServer.StartServer();
        }
    }

    
}