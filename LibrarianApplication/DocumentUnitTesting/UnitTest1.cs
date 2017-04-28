using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DocumentImplementation;
using NLPImplementations;
using System.IO;

namespace DocumentUnitTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Document_TargetPathProperty_SetsGets ()
        {
            // Arrange
            Document sut = new Document("test", @"c:\", new FeatureVector("test"));

            // Act
            sut.TargetPath = @"c:\stuff\things\blah";

            // Assert
            Assert.AreEqual(@"c:\stuff\things\blah", sut.TargetPath);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Document_getTextEmptyPath_ThrowsException()
        {
            // Arrange
            Document sut = new Document("test", "", new FeatureVector("test"));
            // Act
            sut.getText();
        }

        [TestMethod]
        [ExpectedException(typeof(IOException))]
        public void Document_getText_InvalidFile_ThrowsException()
        {
            // Arrange
            Document sut = new Document("test", @"c:\zzzzzzzzzzzzzzzzzzzzzzzzzzzzz.txt", new FeatureVector("test"));
            // Act
            sut.getText();
        }


    }
}
