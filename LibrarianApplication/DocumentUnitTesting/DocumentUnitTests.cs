using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DocumentImplementation;

namespace DocumentUnitTesting
{
    [TestClass]
    public class DocumentUnitTests
    {
        [TestMethod]
        public void DocumentAdditionTesting()
        {
            //Arrange
            string fileName = "test.txt";
            string sourcePath = @"C:\Users\Public\TestFolder";
            string targetPath = @"C:\Users\Public\TestFolder\Tester";
            DocumentCreation sut = new DocumentCreation();
            
            //Act

            //String result = sut.storeDoc(fileName, sourcePath, targetPath);
            //Assert
            //Assert.AreEqual(@"C:\Users\Public\TestFolder\Tester", result);
        }
        [TestMethod]
        public void DocumentDeletionTesting()
        {
            //Arrange
            string targetPath = @"C:\Users\Public\TestFolder\Tester\test.txt";
            DocumentDeletion sut = new DocumentDeletion();
            //Act
            String result = sut.deleteDoc(targetPath);
            //Assert
            Assert.AreEqual(@"C:\Users\Public\TestFolder\Tester\test.txt", result);
        }
    }
}
