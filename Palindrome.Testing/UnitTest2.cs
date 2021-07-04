using System;
using Xunit;

namespace Palindrome.Testing
{
    public class UnitTest2
    {
        [Theory]
        [InlineData("NasCar")] //check fail

        public void Test2(string test)
        {
          var pal = new Program();
          var testWord = test;

          Assert.True(!Program.CheckPalindrome(testWord));

        }
    }
}
