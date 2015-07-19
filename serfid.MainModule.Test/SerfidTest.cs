using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using serfid.Interfaces.Listener;
using serfid.Interfaces.MainModule;

namespace serfid.MainModule.Test
{
    [TestClass]
    public class SerfidTest
    {
        #region Attributes

        private ISerfid mainModule;
        private Mock<IListener> listenerMock;

        #endregion

        #region Initialize

        [TestInitialize]
        public void Initialize()
        {
            this.listenerMock = new Mock<IListener>();
            this.mainModule = new SerfidCore(this.listenerMock.Object);
        }

        #endregion

        #region Cleanup

        [TestCleanup]
        public void Cleanup()
        {
            this.mainModule = null;
            this.listenerMock = null;
        }

        #endregion

        #region Test methods

        [TestMethod]
        public void LoadApplication()
        {
            //Arrange
            this.listenerMock.Setup(l => l.start());

            //Act
            this.mainModule.AppStart();

            //Assert
            this.listenerMock.VerifyAll();
        }

        #endregion
    }
}
