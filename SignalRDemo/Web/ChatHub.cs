using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using System;

namespace Web
{
	[HubName("chat")]
	public class ChatHub : Hub
	{
		[HubMethodName("announceToEverybody")]
		public void Announce(string message)
		{
			Clients.All.Announce(message);
		}

		public DateTime GetServerDateTime()
		{
			return DateTime.Now;
		}
	}
}