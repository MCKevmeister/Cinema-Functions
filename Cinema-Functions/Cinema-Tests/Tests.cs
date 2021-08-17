using System;
using System.Reflection.Metadata;
using Cinema_Functions;
using NUnit.Framework;

namespace Cinema_Tests
{
    [TestFixture]
    public class AdultBefore5
    {
        [TestCase(Author = "Mark Christison")]
        public void When_OneAdultMonday1pm_Expect_Cost1450()
        {
            TicketPriceController ticketPriceController = new();
            var adultTicketCost = ticketPriceController.Adult_Before_5(1, "adult", "monday", 2.00m);
            Assert.AreEqual(adultTicketCost, 14.5);
        }
        [TestCase]
        public void When_1AdultSaturday2pm_Expect_Cost1450()
        {
            TicketPriceController ticketPriceController = new();
            var adultTicketCost = ticketPriceController.Adult_Before_5(1, "adult", "saturday", 2.00m);
            Assert.AreEqual(adultTicketCost, 14.5);
        }
        [TestCase]
        public void When_3AdultThursday130pm_Expect_Cost4350()
        {
            TicketPriceController ticketPriceController = new();
            var adultTicketCost = ticketPriceController.Adult_Before_5(3, "adult", "thursday", 1.30m);
            Assert.AreEqual(adultTicketCost, 43.50);
        }
        [TestCase]
        public void When_1AdultTuesday245_Expect_negative1()
        {
            TicketPriceController ticketPriceController = new();
            var adultTicketCost = ticketPriceController.Adult_Before_5(1, "adult", "tuesday", 2.45m);
            Assert.AreEqual(adultTicketCost, -1);
        }
        [TestCase]
        public void When_1ChildWednesday245_Expect_negative1()
        {
            TicketPriceController ticketPriceController = new();
            var adultTicketCost = ticketPriceController.Adult_Before_5(1, "child", "wednesday", 2.45m);
            Assert.AreEqual(adultTicketCost, -1);
        }
        [TestCase]
        public void When_1StudentWednesday3_Expect_negative1()
        {
            TicketPriceController ticketPriceController = new();
            var adultTicketCost = ticketPriceController.Adult_Before_5(1, "student", "wednesday", 3.00m);
            Assert.AreEqual(adultTicketCost, -1);
        }
        [TestCase]
        public void When_1SeniorWednesday300_Expect_negative1()
        {
            TicketPriceController ticketPriceController = new();
            var adultTicketCost = ticketPriceController.Adult_Before_5(1, "senior", "wednesday", 3.00m);
            Assert.AreEqual(adultTicketCost, -1);
        }
        [TestCase(Ignore = "Possible identified bug in code")]
        public void When_1AdultWednesday10am_Expect_Cost1450()
        {
            TicketPriceController ticketPriceController = new();
            var adultTicketCost = ticketPriceController.Adult_Before_5(1, "adult", "wednesday", 10.00m);
            Assert.AreEqual(adultTicketCost, 14.5);
        }
        [TestCase]
        public void When_1FamilyWednesday3_Expect_negative1()
        {
            TicketPriceController ticketPriceController = new();
            var adultTicketCost = ticketPriceController.Adult_Before_5(1, "family", "wednesday", 3.00m);
            Assert.AreEqual(adultTicketCost, -1);
        }
    }

    [TestFixture]
    public class AdultAfter5
    {
        [TestCase]
        public void When_1AdultWednesday6pm_Expect_Cost1750()
        {
            TicketPriceController ticketPriceController = new();
            var adultTicketCost = ticketPriceController.Adult_After_5(1, "adult", "wednesday", 6.00m);
            Assert.AreEqual(adultTicketCost, 17.5);
        }
        [TestCase]
        public void When_2AdultThursday745_Expect_Cost35()
        {
            TicketPriceController ticketPriceController = new();
            var adultTicketCost = ticketPriceController.Adult_After_5(2, "adult", "thursday", 7.45m);
            Assert.AreEqual(adultTicketCost, 35);
        }
        [TestCase]
        public void When_1AdultSaturday800_Expect_Cost1750()
        {
            TicketPriceController ticketPriceController = new();
            var adultTicketCost = ticketPriceController.Adult_After_5(1, "adult", "saturday", 8.00m);
            Assert.AreEqual(adultTicketCost, 17.50);
        }
        [TestCase]
        public void When_1StudentWednesday_Expect_Negative1()
        {
            TicketPriceController ticketPriceController = new();
            var adultTicketCost = ticketPriceController.Adult_After_5(1, "student", "wednesday", 8.00m);
            Assert.AreEqual(adultTicketCost, -1);
        }
        [TestCase]
        public void When_1FamilyWednesday_Expect_Negative1()
        {
            TicketPriceController ticketPriceController = new();
            var adultTicketCost = ticketPriceController.Adult_After_5(1, "family", "wednesday", 8.00m);
            Assert.AreEqual(adultTicketCost, -1);
        }
        [TestCase]
        public void When_1SeniorWednesday_Expect_Negative1()
        {
            TicketPriceController ticketPriceController = new();
            var adultTicketCost = ticketPriceController.Adult_After_5(1, "senior", "wednesday", 8.00m);
            Assert.AreEqual(adultTicketCost, -1);
        }
    }
 
}