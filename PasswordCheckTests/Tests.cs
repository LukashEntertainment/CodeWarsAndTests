using System;
using Xunit;
using PasswordCheck;

namespace PasswordCheckTests
{
    public class Tests
    {
        [Fact]
        public void Test_DecodePass_Correct()
        {
            //Arrange
            string[] arrPass = {"password123", "admin", "admin1"};
            string bin =
                "01110000 01100001 01110011 01110011 01110111 01101111 01110010 01100100 00110001 00110010 00110011";
            string expected = "password123";

            //Act
            PasswordChecker passwordChecker = new PasswordChecker();
            string actual = passwordChecker.DecodePass(arrPass, bin);

            //Assert
            Assert.Equal(expected, actual);
        }
        
        [Fact]
        public void Test_DecodePass_Incorrect()
        {
            //Arrange
            string[] arrPass = {"password123", "admin", "admin1"};
            string bin =
                "01110000 01100001 01110011 01110011 01110111 01101111 01110010 01100100 00110001 00110010 00110011";
            //string expected = "password123";

            //Act
            PasswordChecker passwordChecker = new PasswordChecker();
            string actual = passwordChecker.DecodePass(arrPass, bin);

            //Assert
            Assert.Equal(null, actual);
        }
        
        [Theory]
        [InlineData(new string[] {"password123", "admin", "admin1"}, 
            "01110000 01100001 01110011 01110011 01110111 01101111 01110010 01100100 00110001 00110010 00110011", "password123")]
        [InlineData(new string[] {"password321", "admin", "admin1"}, 
            "01110000 01100001 01110011 01110011 01110111 01101111 01110010 01100100 00110001 00110010 00110011", null)]
        [InlineData(new string[] {"password456", "pass1", "test12"}, 
            "01110000 01100001 01110011 01110011 01110111 01101111 01110010 01100100 00110001 00110010 00110011", null)]
        public void Test_DecodePass(string[] arr, string binNum, string expected)
        {
            //Arrange

            //string expected = "password123";

            //Act
            PasswordChecker passwordChecker = new PasswordChecker();
            string actual = passwordChecker.DecodePass(arr, binNum);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}