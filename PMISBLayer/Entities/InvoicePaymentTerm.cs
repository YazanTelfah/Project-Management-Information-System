﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PMISBLayer.Entities
{
   public class InvoicePaymentTerm
    {
        public int InvoicePaymentTermID { get; set; }
        public int InvoiceId { get; set; }


        public Invoice Invoice { get; set; }

        public int PaymentTermId { get; set; }

        public PaymentTerm PaymentTerm { get; set; }
    }
}
