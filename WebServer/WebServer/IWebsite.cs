using System.Net;


namespace WebServer
{
    public interface IWebsite
    {
        void Handle(Response responseGenrate, HttpListenerContext context, string path, HttpListenerResponse response);
    }
}