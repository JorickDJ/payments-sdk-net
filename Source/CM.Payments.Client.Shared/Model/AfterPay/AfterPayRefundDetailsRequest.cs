﻿using JetBrains.Annotations;
using Newtonsoft.Json;

namespace CM.Payments.Client.Model
{
    [PublicAPI]
    public class AfterPayRefundDetailsRequest : RefundDetailsRequest
    {
        /// <summary>
        ///     Invoice number for the refund.
        /// </summary>
        [JsonProperty("credit_invoice_number")]
        public string CreditInvoiceNumber { get; set; }
    }
}