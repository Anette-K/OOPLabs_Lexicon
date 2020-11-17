using System;
using Xunit;
using _7OOP_UnitTesting;

namespace UnitTestProject1
{
    public class DummyTests
    {
        [Fact]
        public void AttackedDummyLosesHealth()
        {
            //Arrange- set the variables
            Axe axe = new Axe(10, 10);
            Dummy dummy = new Dummy(10, 10);
            int health_expected = 0;

            //Act- invoke the method thats being tested
            axe.Attack(dummy);
            int health_actual = dummy.Health;

            //Assert- the actual test
            Assert.Equal(health_expected, health_actual);

        }

        [Fact]
        public void DeadDummyThrowsException()
        {
            //Arrange- set the variables
            Axe axe = new Axe(10, 10);
            Dummy dummy = new Dummy(0, 10);
            dummy.IsDead = true;

            //Act- invoke the method thats being tested
            //Assert- the actual test
            Assert.Throws<InvalidOperationException>(() => axe.Attack(dummy));
        }

        [Fact]
        public void DeadDummyGivesXP()
        {
            //Arrange- set the variables
            recievedXp = 0;
            Axe axe = new Axe(10, 10);
            Dummy dummy = new Dummy(10, 10);

            //      register with event
            dummy.GiveXP += Dummy_GiveXP;

            int xp_expected = 10;


            //Act- invoke the method thats being tested
            axe.Attack(dummy);

            int xp_actual = recievedXp;

            //Assert- the actual test
            Assert.Equal(xp_expected, xp_actual);

        }

        [Fact]
        public void AliveDummyGivesNoXP()
        {
            //Arrange- set the variables
            recievedXp = 0;
            Axe axe = new Axe(10, 9);
            Dummy dummy = new Dummy(10, 10);

            //      register with event
            dummy.GiveXP += Dummy_GiveXP;

            int xp_expected = 0;


            //Act- invoke the method thats being tested
            axe.Attack(dummy);

            int xp_actual = recievedXp;

            //Assert- the actual test
            Assert.Equal(xp_expected, xp_actual);
        }
        // Below used by xp-related tests. Needed for handling event 

        public static int recievedXp;
        internal static void Dummy_GiveXP(object sender, int givenXp)
        {
            recievedXp += givenXp;
        }
    }
}
