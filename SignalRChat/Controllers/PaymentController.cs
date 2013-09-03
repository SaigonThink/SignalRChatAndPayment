using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.SignalR;
using SignalRChat.Hubs;
using SignalRChat.Models;

namespace SignalRChat.Controllers
{
    public class PaymentController : Controller
    {
        //
        // GET: /Payment/

        [HttpGet]
        public ActionResult PaymentForm()
        {
            return View(new PaymentModel());
        }

        [HttpPost]
        public ActionResult SubmitPayment(PaymentModel paymentModel)
        {
            paymentModel.IsPaymentCurrentlyBeingProcessed = true;
            Session[Helpers.IsPaymentCurrentlyBeingProcessedSessionKey] = true;
            return View("PaymentForm", paymentModel);
        }

        [HttpGet]
        public ActionResult HanldeFTNIPostBack()
        {
            var paymentHub = GlobalHost.ConnectionManager.GetHubContext<PaymentHub>();

            var sessionId = Session[Helpers.SignalRGroupIdSessionKey].ToString();
            paymentHub.Clients.Group(sessionId).postPaymentResults(sessionId, "Payment successful");

            return new EmptyResult();
        }


    }
}
