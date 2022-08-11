using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INVOICE
{
    /// <summary>
    /// This is the abstract class
    /// </summary>
    public abstract class INVOICE
    {
        public double FinalInvoice { get; set; }
        public double TotalInvoice { get; set; }


    }
}


internal class INVOICE2 { }

namespace SOLID_PRINCIPLES.OCP
{
    /// <summary>
    /// InvoiceType Discount
    /// </summary>
    public class Invoice
    {
        public virtual double GetInvoiceDiscount(double amount)
        {
            return amount - 10;
        }
    }

    /// <summary>
    /// This is the FinalInvoice Class with the dicount method
    /// </summary>
    public class FinalInvoice : Invoice
    {
        public override double GetInvoiceDiscount(double amount)
        {
            return  base.GetInvoiceDiscount(amount) - 50;
        }
    }
    /// <summary>
    /// This is the ProposedInvoice Class with the discount method
    /// </summary>
    public class ProposedInvoice : Invoice
    {
        public override double GetInvoiceDiscount(double amount)
        {
            try
            {

                return base.GetInvoiceDiscount(amount) - 40;
            }
            catch (Exception)
            {

                return 0;
            }
        }
    }
    /// <summary>
    /// This is the RecurringInvoice Class with the discount method
    /// </summary>
    public class RecurringInvoice : Invoice
    {
        public override double GetInvoiceDiscount(double amount)
        {
            return base.GetInvoiceDiscount(amount) - 30;
        }
    }
}
