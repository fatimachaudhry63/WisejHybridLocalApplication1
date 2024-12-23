using System.Threading;
using EmbedIO;
using Wisej.EmbedIO;

namespace WisejHybridLocalApplication1
{
    public class OfflineStartup
    {
        public static string Main(CancellationToken token, object[] args)
        {
            var url = "http://localhost:5000";
            var server = new WebServer(url);
            server.WithWisej();
            server.Run(token);

            return url;
        }
    }
}