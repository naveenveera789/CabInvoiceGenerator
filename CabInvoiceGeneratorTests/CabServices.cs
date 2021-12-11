using CabInvoiceGenerator;
using NUnit.Framework;

namespace CabInvoiceGeneratorTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GivenDistanceAndTime_WhenCalculate_ShouldReturnTotalFare()
        {
            InvoiceGenerator invoice = new InvoiceGenerator();
            double result = invoice.CalculateCabFare(5.0, 2);
            double expected = 52;
            Assert.AreEqual(result, expected);
        }
    }
}