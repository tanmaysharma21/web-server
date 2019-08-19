using System;
using System.Net;


namespace WebServer
{
    public class DynamicWebsite : IWebsite
    {
        public void Handle(Response responseGenrate, HttpListenerContext context, string path, HttpListenerResponse response)
        {
            throw new NotImplementedException();
        }
    }
}