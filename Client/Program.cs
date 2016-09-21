using System;
using System.Net.Sockets;
using System.Net;

namespace Client
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");
			Socket s = new Socket (AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
			IPEndPoint ep = new IPEndPoint (IPAddress.Parse("127.0.0.1"), 1234);

			try {
				//s.Bind(ep);
				s.Connect(ep);
				Console.Write("Conectat");
			} catch {
				Console.WriteLine ("ERROR");
			}
			s.Close ();
		}
	}
}
