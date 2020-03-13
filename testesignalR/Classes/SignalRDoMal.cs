using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace testesignalR.Classes
{
    public class SignalRDoMal : Hub
    {
        public void Send(string nome,string mensagem)
        {
            Clients.All.broadcastMessage(nome,mensagem);
        }
    }
}