using SOLID_PRINCIPLES.OCP;
namespace SOLID_PRINCIPLES
{
    /// <summary>
    /// this is the main method of the invoice
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Invoice FInvoice = new FinalInvoice();
            Invoice PInvoice = new ProposedInvoice();
            Invoice RInvoice = new RecurringInvoice();
            double FInvoiceAmount = FInvoice.GetInvoiceDiscount(1000);
            double PInvoiceAmount = PInvoice.GetInvoiceDiscount(1000);
            double RInvoiceAmount = RInvoice.GetInvoiceDiscount(1000);
            Console.WriteLine("enter your Amount");
            Console.ReadLine();
            Console.WriteLine("This is the final invoice:  "+FInvoiceAmount);
            Console.WriteLine("This is the Proposed invoice: "+ PInvoiceAmount);
            Console.WriteLine("This is the RecurringInvoice: "+RInvoiceAmount);
        }
    }
}