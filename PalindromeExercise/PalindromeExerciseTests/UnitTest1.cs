using System;
using Xunit;
using System.Collections.Generic;
using PalindromeExercise;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("civic", true)]
        [InlineData("blooper", false)]
        [InlineData("Racecar", true)]
        public void IsAPalindrome(string answer, bool expected)
        {
            //Arrange
             var wrdSmth = new WordSmith();

            //Act
            var actual = wrdSmth.IsAPalindrome(answer);

            Assert.Equal(expected, actual);



        }
    }
}
