using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NLPImplementations;
using Moq;
using System.Collections.Generic;
using System.IO;

namespace NLPTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void NLPWrapper_CurrentDirectory_IsPreserved()
        {
            // arrange
            NLPWrapper sut = new NLPWrapper();
            string test = "This is a test.";
            string startingDirectory = Directory.GetCurrentDirectory();

            // act
            List<string> testResults = sut.analyzeText(test);

            // assert
            Assert.AreEqual(startingDirectory, Directory.GetCurrentDirectory());

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NLPWrapper_NullParameter_ThrowsException()
        {
            // Arrange
            NLPWrapper sut = new NLPWrapper();

            // Act
            sut.analyzeText(null);

            // Assert

        }

        [TestMethod]
        public void NLPWrapper_GoodInput_ReturnsNonEmptyList()
        {
            // arrange
            NLPWrapper sut = new NLPWrapper();
            string test = "This is a test.";

            // act
            List<string> testResults = sut.analyzeText(test);

            // assert
            Assert.IsNotNull(testResults);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NLPWrapper_EmptyInput_ReturnsNull()
        {
            // arrange
            NLPWrapper sut = new NLPWrapper();
            string test = "";

            // act
            List<String> testResults = sut.analyzeText(test);

        }

    }
}
