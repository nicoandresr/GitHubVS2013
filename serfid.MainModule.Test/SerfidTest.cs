using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using serfid.Interfaces.Filter;
using serfid.Interfaces.Listener;
using serfid.Interfaces.MainModule;
using serfid.Interfaces.Storage;
using serfid.Interfaces.User;

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
        private Mock<IUser> userMock;

        #endregion

        #region Initialize

        [TestInitialize]
        public void Initialize()
        {
            this.listenerMock = new Mock<IListener>();
            this.filterMock = new Mock<IFilter>();
            this.storageMock = new Mock<IStorage>();
            this.userMock = new Mock<IUser>();
            this.mainModule = new SerfidCore(this.listenerMock.Object, this.filterMock.Object, this.storageMock.Object, this.userMock.Object);
        }

        #endregion

        #region Cleanup

        [TestCleanup]
        public void Cleanup()
        {
            this.mainModule = null;
            this.listenerMock = null;
            this.filterMock = null;
            this.userMock = null;
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
            this.userMock.Setup(l => l.Start());

            //Act
            this.mainModule.AppStart();

            //Assert
            this.listenerMock.VerifyAll();
            this.filterMock.VerifyAll();
            this.storageMock.VerifyAll();
            this.userMock.VerifyAll();
        }

        [TestMethod]
        public void ReadWeft()
        {
            //Arrange
            this.listenerMock.Setup(l => l.Read(It.IsAny<string>()));

            //Act
            this.mainModule.ReadWeft("test weft");

            //Assert
            this.listenerMock.VerifyAll();
        }

        #endregion
    }
}
