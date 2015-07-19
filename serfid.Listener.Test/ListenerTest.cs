using System;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using serfid.Interfaces.Enumerations;
using serfid.Interfaces.Infraestructure;
using serfid.Interfaces.Listener;

namespace serfid.Listener.Test
{
    [TestClass]
    public class ListenerTest
    {
        #region Attributes

        private Mock<ITranslator> translatorMock;
        private IListener listener;

        #endregion

        #region Initialize

        [TestInitialize]
        public void Initialize()
        {
            this.translatorMock = new Mock<ITranslator>();
            this.listener = new Listener(translatorMock.Object);
        }

        #endregion

        #region Cleanup

        [TestCleanup]
        public void Cleanup()
        {
            this.listener = null;
            this.translatorMock = null;
        }

        #endregion

        #region Test methods

        [TestMethod]
        public void StartListener()
        {
            //Arrange

            //Act
            ModuleStatus result = this.listener.start();

            //Assert
            Assert.AreEqual(ModuleStatus.success, result);
        }

        [TestMethod]
        public void CanReading()
        {
            //Arrange
            string reading = "readingtest654654687451";

            //Act
            ReadingResult result = this.listener.Read(reading);

            //Assert
            Assert.AreEqual(ReadingResult.Ok, result);
        }

        [TestMethod]
        public void ManageEmptyReading()
        {
            //Arrange
            string reading = string.Empty;

            //Act
            ReadingResult result = this.listener.Read(reading);

            //Assert
            Assert.AreEqual(ReadingResult.Empty, result);
        }

        [TestMethod]
        public void ManageNullReading()
        {
            //Arrange
            string reading = null;

            //Act
            ReadingResult result = this.listener.Read(reading);

            //Assert
            Assert.AreEqual(ReadingResult.Null, result);
        }

        [TestMethod]
        public void TranslateReading()
        {
            //Arrange
            byte[] reading = Encoding.UTF8.GetBytes("Hello World!");
            string encodeReading = Convert.ToBase64String(reading);
            this.translatorMock.Setup(t => t.TranslateReading(encodeReading));

            //Act
            this.listener.Read(encodeReading);

            //Assert
            this.translatorMock.VerifyAll();
        }

        #endregion
    }
}
