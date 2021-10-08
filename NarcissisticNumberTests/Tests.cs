using System;
using Xunit;
using NarcissisticNumber;

namespace NarcissisticNumberTests
{
    public class NarcissisticNumberCheckTests
    {
        [Fact]
        public void NarcissisticNumberCheck_CorrectTest()
        {
            //Arrange 
            NarcissisticNumberClass nn = new NarcissisticNumberClass();
            int value = 153;
            bool expected = true;
            
            //Act
            bool actual = nn.NarcissisticNumberCheck(value);
            
            //Assert
            Assert.Equal(expected, actual);
        }
        
        [Fact]
        public void NarcissisticNumberCheck_incorrectTest()
        {
            //Arrange 
            NarcissisticNumberClass nn = new NarcissisticNumberClass();
            int value = 1652;
            bool expected = false;
            
            //Act
            bool actual = nn.NarcissisticNumberCheck(value);
            
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}