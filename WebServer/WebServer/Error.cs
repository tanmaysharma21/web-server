using System.Net;


namespace WebServer
{
    public class Error
    {
        public void Error404NotFound(Dispatch dispatch, Response responseGenrate, HttpListenerResponse response, HttpListenerContext context, string path)
        {
            path = dispatch.Applist["error"] + "404.html";
            responseGenrate.ResponseGenrator(path, response);
            context.Response.Close();
        }
    }

    
}