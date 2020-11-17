using System;
using Xunit;
using _7OOP_UnitTesting;

namespace UnitTestProject1
{
    public class AxeTests
    {
        [Fact]
        public void AxeLoosesDurabilityAfterAttack()
        {
            //Arrange- set the variables
            Axe axe = new Axe(10, 10);
            Dummy dummy = new Dummy(10, 10);
            int expected = 9;

            //Act- invoke the method thats being tested
            axe.Attack(dummy);
            int actual = axe.DurabilityPoints;

            //Assert- the actual test
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AttackWithBrokenWeapon()
        {
            //Arrange- set the variables
            Axe axe = new Axe(0, 10);
            Dummy dummy = new Dummy(10, 10);
            int durability_expected = 0;

            //Act- invoke the method thats being tested
            axe.Attack(dummy);
            int durability_actual = axe.DurabilityPoints;

            //Assert- the actual test
            Assert.Equal(durability_expected, durability_actual);
        }

    }
}
