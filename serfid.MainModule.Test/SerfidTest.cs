using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using serfid.Interfaces.Filter;
using serfid.Interfaces.Listener;
using serfid.Interfaces.MainModule;
using serfid.Interfaces.Storage;

namespace serfid.MainModule.Test
{
    [TestClass]
    public class SerfidTest
    {
        #region Attributes

        private ISerfid mainModule;
        private Mock<IListener> listenerMock;
        private Mock<IFilter> filterMock;
        private Mock<IStorage> storageMock;

        #endregion

        #region Initialize

        [TestInitialize]
        public void Initialize()
        {
            this.listenerMock = new Mock<IListener>();
            this.filterMock = new Mock<IFilter>();
            this.storageMock = new Mock<IStorage>();
            this.mainModule = new SerfidCore(this.listenerMock.Object, this.filterMock.Object, this.storageMock.Object);
        }

        #endregion

        #region Cleanup

        [TestCleanup]
        public void Cleanup()
        {
            this.mainModule = null;
            this.listenerMock = null;
            this.filterMock = null;
            this.storageMock = null;
        }

        #endregion

        #region Test methods

        [TestMethod]
        public void LoadApplication()
        {
            //Arrange
            this.listenerMock.Setup(l => l.Start());
            this.filterMock.Setup(l => l.Start());
            this.storageMock.Setup(l => l.Start());

            //Act
            this.mainModule.AppStart();

            //Assert
            this.listenerMock.VerifyAll();
            this.filterMock.VerifyAll();
            this.storageMock.VerifyAll();
        }

        #endregion
    }
}
