using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace CSIOCP
{
    class Program
    {
        static void Main(string[] args)
        {
            IPEndPoint point = new IPEndPoint(IPAddress.Parse("127.0.0.1"),9000);
            Server server = new Server(100,4048);
            server.Init();
            server.Start(point);
        }
    }
}
