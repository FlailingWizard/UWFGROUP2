using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CollectionImplementation;
using NLPInterfaces;
using NLPImplementations;

namespace CollectionsUnitTesting
{
    /// <summary>
    /// Summary description for CollectionUnitTests
    /// Collection addition and deletion tests.
    /// </summary>
    [TestClass]
    public class UnitTest1
    {


        [TestMethod]
        public void CollectionAdditionTesting()
        {
            //Arrange
            IFeatureVector vector1 = new FeatureVector("We are testing this here.");
            vector1.process();
            String TargetPath = @"C:\Users\Public\TestFolder";
            DocumentCollection sut = new DocumentCollection("SubDir", vector1, TargetPath);
            //Act
            String result = sut.getPath();
            //Assert
            Assert.AreEqual(@"C:\Users\Public\TestFolder\SubDir", result);
        }
        [TestMethod]
        public void CollectionDeletionTesting()
        {
            //Arrange
            IFeatureVector vector1 = new FeatureVector("We are testing this here.");
            vector1.process();
            String TargetPath = @"C:\Users\Public\TestFolder\SubDir";
            DocumentCollection sut = new DocumentCollection("testCol", vector1, TargetPath);
            //Act
            String result = sut.delete();
            //Assert
            Assert.AreEqual(@"C:\Users\Public\TestFolder\SubDir", result);
        }

    }
}