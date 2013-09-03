using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace SignalRChat.Hubs
{
    public class ChatHub : Hub
    {
        #region "Overridden methods"

        public override Task OnDisconnected()
        {
            Clients.All.addNewMessageToPage("Priyank", "Disconnected");
            return base.OnDisconnected();
        }
        #endregion

        public void Connect(string sessionId)
        {
            Groups.Add(Context.ConnectionId, sessionId);
        }
        public void SendToGroup(string groupName, string message)
        {
            Clients.Group(groupName).addNewMessageToPage("Priyank", message);
        }

        public void SendToAll(string name, string message)
        {
            string username = Context.User.Identity.Name;

            // Call the addNewMessageToPage method to update clients.
            Clients.All.addNewMessageToPage(name, message);
        }

        public void SendToCaller(string name, string message)
        {
            // Call the addNewMessageToPage method to update clients.
            Clients.Caller.addNewMessageToPage(name, message);
        }
        
        public void SendToAllOthers(string name, string message)
        {
            // Call the addNewMessageToPage method to update clients.
            Clients.Others.addNewMessageToPage(name, message);
        }
    }
}