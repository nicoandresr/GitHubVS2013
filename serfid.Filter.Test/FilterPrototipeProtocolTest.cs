using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using serfid.Interfaces.Enumerations;
using serfid.Interfaces.Filter;
using serfid.Interfaces.Storage;
using serfid.Interfaces.ValueObjects;

namespace serfid.Filter.Test
{
    [TestClass]
    public class FilterPrototipeProtocolTest
    {
        #region Attributes

        private IFilter filterStandartProtocol;
        private Mock<IStorage> storageMock;

        #endregion

        #region Initialize

        [TestInitialize]
        public void Initialize()
        {
            storageMock = new Mock<IStorage>();
            filterStandartProtocol = new FilterPrototipeProtocol(storageMock.Object);
        }

        #endregion

        #region Cleanup

        [TestCleanup]
        public void Cleanup()
        {
            filterStandartProtocol = null;
        }

        #endregion

        #region Test methods

        [TestMethod]
        public void StartFilter()
        {
            //Arrange

            //Act
            ModuleStatus result = filterStandartProtocol.Start();

            //Assert
            Assert.AreEqual(ModuleStatus.success, result);
        }

        [TestMethod]
        public void TramitValidReading()
        {
            //Arrange
            string validReading = "01203D2A01916E8B8719BAE03C";
            storageMock.Setup(s => s.SaveReading(It.IsAny<ReadingInfo>()));

            //Act
            FilterResult result = filterStandartProtocol.Tramit(validReading);

            //Assert
            Assert.AreEqual(FilterResult.Acepted, result);
            storageMock.VerifyAll();
        }

        [TestMethod]
        public void DiscardInvalidLenghtReading()
        {
            //Arrange
            string invalidReading = "019BAE03";

            //Act
            FilterResult result = filterStandartProtocol.Tramit(invalidReading);

            //Assert
            Assert.AreEqual(FilterResult.Discard, result);
        }

        [TestMethod]
        public void DiscardInvalidFieldInReading()
        {
            //Arrange
            string invalidReading = "01203D2A01xxxxxx8719BAE03C";

            //Act
            FilterResult result = filterStandartProtocol.Tramit(invalidReading);

            //Assert
            Assert.AreEqual(FilterResult.Discard, result);
        }

        #endregion
    }
}
