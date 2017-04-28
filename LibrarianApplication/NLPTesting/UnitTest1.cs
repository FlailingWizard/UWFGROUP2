using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NLPImplementations;
using Moq;
using System.Collections.Generic;

namespace NLPTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void testingProcessMethod()
        {
           /* //Arrange
            FeatureVector vector1 = new FeatureVector("We are testing this here.");
            vector1.process();
            Mock<FeatureVector> vector = new Mock<FeatureVector>("We are testing this here.");
            vector.Setup(p => p.process()).Returns(vector1.getScalars());

            FeatureVector sut = new FeatureVector("We are testing this here.");
            //Act
            List<double> result = sut.process();
            //Assert
            Assert.AreEqual(vector1.getScalars(), result);
            */
        }
    }
}
