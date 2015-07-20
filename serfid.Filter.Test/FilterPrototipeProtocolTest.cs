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
            this.storageMock = new Mock<IStorage>();
            this.filterStandartProtocol = new FilterPrototipeProtocol(this.storageMock.Object);
        }

        #endregion

        #region Cleanup

        [TestCleanup]
        public void Cleanup()
        {
            this.filterStandartProtocol = null;
        }

        #endregion

        #region Test methods

        [TestMethod]
        public void StartFilter()
        {
            //Arrange

            //Act
            ModuleStatus result = this.filterStandartProtocol.Start();

            //Assert
            Assert.AreEqual(ModuleStatus.success, result);
        }

        [TestMethod]
        public void TramitValidReading()
        {
            //Arrange
            string validReading = "01203D2A01916E8B8719BAE03C";
            this.storageMock.Setup(s => s.Save(It.IsAny<ReadingInfo>()));

            //Act
            FilterResult result = this.filterStandartProtocol.Tramit(validReading);

            //Assert
            Assert.AreEqual(FilterResult.Acepted, result);
            this.storageMock.VerifyAll();
        }

        [TestMethod]
        public void DiscardInvalidLenghtReading()
        {
            //Arrange
            string invalidReading = "019BAE03";

            //Act
            FilterResult result = this.filterStandartProtocol.Tramit(invalidReading);

            //Assert
            Assert.AreEqual(FilterResult.Discard, result);
        }

        [TestMethod]
        public void DiscardInvalidFieldInReading()
        {
            //Arrange
            string invalidReading = "01203D2A01xxxxxx8719BAE03C";

            //Act
            FilterResult result = this.filterStandartProtocol.Tramit(invalidReading);

            //Assert
            Assert.AreEqual(FilterResult.Discard, result);
        }

        #endregion
    }
}
