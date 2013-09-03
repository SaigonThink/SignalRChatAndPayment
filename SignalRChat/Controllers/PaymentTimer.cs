using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using Microsoft.AspNet.SignalR;
using SignalRChat.Hubs;

namespace SignalRChat.Controllers
{
    public static class PaymentTimer
    {
        /*private static readonly TimeSpan _updateInterval = TimeSpan.FromMilliseconds(10000);
        private static readonly Timer _timer = new Timer(OnTimerElapsed, null, _updateInterval, _updateInterval);

        public static void Start()
        {
            _timer.Change(TimeSpan.Zero, _updateInterval);
        }

        private static void OnTimerElapsed(object sender)
        {
            var chatHub = GlobalHost.ConnectionManager.GetHubContext<ChatHub>();
            chatHub.Clients.All.postPaymentResults("Priyank", "Payment successful.");
        }*/
    }
}