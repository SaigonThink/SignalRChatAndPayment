using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SignalRChat.Models
{
    public class PaymentModel
    {
        public string SignalRGroupId { get; set; }
        public bool IsPaymentCurrentlyBeingProcessed { get; set; }
        public string CreditCardNum { get; set; }
    }
}