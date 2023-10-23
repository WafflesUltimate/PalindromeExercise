using System;
using Xunit;
using System.Linq;
using PalindromeExercise;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("madam", true)]
        [InlineData("hello", false)]
        public void IsWordPalindromeTest(string input, bool expected)
        {
          WordSmith wordSmith = new WordSmith(); 

          var actual = wordSmith.IsAPalindrome(input);  

          Assert.Equal(expected, actual);

        }
    }
}
