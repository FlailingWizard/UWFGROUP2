using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DocumentImplementation;
using NLPInterfaces;
using NLPImplementations;

namespace DocumentUnitTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DocumentAdditionTesting()
        {
           /* //Arrange
            IFeatureVector vector1 = new FeatureVector("We are testing this here.");
            vector1.process();
            string fileName = "test.txt";
            string sourcePath = @"C:\Users\Public\TestFolder\test.txt";
            string targetPath = @"C:\Users\Public\TestFolder\Tester";
            Document sut = new Document(fileName,targetPath,vector1);
            //Act
            String result = sut.storeDoc(sourcePath, targetPath);
            //Assert
            Assert.AreEqual(@"C:\Users\Public\TestFolder\Tester", result);
            */
        }
        [TestMethod]
        public void DocumentDeletionTesting()
        {
          /*  //Arrange
            IFeatureVector vector1 = new FeatureVector("We are testing this here.");
            vector1.process();
            string fileName = "test.txt";
            string targetPath = @"C:\Users\Public\TestFolder\Tester\test.txt";
            Document sut = new Document("test", targetPath, vector1);
            //Act
            String result = sut.delete();
            //Assert
            Assert.AreEqual(@"C:\Users\Public\TestFolder\Tester\test.txt", result);
            */
        }
    }
}
