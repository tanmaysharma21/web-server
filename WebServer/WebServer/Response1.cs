using System.IO;
using System.Net;
using System.Text;


namespace WebServer
{
    public class Response
    {
        public void ResponseGenrator(string page, HttpListenerResponse response)
        {

            if (File.Exists(page))
            {
                TextReader tr = new StreamReader(page);
                page = tr.ReadToEnd();
                tr.Close();
            }

            byte[] buffer = Encoding.UTF8.GetBytes(page);
            try
            {
                response.ContentLength64 = buffer.Length;
                Stream st = response.OutputStream;
                st.Write(buffer, 0, buffer.Length);
                st.Close();
            }
            catch { }
        }
    }
}