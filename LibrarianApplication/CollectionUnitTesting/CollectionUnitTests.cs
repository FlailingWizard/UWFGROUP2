using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using CollectionInterfaces;
using CollectionImplementation;

namespace CollectionUnitTesting
{
    /// <summary>
    /// Summary description for CollectionUnitTests
    /// Collection addition and deletion tests.
    /// </summary>
    [TestClass]
    public class CollectionUnitTests
    {


        [TestMethod]
        public void CollectionAdditionTesting()
        {
            //Arrange
            String TargetPath = @"C:\Users\Public\TestFolder\SubDir";
            CollectionCreation sut = new CollectionCreation();
            //Act
            String result = sut.createColl(TargetPath);
            //Assert
            Assert.AreEqual(@"C:\Users\Public\TestFolder\SubDir", result);
        }
        [TestMethod]
        public void CollectionDeletionTesting()
        {
            //Arrange
            String TargetPath = @"C:\Users\Public\TestFolder\SubDir";
            CollectionDeletion sut = new CollectionDeletion();
            //Act
            String result = sut.deleteCollection(TargetPath);
            //Assert
            Assert.AreEqual(@"C:\Users\Public\TestFolder\SubDir", result);
        }

    }
}
