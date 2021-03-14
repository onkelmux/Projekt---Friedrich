using System;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace Max_Zimmer
{
    public class chat : Hub
    {
        public void Send(string name, string message)
        {
            Clients.All.broadcastMessage(name, message);
        }
    }
}