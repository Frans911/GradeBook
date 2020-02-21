using System;
using Xunit;
using GradeBook;

namespace XUnitGradeBook
{
    public class GradeBookTest
    {
        [Fact]
        public void TestingScoresAverage()
        {
            /*
            //Arrange
            var x = 5;
            var y = 2;
            var expected = 7;
            //Actual
            var actual = x + y;
            //Assert
            Assert.Equal(expected,actual);
            */

            //Arrange 
            Score score = new Score();
            score.Scores.Add(1);
            score.Scores.Add(2);
            score.Scores.Add(3);
            score.Scores.Add(4);
            score.Scores.Add(5);
            //Actual
            var results = score.GetStatistics();

            //Assert
            Assert.Equal(3, score.GetStatistics().Average, 1);
        }
        [Fact]
        public void TestingScoresHighest()
        {

            //Arrange 
            Score score = new Score();
            score.Scores.Add(1);
            score.Scores.Add(2);
            score.Scores.Add(3);
            score.Scores.Add(4);
            score.Scores.Add(5);
            //Actual
            var results = score.GetStatistics();

            //Assert 
            Assert.Equal(5, score.GetStatistics().Highest, 1);
        }
        [Fact]
        public void TestingScoresLowest()
        {

            //Arrange 
            Score score = new Score();
            score.Scores.Add(1);
            score.Scores.Add(2);
            score.Scores.Add(3);
            score.Scores.Add(4);
            score.Scores.Add(5);
            //Actual
            var results = score.GetStatistics();

            //Assert 
            Assert.Equal(1, score.GetStatistics().Lowest, 1);
        }
    }
}
