using System;
using System.Reflection.Metadata;
using Cinema_Functions;
using NUnit.Framework;

namespace Cinema_Tests
{
    [TestFixture(Author = "Mark Christison"), Description("Tests for Adult Before 5")]
    public class AdultBefore5
    {
        [TestCase, Description("Test for Standard input")]
        public void When_OneAdultMonday1pm_Expect_Cost1450()
        {
            TicketPriceController ticketPriceController = new();
            var adultTicketCost = ticketPriceController.Adult_Before_5(1, "adult", "monday", 1.00m);
            Assert.AreEqual(adultTicketCost, 14.5);
        }
        [TestCase, Description("Test for different day")]
        public void When_1AdultSaturday2pm_Expect_Cost1450()
        {
            TicketPriceController ticketPriceController = new();
            var adultTicketCost = ticketPriceController.Adult_Before_5(1, "adult", "saturday", 2.00m);
            Assert.AreEqual(adultTicketCost, 14.5);
        }
        [TestCase, Description("Test for 3 adult tickets")]
        public void When_3AdultThursday130pm_Expect_Cost4350()
        {
            TicketPriceController ticketPriceController = new();
            var adultTicketCost = ticketPriceController.Adult_Before_5(3, "adult", "thursday", 1.30m);
            Assert.AreEqual(adultTicketCost, 43.50);
        }
        [TestCase, Description("Test for adult on tuesday")]
        public void When_1AdultTuesday245_Expect_negative1()
        {
            TicketPriceController ticketPriceController = new();
            var adultTicketCost = ticketPriceController.Adult_Before_5(1, "adult", "tuesday", 2.45m);
            Assert.AreEqual(adultTicketCost, -1);
        }
        [TestCase, Description("Test for Child, should return -1")]
        public void When_1ChildWednesday245_Expect_negative1()
        {
            TicketPriceController ticketPriceController = new();
            var adultTicketCost = ticketPriceController.Adult_Before_5(1, "child", "wednesday", 2.45m);
            Assert.AreEqual(adultTicketCost, -1);
        }
        [TestCase, Description("Test for Student, should return -1")]
        public void When_1StudentWednesday3_Expect_negative1()
        {
            TicketPriceController ticketPriceController = new();
            var adultTicketCost = ticketPriceController.Adult_Before_5(1, "student", "wednesday", 3.00m);
            Assert.AreEqual(adultTicketCost, -1);
        }
        [TestCase, Description("Test for Senior, should return -1")]
        public void When_1SeniorWednesday300_Expect_negative1()
        {
            TicketPriceController ticketPriceController = new();
            var adultTicketCost = ticketPriceController.Adult_Before_5(1, "senior", "wednesday", 3.00m);
            Assert.AreEqual(adultTicketCost, -1);
        }
        [TestCase(Ignore = "Bug"), Description("Time does not work in 12 hour format. Input Validation is required to allow for only PM times.")]
        public void When_1AdultWednesday10am_Expect_Cost1450()
        {
            TicketPriceController ticketPriceController = new();
            var adultTicketCost = ticketPriceController.Adult_Before_5(1, "adult", "wednesday", 10.00m);
            Assert.AreEqual(adultTicketCost, 14.5);
        }
        [TestCase, Description("Test for family, should return -1")]
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
        [TestCase, Description("")]
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
        [TestCase, Description("Handles uppercase letters for person")]
        public void When_1ADULTWEDNESDAY_Expect_Negative1()
        {
            TicketPriceController ticketPriceController = new();
            var adultTicketCost = ticketPriceController.Adult_After_5(1, "ADULT", "WEDNESDAY", 8.00m);
            Assert.AreEqual(adultTicketCost, 17.5);
        }
    }

    [TestFixture(Author = "Mark Christison"), Description("Tests for Adult Tuesday")]
    public class AdultTuesday
    {
        [TestCase, Description("Test for Standard input")]
        public void When_OneAdultTuesday_Expect_Cost13()
        {
            TicketPriceController ticketPriceController = new();
            var adultTicketCost = ticketPriceController.Adult_Tuesday(1, "adult", "tuesday");
            Assert.AreEqual(adultTicketCost, 13);
        }
        [TestCase, Description("Test for 4 adult tickets")]
        public void When_FourAdultsTuesday_Expect_Cost52()
        {
            TicketPriceController ticketPriceController = new();
            var adultTicketCost = ticketPriceController.Adult_Tuesday(4, "adult", "tuesday");
            Assert.AreEqual(adultTicketCost, 52);
        }
        [TestCase, Description("Test for 1 child, returns -1")]
        public void When_OneChildTuesday_Expect_Negative1()
        {
            TicketPriceController ticketPriceController = new();
            var adultTicketCost = ticketPriceController.Adult_Tuesday(1, "child", "tuesday");
            Assert.AreEqual(adultTicketCost, -1);
        }
        [TestCase, Description("Test for 1 student, returns -1")]
        public void When_OneStudentTuesday_Expect_Negative1()
        {
            TicketPriceController ticketPriceController = new();
            var adultTicketCost = ticketPriceController.Adult_Tuesday(1, "student", "tuesday");
            Assert.AreEqual(adultTicketCost, -1);
        }
        [TestCase, Description("Test for 1 family, returns -1")]
        public void When_OneFamilyTuesday_Expect_Negative1()
        {
            TicketPriceController ticketPriceController = new();
            var adultTicketCost = ticketPriceController.Adult_Tuesday(1, "family", "tuesday");
            Assert.AreEqual(adultTicketCost, -1);
        }
        [TestCase, Description("Test for 1 family, returns -1")]
        public void When_OneAdultWednesday_Expect_Negative1()
        {
            TicketPriceController ticketPriceController = new();
            var adultTicketCost = ticketPriceController.Adult_Tuesday(1, "adult", "wednesday");
            Assert.AreEqual(adultTicketCost, -1);
        }
    }

    [TestFixture(Author = "Mark Christison"), Description("Tests for Child Under 16")]
    public class ChildUnder16
    {
        [TestCase, Description("Test for Standard input, 1 Child")]
        public void When_OneAdult_Expect_Cost13()
        {
            TicketPriceController ticketPriceController = new();
            var adultTicketCost = ticketPriceController.Child_Under_16(1, "child");
            Assert.AreEqual(adultTicketCost, 12);
        }
        [TestCase, Description("3 child tickets")]
        public void When_3Child_Expect_Cost36()
        {
            TicketPriceController ticketPriceController = new();
            var adultTicketCost = ticketPriceController.Child_Under_16(3, "child");
            Assert.AreEqual(adultTicketCost, 36);
        }
        [TestCase, Description("3 child tickets")]
        public void When_1Student_Expect_Negative1()
        {
            TicketPriceController ticketPriceController = new();
            var adultTicketCost = ticketPriceController.Child_Under_16(1, "student");
            Assert.AreEqual(adultTicketCost, -1);
        }
        [TestCase, Description("1 Family ticket")]
        public void When_1Family_Expect_Negative1()
        {
            TicketPriceController ticketPriceController = new();
            var adultTicketCost = ticketPriceController.Child_Under_16(1, "family");
            Assert.AreEqual(adultTicketCost, -1);
        }
        [TestCase, Description("1 Adult ticket")]
        public void When_OneAdult_Expect_Negative1()
        {
            TicketPriceController ticketPriceController = new();
            var adultTicketCost = ticketPriceController.Child_Under_16(1, "adult");
            Assert.AreEqual(adultTicketCost, -1);
        }
    }
}