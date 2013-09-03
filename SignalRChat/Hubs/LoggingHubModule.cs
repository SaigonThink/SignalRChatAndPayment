using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR.Hubs;

namespace SignalRChat.Hubs
{
    public class LoggingHubModule : HubPipelineModule
    {
        protected override bool OnBeforeConnect(IHub hub)
        {
            Debug.WriteLine("Logging OnBeforeConnect: {0}", (object)hub.Context.ConnectionId);

            return true;
        }

        protected override void OnAfterConnect(IHub hub)
        {
            Debug.WriteLine("Loggin OnAfterConnect: {0}", (object)hub.Context.ConnectionId);
        }

        protected override bool OnBeforeIncoming(IHubIncomingInvokerContext context)
        {
            Debug.WriteLine("Loggin OnBeforeIncoming: {0}, {1}", context.Hub.Context.ConnectionId, context.MethodDescriptor.Name);

            return true;
        }

        protected override object OnAfterIncoming(object result, IHubIncomingInvokerContext context)
        {
            Debug.WriteLine("Loggin OnAfterIncoming: {0}, {1}, {2}", context.Hub.Context.ConnectionId, context.MethodDescriptor.Name, result);

            return result;
        }

        protected override bool OnBeforeOutgoing(IHubOutgoingInvokerContext context)
        {
            Debug.WriteLine("Loggin OnBeforeOutgoing: {0}", (object)context.Invocation.Method);

            return true;
        }

        protected override void OnAfterOutgoing(IHubOutgoingInvokerContext context)
        {
            Debug.WriteLine("Loggin OnAfterOutgoing: {0}", (object)context.Invocation.Method);
        }

        protected override bool OnBeforeDisconnect(IHub hub)
        {
            Debug.WriteLine("Loggin OnBeforeDisconnect: {0}", (object)hub.Context.ConnectionId);

            return true;
        }

        protected override void OnAfterDisconnect(IHub hub)
        {
            Debug.WriteLine("Loggin OnAfterDisconnect: {0}", (object)hub.Context.ConnectionId);
        }

        protected override bool OnBeforeReconnect(IHub hub)
        {
            Debug.WriteLine("Loggin OnBeforeReconnect: {0}", (object)hub.Context.ConnectionId);

            return true;
        }

        protected override void OnAfterReconnect(IHub hub)
        {
            Debug.WriteLine("Loggin OnAfterReconnect: {0}", (object)hub.Context.ConnectionId);
        }
    }
}