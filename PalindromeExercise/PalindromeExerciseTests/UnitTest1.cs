using System;
using Xunit;
using PalindromeExercise;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("wow", true)]
        [InlineData("racecar", true)]
        [InlineData("people", false)]
        public void PalidromeTest(string word, bool expected)
        {
            var test = new WordSmith();
            var actual = test.isAPalidrome(word);
            Assert.Equal(expected, actual);
        } 
    }
}
