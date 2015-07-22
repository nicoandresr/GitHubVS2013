using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using serfid.Interfaces.DataAccess;
using serfid.Interfaces.Enumerations;
using serfid.Interfaces.System;
using serfid.Interfaces.User;
using serfid.Interfaces.ValueObjects;

namespace serfid.User.Test
{
    [TestClass]
    public class UserTest
    {
        #region Attributes

        private IUser user;
        private Mock<ISerfidDataAccess> dataAccessMock;

        #endregion

        #region Initialize

        [TestInitialize]
        public void Initialize()
        {
            this.dataAccessMock = new Mock<ISerfidDataAccess>();
            this.user = new User(this.dataAccessMock.Object);
        }

        #endregion

        #region Cleanup

        [TestCleanup]
        public void Cleanup()
        {
            this.user = null;
        }

        #endregion

        #region Test methods

        [TestMethod]
        public void StartUser()
        {
            //Arrange

            //Act
            ModuleStatus result = this.user.Start();

            //Assert
            Assert.AreEqual(ModuleStatus.success, result);
        }

        [TestMethod]
        public void GetReadings()
        {
            //Arrange
            PagingInfo parameters = new PagingInfo();
            List<ReadingInfo> response = new List<ReadingInfo>();
            this.dataAccessMock.Setup(d => d.GetReadings(It.IsAny<PagingInfo>())).Returns(response);

            //Act
            List<ReadingInfo> result = this.user.GetReadings(parameters);

            //Assert
            this.dataAccessMock.VerifyAll();
        }

        #endregion
    }
}
