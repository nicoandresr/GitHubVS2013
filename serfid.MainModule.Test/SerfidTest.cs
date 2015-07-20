using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using serfid.Interfaces.Filter;
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
        private Mock<IFilter> filterMock;

        #endregion

        #region Initialize

        [TestInitialize]
        public void Initialize()
        {
            this.listenerMock = new Mock<IListener>();
            this.filterMock = new Mock<IFilter>();
            this.mainModule = new SerfidCore(this.listenerMock.Object, this.filterMock.Object);
        }

        #endregion

        #region Cleanup

        [TestCleanup]
        public void Cleanup()
        {
            this.mainModule = null;
            this.listenerMock = null;
            this.filterMock = null;
        }

        #endregion

        #region Test methods

        [TestMethod]
        public void LoadApplication()
        {
            //Arrange
            this.listenerMock.Setup(l => l.Start());
            this.filterMock.Setup(l => l.Start());

            //Act
            this.mainModule.AppStart();

            //Assert
            this.listenerMock.VerifyAll();
            this.filterMock.VerifyAll();
        }

        #endregion
    }
}
