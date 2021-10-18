using System.Collections.Generic;
using NUnit.Framework;

namespace TestsEdit
{
    public class BowlingCalculatorShould
    {
        private BowlingCalculator _bc;
        [SetUp]
        public void Setup()
        {
            _bc = new BowlingCalculator();
        }
        
        [Test]
        public void CalculateScoreWithStrikes()
        {
            //Arrange
            List<int> throws = new List<int>();
            for (int i = 0; i < 12; i++)
            {
                
                throws.Add(12);
            }
            //Act
            int result = _bc.CalculateScore(throws);
            //Assert
            Assert.AreEqual(300, result);
        }
        
        [Test]
        public void CalculateScoreWithSpares()
        {
            //Arrange
            List<int> throws = new List<int>();
            for (int i = 0; i < 11; i++)
            {
                
                throws.Add(11);
            }
            //Act
            int result = _bc.CalculateScore(throws);
            //Assert
            Assert.AreEqual(200, result);
        }

        [Test]
        public void ReturnLowestScore()
        {
            //Arrange
            List<int> throws = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                
                throws.Add(0);
            }
            //Act
            int result = _bc.CalculateScore(throws);
            //Assert
            Assert.AreEqual(0, result);
        }
        
        [Test]
        public void CalculateScoreWithoutSparesOrStrikes()
        {
            //Arrange
            List<int> throws = new List<int>
            {
                5, 4, 8, 1, 6, 0, 0, 5, 3, 2
            };
            //Act
            int result = _bc.CalculateScore(throws);
            //Assert
            Assert.AreEqual(34, result);
        }
        
        [Test]
        public void CalculateScoreComplete()
        {
            //Arrange
            List<int> throws = new List<int>
            {
                5, 4, 10, 1, 12, 0, 11, 5, 12, 2, 3
            };
            //Act
            int result = _bc.CalculateScore(throws);
            //Assert
            Assert.AreEqual(77, result);
        }
    }
}
