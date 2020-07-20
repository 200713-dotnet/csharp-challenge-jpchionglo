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
        [InlineData("NasCar")] //check fail
        public void Test1(string test)
        {
          var pal = new Program();
          var testWord = test;

          Assert.True(Program.CheckPalindrome(testWord));
          //Expect 3 pass, 1 fail

        }
    }
}
