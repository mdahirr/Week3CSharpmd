using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace AdvancedNUnit
{
    public class CalculatorTests
    {
        [SetUp]
        public void Setup() { }

        [TestCaseSource(nameof(AddCases))]
        [Category("Error Path")]
        public void Add_Always_ReturnsExpectedResult(int x, int y, int expectedResult)
        {
            // Arrange
            var subject = new Calculator { Num1 = 2, Num2 = 4 };
            // Act
            var result = subject.Add();
            // Assert
            Assert.That(result, Is.EqualTo(expectedResult), "optional failure message");
        }

        private static object[] AddCases = {
                new int[] {2, 4, 6},
                new int[] {-2, 3, 1}
        };

        [Test]
        [Category("Happy Path")]
        public void DivisibleBy3_GivenInputOf6_ReturnsTrue()
        {
            // Arrange
            var subject = new Calculator { Num1 = 6 };



            // Act
            var result = subject.DivisibleBy3();



            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [Category("Happy Path")]
        public void DivisibleBy3_GivenInputOf7_ReturnsFalse()
        {
            // Arrange
            var subject = new Calculator { Num1 = 7 };



            // Act
            var result = subject.DivisibleBy3();



            // Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [Category("Happy Path")]
        public void ToString_ContainsTheStringCalculator()
        {
            // Arrange
            Calculator subject = new Calculator();



            // Act
            var result = subject.ToString();



            // Assert
            Assert.That(result, Does.Contain("Calculator"));
            Assert.That(result, Is.EqualTo("AdvancedNUnit.Calculator"));
            Assert.That(result, Is.EqualTo("advancednunit.calculator").IgnoreCase);
            Assert.That(result, Does.Not.Contain("Potato"));
            Assert.That(result, Does.StartWith("A"));
            Assert.That(result, Has.Length.EqualTo(24));
            Assert.That(result, Does.Not.Empty);
        }

        [Test]
        [Category("Happy Path")]
        public void CollectionContraintsExercise()
        {
            var trainers = new string[] { "Laura", "Joe", "Phil", "Neil", "Martin", "Cathy" };
            /*
            Add assertions for the following
            The array's length is 6
            There are exactly 2 members that end with "l"
            The case insensitive string "cathy" is contained in the array
            There are exactly 3 members that contain "i"
            */

            Assert.That(trainers, Has.Length.EqualTo(6));
            Assert.That(trainers, Has.Exactly(2).Items.EndWith("l"));
            Assert.That(trainers, Does.Contain("Cathy").IgnoreCase);
            Assert.That(trainers, Has.Exactly(3).Items.Contain("i"));
        }

        [Test]
        public void RangeContraintsExercise()
        {
            var nums = new int[] { 4, 2, 6, 7, 1, 9 };

            /*
             - Add assertions for the following
             - The number `8` is in the range 1 to 10
             - `nums` is all in the range 1 to 10
             - `nums` has exactly 3 members in the range 1 to 5
             */

            Assert.That(8, Is.InRange(1, 10));
            Assert.That(nums, Is.All.InRange(1, 10));
            Assert.That(nums, Has.Exactly(3).Items.InRange(1, 5));
        }


    }
    
}