//Importing NUnit framework for unit testing
using NUnit.Framework; // Importing NUnit framework for unit testing
using Demo__MathLibrary_Testing_using_NUnit; // Importing the namespace of the class to be tested

namespace MathLibrary.Tests
{
    public class calculatorTests
    {
        private Calculator calculator;// Instance of the Calculator class to be tested 
        [SetUp] // This attribute indicates that this method will run before each test in the class
        public void Setup()
        {
           calculator = new Calculator(); // Allocating memory using 'new'
        }

        [Test] // This attribute indicates that this method is a test method
        public void Add_ShouldReturnCorrectSum()
        {
            //Assert.Pass(); for passing the flow of execution
            int result = calculator.Add(2, 3); // Calling the Add method of the Calculator class
            Assert.That(result, Is.EqualTo(5)); // Asserting that the result is equal to 5
        }

        [Test]
        public void Subtract_ShouldReturnCorrectDifference()
        {
            //Assert.Pass();
            int result = calculator.Subtract(5, 3); // Calling the Subtract method of the Calculator class
            Assert.That(result, Is.EqualTo(2)); // Asserting that the result is equal to 2
        }
    }
}