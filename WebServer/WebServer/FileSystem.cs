using System.IO;


namespace WebServer
{
    public class FileSystem
    {
        public bool FileExistsCheck(string physicalPath)
        {
            if (File.Exists(physicalPath))
                return true;
            else
                return false;
        }
    }
}