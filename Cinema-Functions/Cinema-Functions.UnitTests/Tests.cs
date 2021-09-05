using Cinema_Functions;
using NUnit.Framework;

namespace Cinema_Tests
{
    [TestFixture(Author = "Mark Christison"), Description("Tests for Adult Before 5"), Category("AdultBefore5")]
    public class AdultBefore5
    {
        [Test, Description("Test for Standard input")]
        public void When_OneAdultMonday1pm_Expect_Cost1450()
        {
            // Arrange
            TicketPriceController ticketPriceController = new();
            
            // Act
            var adultTicketCost = ticketPriceController.Adult_Before_5(1, "adult", "monday", 1.00m);
            
            //Assert
            Assert.AreEqual(14.5m, adultTicketCost);
            Assert.NotNull(adultTicketCost);
            Assert.IsInstanceOf<decimal>(adultTicketCost);
        }

        [Test, Description("Test for different day")]
        public void When_1AdultSaturday2pm_Expect_Cost1450()
        {
            // Arrange
            TicketPriceController ticketPriceController = new();
            
            // Act
            var adultTicketCost = ticketPriceController.Adult_Before_5(1, "adult", "saturday", 2.00m);
            
            // Assert
            Assert.AreEqual(14.5m, adultTicketCost);
            Assert.NotNull(adultTicketCost);
            Assert.IsInstanceOf<decimal>(adultTicketCost);
        }

        [Test, Description("Test for 3 adult tickets")]
        public void When_3AdultThursday130pm_Expect_Cost4350()
        {
            // Arrange
            TicketPriceController ticketPriceController = new();
            
            // Act
            var adultTicketCost = ticketPriceController.Adult_Before_5(3, "adult", "thursday", 1.30m);
            
            // Assert
            Assert.AreEqual(43.50m, adultTicketCost);
            Assert.NotNull(adultTicketCost);
            Assert.IsInstanceOf<decimal>(adultTicketCost);
        }

        [Test, Description("Test for adult on tuesday")]
        public void When_1AdultTuesday245_Expect_negative1()
        {
            // Arrange
            TicketPriceController ticketPriceController = new();
            
            // Act
            var adultTicketCost = ticketPriceController.Adult_Before_5(1, "adult", "tuesday", 2.45m);
            
            //Assert
            Assert.AreEqual(-1m, adultTicketCost);
            Assert.NotNull(adultTicketCost);
            Assert.IsInstanceOf<decimal>(adultTicketCost);
        }

        [Test, Description("Test for Child, should return -1")]
        public void When_1ChildWednesday245_Expect_negative1()
        {
            // Arrange
            TicketPriceController ticketPriceController = new();
            
            // Act
            var adultTicketCost = ticketPriceController.Adult_Before_5(1, "child", "wednesday", 2.45m);
            
            // Assert
            Assert.AreEqual(-1m, adultTicketCost);
            Assert.NotNull(adultTicketCost);
            Assert.IsInstanceOf<decimal>(adultTicketCost);
        }

        [Test, Description("Test for Student, should return -1")]
        public void When_1StudentWednesday3_Expect_negative1()
        {
            // Arrange
            TicketPriceController ticketPriceController = new();
            
            // Act
            var adultTicketCost = ticketPriceController.Adult_Before_5(1, "student", "wednesday", 3.00m);
            
            // Assert
            Assert.AreEqual(-1m, adultTicketCost);
            Assert.NotNull(adultTicketCost);
            Assert.IsInstanceOf<decimal>(adultTicketCost);
        }

        [Test, Description("Test for Senior, should return -1")]
        public void When_1SeniorWednesday300_Expect_negative1()
        {
            // Arrange
            TicketPriceController ticketPriceController = new();
            
            // Act
            var adultTicketCost = ticketPriceController.Adult_Before_5(1, "senior", "wednesday", 3.00m);
            
            // Assert
            Assert.AreEqual(-1m, adultTicketCost);
            Assert.NotNull(adultTicketCost);
            Assert.IsInstanceOf<decimal>(adultTicketCost);
        }

        [Test]
        [Ignore("Bug, Time does not work in 12 hour format. Input Validation is required to allow for only PM times.")]
        [Description("1 Adult on Wednesday at 10am, should return 14.50")]
        public void When_1AdultWednesday10am_Expect_Cost1450()
        {
            // Arrange
            TicketPriceController ticketPriceController = new();
            
            // Act
            var adultTicketCost = ticketPriceController.Adult_Before_5(1, "adult", "wednesday", 10.00m);

            // Assert
            Assert.AreEqual(14.5m, adultTicketCost);
            Assert.NotNull(adultTicketCost);
            Assert.IsInstanceOf<decimal>(adultTicketCost);
        }

        [Test, Description("Test for family, should return -1")]
        public void When_1FamilyWednesday3_Expect_negative1()
        {
            // Arrange
            TicketPriceController ticketPriceController = new();
            
            // Act
            var adultTicketCost = ticketPriceController.Adult_Before_5(1, "family", "wednesday", 3.00m);

            // Assert
            Assert.AreEqual(-1m, adultTicketCost);
            Assert.NotNull(adultTicketCost);
            Assert.IsInstanceOf<decimal>(adultTicketCost);
        }
    }

    [TestFixture(Author = "Mark Christison"), Description("Tests for Adult After 5"), Category("AdultAfter5")]
    public class AdultAfter5
    {
        [Test, Description("Test for 1 Adult after 5pm")]
        public void When_1AdultWednesday6pm_Expect_Cost1750()
        {
            // Arrange
            TicketPriceController ticketPriceController = new();
            
            // Act
            var adultTicketCost = ticketPriceController.Adult_After_5(1, "adult", "wednesday", 6.00m);
            
            // Assert
            Assert.AreEqual(17.5m, adultTicketCost);
            Assert.NotNull(adultTicketCost);
            Assert.IsInstanceOf<decimal>(adultTicketCost);
        }

        [Test, Description("Handle Multiple adult tickets")]
        public void When_2AdultThursday745_Expect_Cost35()
        {
            // Arrange
            TicketPriceController ticketPriceController = new();
            
            // Act
            var adultTicketCost = ticketPriceController.Adult_After_5(2, "adult", "thursday", 7.45m);
            
            // Assert
            Assert.AreEqual(35m,adultTicketCost);
            Assert.NotNull(adultTicketCost);
            Assert.IsInstanceOf<decimal>(adultTicketCost);
        }

        [Test, Description("1 Adult on Saturday at 8 Cost $17.50")]
        public void When_1AdultSaturday800_Expect_Cost1750()
        {
            // Arrange
            TicketPriceController ticketPriceController = new();
            
            // Act
            var adultTicketCost = ticketPriceController.Adult_After_5(1, "adult", "saturday", 8.00m);
            
            // Assert
            Assert.AreEqual(17.50m, adultTicketCost);
        }

        [Test, Description("1 Student on Wednesday, returns -1")]
        public void When_1StudentWednesday_Expect_Negative1()
        {
            // Arrange
            TicketPriceController ticketPriceController = new();
            
            // Act
            var adultTicketCost = ticketPriceController.Adult_After_5(1, "student", "wednesday", 8.00m);
            
            // Assert
            Assert.AreEqual(-1m, adultTicketCost);
        }

        [Test, Description("1 Family on Wednesday, returns -1")]
        public void When_1FamilyWednesday_Expect_Negative1()
        {
            // Arrange
            TicketPriceController ticketPriceController = new();
            
            // Act
            var adultTicketCost = ticketPriceController.Adult_After_5(1, "family", "wednesday", 8.00m);
            
            // Assert
            Assert.AreEqual(-1m, adultTicketCost);
        }

        [Test, Description("1 Senior on Wednesday, returns -1")]
        public void When_1SeniorWednesday_Expect_Negative1()
        {
            // Arrange
            TicketPriceController ticketPriceController = new();
            
            // Act
            var adultTicketCost = ticketPriceController.Adult_After_5(1, "senior", "wednesday", 8.00m);
            
            // Assert
            Assert.AreEqual(-1m, adultTicketCost);
        }

        [Test, Description("Handles uppercase letters for person")]
        public void When_1ADULTWEDNESDAY_Expect_Negative1()
        {
            // Arrange
            TicketPriceController ticketPriceController = new();
            
            // Act
            var adultTicketCost = ticketPriceController.Adult_After_5(1, "ADULT", "WEDNESDAY", 8.00m);
            
            // Assert
            Assert.AreEqual(17.5m, adultTicketCost);
        }
    }

    [TestFixture(Author = "Mark Christison"), Description("Tests for Adult Tuesday"), Category("AdultTuesday")]
    public class AdultTuesday
    {
        [Test, Description("Test for Standard input")]
        public void When_OneAdultTuesday_Expect_Cost13()
        {
            //Arrange
            TicketPriceController ticketPriceController = new();
            
            //Act
            var adultTicketCost = ticketPriceController.Adult_Tuesday(1, "adult", "tuesday");
            
            //Assert
            Assert.AreEqual(13m,adultTicketCost);
        }

        [Test]
        [Description("Test for 4 adult tickets")]
        public void When_FourAdultsTuesday_Expect_Cost52()
        {
            //Arrange
            TicketPriceController ticketPriceController = new();
            
            //Act
            var adultTicketCost = ticketPriceController.Adult_Tuesday(4, "adult", "tuesday");
            
            //Assert
            Assert.AreEqual(52m, adultTicketCost);
        }

        [Test, Description("Test for 1 child, returns -1")]
        public void When_OneChildTuesday_Expect_Negative1()
        {
            //Arrange
            TicketPriceController ticketPriceController = new();
            
            //Act
            var adultTicketCost = ticketPriceController.Adult_Tuesday(1, "child", "tuesday");
            
            //Assert
            Assert.AreEqual(-1m, adultTicketCost);
        }

        [Test, Description("Test for 1 student, returns -1")]
        public void When_OneStudentTuesday_Expect_Negative1()
        {
            //Arrange
            TicketPriceController ticketPriceController = new();
            
            //Act
            var adultTicketCost = ticketPriceController.Adult_Tuesday(1, "student", "tuesday");
            
            //Assert
            Assert.AreEqual(-1m, adultTicketCost);
        }

        [Test, Description("Test for 1 family, returns -1")]
        public void When_OneFamilyTuesday_Expect_Negative1()
        {
            //Arrange
            TicketPriceController ticketPriceController = new();
            
            //Act
            var adultTicketCost = ticketPriceController.Adult_Tuesday(1, "family", "tuesday");
            
            //Assert
            Assert.AreEqual(-1m, adultTicketCost);
        }

        [Test, Description("Test for 1 family, returns -1")]
        public void When_OneAdultWednesday_Expect_Negative1()
        {
            //Arrange
            TicketPriceController ticketPriceController = new();
            
            //Act
            var adultTicketCost = ticketPriceController.Adult_Tuesday(1, "adult", "wednesday");
            
            //Assert
            Assert.AreEqual(-1m, adultTicketCost);
        }
    }

    [TestFixture(Author = "Mark Christison"), Description("Tests for Child Under 16"), Category("ChildUnder16")]
    public class ChildUnder16
    {
        [Test, Description("Test for Standard input, 1 Child")]
        public void When_OneAdult_Expect_Cost13()
        {
            //Arrange
            TicketPriceController ticketPriceController = new();
            
            //Act
            var childTicketCost = ticketPriceController.Child_Under_16(1, "child");
            
            //Assert
            Assert.AreEqual(12m, childTicketCost);
        }

        [Test, Description("3 child tickets")]
        public void When_3Child_Expect_Cost36()
        {
            //Arrange
            TicketPriceController ticketPriceController = new();
            
            //Act
            var childTicketCost = ticketPriceController.Child_Under_16(3, "child");
            
            //Assert
            Assert.AreEqual(36m, childTicketCost);
        }

        [Test, Description("3 child tickets")]
        public void When_1Student_Expect_Negative1()
        {
            //Arrange
            TicketPriceController ticketPriceController = new();
            
            //Act
            var childTicketCost = ticketPriceController.Child_Under_16(1, "student");
            
            //Assert
            Assert.AreEqual(-1m, childTicketCost);
        }

        [Test, Description("1 Family ticket")]
        public void When_1Family_Expect_Negative1()
        {
            //Arrange
            TicketPriceController ticketPriceController = new();
            
            //Act
            var childTicketCost = ticketPriceController.Child_Under_16(1, "family");
            
            //Assert
            Assert.AreEqual(-1m, childTicketCost);
        }

        [Test, Description("1 Adult ticket")]
        public void When_OneAdult_Expect_Negative1()
        {
            //Arrange
            TicketPriceController ticketPriceController = new();
            
            //Act
            var childTicketCost = ticketPriceController.Child_Under_16(1, "adult");
            
            //Assert
            Assert.AreEqual(-1m, childTicketCost);
        }
    }

    [TestFixture(Author = "Mark Christison"), Description("Tests for Senior"), Category("Senior")]
    public class Senior
    {
        [Test, Description("Test for Standard input, 1 Senior")]
        public void When_1Senior_Expect_Cost1250()
        {
            //Arrange
            TicketPriceController ticketPriceController = new();
            
            //Act
            var seniorTicketCost = ticketPriceController.Senior(1, "senior");
            
            //Assert
            Assert.AreEqual(12.5m, seniorTicketCost);
        }

        [Test, Description("Test for 3 senior tickets")]
        public void When_3Senior_Expect_Cost3750()
        {
            //Arrange
            TicketPriceController ticketPriceController = new();
            
            //Act
            var seniorTicketCost = ticketPriceController.Senior(3, "senior");
            
            //Assert
            Assert.AreEqual(37.50m, seniorTicketCost);
        }

        [Test, Description("Test for 3 senior tickets")]
        public void When_1Student_Expect_Negative1()
        {
            //Arrange
            TicketPriceController ticketPriceController = new();
            
            //Act
            var seniorTicketCost = ticketPriceController.Senior(1, "student");
            
            //Assert
            Assert.AreEqual(-1m, seniorTicketCost);
        }

        [Test, Description("Test for 1 family ticket")]
        public void When_1Family_Expect_Negative1()
        {
            //Arrange
            TicketPriceController ticketPriceController = new();
            
            //Act
            var seniorTicketCost = ticketPriceController.Senior(1, "family");
            
            //Assert
            Assert.AreEqual(-1m, seniorTicketCost);
        }

        [Test, Description("Test for 1 adult ticket")]
        public void When_1Adult_Expect_Negative1()
        {
            //Arrange
            TicketPriceController ticketPriceController = new();
            
            //Act
            var seniorTicketCost = ticketPriceController.Senior(1, "adult");
            
            //Assert
            Assert.AreEqual(-1m, seniorTicketCost);
        }

        [Test, Description("Test for 1000 senior tickets")]
        public void When_1000Senior_Expect_12500()
        {
            //Arrange
            TicketPriceController ticketPriceController = new();

            //Act
            var seniorTicketCost = ticketPriceController.Senior(1000, "senior");
            
            //Assert
            Assert.AreEqual(12500m, seniorTicketCost);
        }
        [Test, Description("Test for handling negative senior tickets")]
        public void When_Negative1Senior_Expect_12500()
        {
            //Arrange
            TicketPriceController ticketPriceController = new();
            
            //Act
            var seniorTicketCost = ticketPriceController.Senior(-2, "senior");
            
            //Assert
            Assert.AreEqual(-1m,seniorTicketCost);
        }
    }

    [TestFixture(Author = "Mark Christison"), Description("Tests for Senior"), Category("Student")]
    public class Student
    {
        [Test, Description("Test for Standard input, 1 Student")]
        public void When_1Student_Expect_Cost1250()
        {
            //Arrange
            TicketPriceController ticketPriceController = new();
            
            //Act
            var studentTicketCost = ticketPriceController.Student(1, "student");
            
            //Assert
            Assert.AreEqual(14m, studentTicketCost);
        }
        [Test, Description("Test for multiple Student tickets")]
        public void When_7Students_Expect_Cost98()
        {
            //Arrange
            TicketPriceController ticketPriceController = new();
            
            //Act
            var studentTicketCost = ticketPriceController.Student(7, "student");
            
            //Assert
            Assert.AreEqual(98m, studentTicketCost);
        }
        [Test, Description("Test for negative Student tickets")]
        public void When_Negative10Students_Expect_Negative1()
        {
            //Arrange
            TicketPriceController ticketPriceController = new();
            
            //Act
            var studentTicketCost = ticketPriceController.Student(-10, "student");
            
            //Assert
            Assert.AreEqual(-1m, studentTicketCost);
        }
        [Test, Description("Test for family ticket")]
        public void When_1Family_Expect_Negative1()
        {
            //Arrange
            TicketPriceController ticketPriceController = new();
            
            //Act
            var studentTicketCost = ticketPriceController.Student(1, "family");
            
            //Assert
            Assert.AreEqual(-1m, studentTicketCost);
        }
        [Test, Description("Test for adult ticket")]
        public void When_1Adult_Expect_Negative1()
        {
            //Arrange
            TicketPriceController ticketPriceController = new();
            
            //Act
            var studentTicketCost = ticketPriceController.Student(1, "adult");
            
            //Assert
            Assert.AreEqual(-1m, studentTicketCost);
        }
        [Test, Description("Test for senior ticket")]
        public void When_1Senior_Expect_Negative1()
        {
            //Arrange
            TicketPriceController ticketPriceController = new();
            
            //Act
            var studentTicketCost = ticketPriceController.Student(1, "senior");
            
            //Assert
            Assert.AreEqual(-1m, studentTicketCost);
        }
    }

    [TestFixture(Author = "Mark Christison"), Description("Tests for Family Pass"), Category("FamilyPass")]
    public class FamilyPass
    {
        [Test, Description("Test for family ticket, 2 Adults 2 Children cost $46")]
        public void When_1FamilyPass2Adult2Children_Expect_Cost4600()
        {
            //Arrange
            TicketPriceController ticketPriceController = new();
            
            //Act
            var familyPassTicketCost = ticketPriceController.Family_Pass(1, 2, 2);
            
            //Assert
            Assert.AreEqual(46.00m, familyPassTicketCost);
            Assert.NotNull(familyPassTicketCost);
            Assert.IsInstanceOf<decimal>(familyPassTicketCost);
            Assert.IsNotNull(familyPassTicketCost);
        }
        [Test, Description("Test for family ticket, 1 Adults 3 Children cost $46")]
        public void When_1FamilyPass1Adult3Children_Expect_Cost4600()
        {
            //Arrange
            TicketPriceController ticketPriceController = new();
            
            //Act
            var familyPassTicketCost = ticketPriceController.Family_Pass(1, 1, 3);
            
            //Assert
            Assert.AreEqual(46.00m, familyPassTicketCost);
            Assert.NotNull(familyPassTicketCost);
            Assert.IsInstanceOf<decimal>(familyPassTicketCost);
            Assert.IsNotNull(familyPassTicketCost);
        }
        [Test, Description("1 Family pass 3 Adults 1 Child should return -1")]
        public void When_1FamilyPass3Adult1Child_Expect_Negative1()
        {
            //Arrange
            TicketPriceController ticketPriceController = new();
            
            //Act
            var familyPassTicketCost = ticketPriceController.Family_Pass(1, 3, 1);
            
            //Assert
            Assert.AreEqual(-1m, familyPassTicketCost);
            Assert.NotNull(familyPassTicketCost);
            Assert.IsNotNull(familyPassTicketCost);
        }
        [Test, Description("1 Family pass 0 Adults 4 Children should return -1")]
        public void When_1FamilyPass0Adult4Child_Expect_Negative1()
        {
            //Arrange
            TicketPriceController ticketPriceController = new();
            
            //Act
            var familyPassTicketCost = ticketPriceController.Family_Pass(1, 0, 4);
            
            //Assert
            Assert.AreEqual(-1m, familyPassTicketCost);
        }
        [Test, Description("1 Family pass 4 Adults 0 Children should return -1")]
        public void When_1FamilyPass4Adult0Child_Expect_Negative1()
        {
            //Arrange
            TicketPriceController ticketPriceController = new();
            
            //Act
            var familyPassTicketCost = ticketPriceController.Family_Pass(1, 4, 0);
            
            //Assert
            Assert.AreEqual(-1m, familyPassTicketCost);
        }
        [Test, Description("10 Family pass 20 Adults 20 Children should return -1")]
        public void When_10FamilyPass20Adult20Child_Expect_Negative1()
        {
            //Arrange
            TicketPriceController ticketPriceController = new();
            
            //Act
            var familyPassTicketCost = ticketPriceController.Family_Pass(10, 20, 20);
            
            //Assert
            Assert.AreEqual(-1m, familyPassTicketCost);
        }
        [Test, Description("Negative numbers are handled, should return -1")]
        public void When_Negative1FamilyPass2Adult2Child_Expect_Negative1()
        {
            //Arrange
            TicketPriceController ticketPriceController = new();
            
            //Act
            var familyPassTicketCost = ticketPriceController.Family_Pass(-1, 2, 2);
            
            //Assert
            Assert.AreEqual(-1m, familyPassTicketCost);
        }
    }

    [TestFixture(Author = "Mark Christison"), Description("Tests for Chick Flick Thursday"), Category("ChickFlickThursday")]
    public class ChickFlickThursday
    {
        [Test, Description("Standard Chick Flick Thursday, 1 Adult on Thursday cost $21.50")]
        public void When_1AdultThursday_Expect_Cost2150()
        {
            //Arrange
            TicketPriceController ticketPriceController = new();
            
            //Act
            var chickFlickThursdayCost = ticketPriceController.Chick_Flick_Thursday(1, "adult", "thursday");
            
            //Assert
            Assert.AreEqual(21.50m, chickFlickThursdayCost);
            Assert.NotNull(chickFlickThursdayCost);
            Assert.IsInstanceOf<decimal>(chickFlickThursdayCost);
            Assert.IsNotNull(chickFlickThursdayCost);
        }
        [Test, Description("3 Adults on Thursday cost $63.50")]
        public void When_1AdultThursday_Expect_Cost6350()
        {
            //Arrange
            TicketPriceController ticketPriceController = new();
            
            //Act
            var chickFlickThursdayCost = ticketPriceController.Chick_Flick_Thursday(3, "adult", "thursday");
            
            //Assert
            Assert.AreEqual(64.50m, chickFlickThursdayCost);
        }
        [Test, Description("1 Adult on Wednesday, returns -1")]
        public void When_1AdultWednesday_Expect_Negative1()
        {
            //Arrange
            TicketPriceController ticketPriceController = new();
            
            //Act
            var chickFlickThursdayCost = ticketPriceController.Chick_Flick_Thursday(1, "adult", "wednesday");
            
            //Assert
            Assert.AreEqual(-1m, chickFlickThursdayCost);
        }
        [Test, Description("1 Child on Thursday, returns -1")]
        public void When_1ChildThursday_Expect_Negative1()
        {
            //Arrange
            TicketPriceController ticketPriceController = new();
            
            //Act
            var chickFlickThursdayCost = ticketPriceController.Chick_Flick_Thursday(1, "child", "thursday");
            
            //Assert
            Assert.AreEqual(-1m, chickFlickThursdayCost);
        }
        [Test, Description("1 Student on Thursday, returns -1")]
        public void When_1StudentThursday_Expect_Negative1()
        {
            //Arrange
            TicketPriceController ticketPriceController = new();
            
            //Act
            var chickFlickThursdayCost = ticketPriceController.Chick_Flick_Thursday(1, "student", "thursday");
            
            //Assert
            Assert.AreEqual(-1m, chickFlickThursdayCost);
        }
        [Test, Description("1 @du17 handles random strings, returns -1")]
        public void When_1RandomStringThursday_Expect_Negative1()
        {
            //Arrange
            TicketPriceController ticketPriceController = new();
            
            //Act
            var chickFlickThursdayCost = ticketPriceController.Chick_Flick_Thursday(1, "@du17", "thursday");
            
            //Assert
            Assert.AreEqual(-1m, chickFlickThursdayCost);
        }
    }

    [TestFixture(Author = "Mark Christison"), Description("Tests for Kids Careers"), Category("KidsCareers")]
    public class KidsCareers
    {
        [Test, Description("Standard Kid Career, 1 Ticket on Wednesday on a holiday cost $12")]
        public void When_1CareerWednesdayNotHoliday_Expect_Cost12()
        {
            //Arrange
            TicketPriceController ticketPriceController = new();
            
            //Act
            var kidsCareersCost = ticketPriceController.Kids_Careers(1, "wednesday", false);
            
            //Assert
            Assert.AreEqual(12.00M, kidsCareersCost);
        }
        [Test, Description("4 Tickets on Wednesday on a holiday cost $48")]
        public void When_4CareerWednesdayHoliday_Expect_Cost48()
        {
            //Arrange
            TicketPriceController ticketPriceController = new();
            
            //Act
            var kidsCareersCost = ticketPriceController.Kids_Careers(4, "wednesday", false);
            
            //Assert
            Assert.AreEqual(48m, kidsCareersCost);
        }
        [Test, Description("1 Tickets on Tuesday on a holiday, returns 48")]
        public void When_1CareerTuesdayHoliday_Expect_Negative1()
        {
            //Arrange
            TicketPriceController ticketPriceController = new();
            
            //Act
            var kidsCareersCost = ticketPriceController.Kids_Careers(1, "tuesday", true);
            
            //Assert
            Assert.AreEqual(-1m, kidsCareersCost);
        }
        [Test, Description("-1 Tickets on Wednesday on a holiday, returns -1")]
        public void When_Negative1CareerWednesdayHoliday_Expect_Negative1()
        {
            //Arrange
            TicketPriceController ticketPriceController = new();
            
            //Act
            var kidsCareersCost = ticketPriceController.Kids_Careers(-1, "wednesday", true);
            
            //Assert
            Assert.AreEqual(-1m, kidsCareersCost);
        }
        [Test, Description("1 Tickets on Wednesday a holiday, returns -1")]
        public void When_1CareerWednesdayHoliday_Expect_Negative1()
        {
            //Arrange
            TicketPriceController ticketPriceController = new();
            
            //Act
            var kidsCareersCost = ticketPriceController.Kids_Careers(1, "wednesday", true);
            
            //Assert
            Assert.AreEqual(-1m, kidsCareersCost);
        }
        [Test, Description("1 Tickets on ‘RandomString’ on a holiday, returns -1")]
        public void When_1CareerRandomStringHoliday_Expect_Negative1()
        {
            //Arrange
            TicketPriceController ticketPriceController = new();
            
            //Act
            var kidsCareersCost = ticketPriceController.Kids_Careers(1, "RandomString", true);
            
            //Assert
            Assert.AreEqual(-1m, kidsCareersCost);
        }
    }
}