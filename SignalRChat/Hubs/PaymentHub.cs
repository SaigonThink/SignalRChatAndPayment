using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace SignalRChat.Hubs
{
    public class PaymentHub : Hub
    {
        #region "Overridden methods"

        public override Task OnDisconnected()
        {
            if (Context.Request.Cookies.ContainsKey(Helpers.SignalRGroupIdCookieKey))
            {
                var groupId = Context.Request.Cookies[Helpers.SignalRGroupIdCookieKey].Value;
                Clients.Group(groupId).postPaymentResults("Payment", groupId + " is Disconnected");

                Groups.Remove(Context.ConnectionId, Context.Request.Cookies[Helpers.SignalRGroupIdCookieKey].Value);
            }

            Clients.AllExcept(Context.ConnectionId).postPaymentResults("Payment", Context.ConnectionId + " is Disconnected");

            return base.OnDisconnected();
        }
        #endregion

        public void Connect(string sessionId)
        {
            Groups.Add(Context.ConnectionId, sessionId);

            Clients.Group(sessionId).postPaymentResults("Payment", sessionId + " is just connected.");
        }

    }
}