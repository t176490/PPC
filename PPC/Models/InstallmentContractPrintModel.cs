﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PPC.Models
{
    public class InstallmentContractPrintModel
    {
        public string Installment_Contract_Code { get; set; }
        public string Customer_Name { get; set; }
        public string Customer_Address { get; set; }
        public string Mobile { get; set; }
        public string SSN { get; set; }
        public Nullable<System.DateTime> Date_Of_Contract { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<decimal> Deposit { get; set; }
        public string Property_Code { get; set; }
        public string Address { get; set; }
    }
}