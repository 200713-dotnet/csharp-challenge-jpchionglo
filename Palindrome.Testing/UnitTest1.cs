using System;
using Xunit;

namespace Palindrome.Testing
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar")] //standard test
        [InlineData("abCDEEdcBa")] //check if case is ignored
        [InlineData("#de!ed#")] //check symbols
        [InlineData("abc32123cba")] //check alphanumeric

        public void Test1(string test)
        {
          var pal = new Program();
          var testWord = test;

          Assert.True(Program.CheckPalindrome(testWord));

        }
    }
}
