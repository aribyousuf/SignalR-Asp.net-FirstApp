using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace SignalRFirstApp
{
    public class MyHub : Hub
    {
        public void Work(string task)
        {
            Clients.All.Work(task);
        }
    }
}