//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PPC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Installment_Contract
    {
        public int ID { get; set; }
        public string Installment_Contract_Code { get; set; }
        public string Customer_Name { get; set; }
        public Nullable<int> Year_Of_Birth { get; set; }
        public string SSN { get; set; }
        public string Customer_Address { get; set; }
        public string Mobile { get; set; }
        public int Property_ID { get; set; }
        public Nullable<System.DateTime> Date_Of_Contract { get; set; }
        public string Installment_Payment_Method { get; set; }
        public Nullable<int> Payment_Period { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<decimal> Deposit { get; set; }
        public Nullable<decimal> Loan_Amount { get; set; }
        public Nullable<decimal> Taken { get; set; }
        public Nullable<decimal> Remain { get; set; }
        public bool Status { get; set; }
    
        public virtual Property Property { get; set; }
    }
}
