using System;
using ValidParentheses;
using Xunit;

namespace ValidParenthesesTests
{
    public class ParenthesesTests
    {
        [Fact]
        public void ValidParenthesesMethod_CorrectTest()
        {
            //Arrange
            Parentheses parentheses = new Parentheses();
            string brks = "()";
            bool expected = true;
            
            //Act
            var actual = parentheses.ValidParentheses(brks);
            
            //Assert
            Assert.Equal(expected, actual);
        }
        
        [Theory]
        [InlineData("()", true)]
        [InlineData("(())", true)]
        [InlineData("())", false)]
        [InlineData(")(()))", false)]
        [InlineData("", false)]
        [InlineData("abcd", false)]
        [InlineData("(dsds)", true)]
        [InlineData("(dsds", false)]
        [InlineData("((dsds))([])", true)]
        [InlineData("(", false)]
        [InlineData("(12(34)56)", true)]
        [InlineData("(())((()())())(())((()())())(())((()())())(())((()())())(())((()())())(())((()())())(())((()())())()", true)]
        public void ValidParenthesesMethod_TheoryTests(string str, bool expected)
        {
            //Arrange
            Parentheses parentheses = new Parentheses();

            //Act
            var actual = parentheses.ValidParentheses(str);
            
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}