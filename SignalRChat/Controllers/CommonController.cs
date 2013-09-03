using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SignalRChat.Models;

namespace SignalRChat.Controllers
{
    public class CommonController : Controller
    {
        //
        // GET: /Common/
        [ChildActionOnly]
        public ActionResult PaymentGroup()
        {
            var signalRGroupId = Session[Helpers.SignalRGroupIdSessionKey] ?? Guid.NewGuid().ToString();
            Session[Helpers.SignalRGroupIdSessionKey] = signalRGroupId;

            var isPaymentCurrentlyBeingProcesses = Session[Helpers.IsPaymentCurrentlyBeingProcessedSessionKey] ?? false;

            var model = new PaymentModel() {SignalRGroupId = (string) signalRGroupId, IsPaymentCurrentlyBeingProcessed = (bool) isPaymentCurrentlyBeingProcesses};

            return PartialView("PaymentGroup", model);
        }

    }
}
