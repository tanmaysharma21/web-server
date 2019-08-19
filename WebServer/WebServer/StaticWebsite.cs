using System.Net;


namespace WebServer
{
    public class StaticWebsite : IWebsite
    {
        public void Handle(Response responseGenrate, HttpListenerContext context, string path, HttpListenerResponse response)
        {
            responseGenrate.ResponseGenrator(path, response);
            context.Response.Close();
        }
    }
}