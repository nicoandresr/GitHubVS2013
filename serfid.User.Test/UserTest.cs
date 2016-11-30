using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using serfid.Interfaces.DataAccess;
using serfid.Interfaces.Enumerations;
using serfid.Interfaces.System;
using serfid.Interfaces.User;
using serfid.Interfaces.ValueObjects;
using serfid.Interfaces.Storage;

namespace serfid.User.Test
{
    [TestClass]
    public class UserTest
    {
        #region Attributes

        private IUser user;
        private Mock<IStorage> dataAccessMock;

        #endregion

        #region Initialize

        [TestInitialize]
        public void Initialize()
        {
            dataAccessMock = new Mock<IStorage>();
            user = new User(dataAccessMock.Object);
        }

        #endregion

        #region Cleanup

        [TestCleanup]
        public void Cleanup()
        {
            user = null;
        }

        #endregion

        #region Test methods

        [TestMethod]
        public void StartUser()
        {
            //Arrange

            //Act
            ModuleStatus result = user.Start();

            //Assert
            Assert.AreEqual(ModuleStatus.success, result);
        }

        [TestMethod]
        public void GetReadings()
        {
            //Arrange
            PagingInfo parameters = new PagingInfo();
            IEnumerable<ReadingLog> response = new List<ReadingLog>();
            dataAccessMock.Setup(d => d.GetReadings(It.IsAny<PagingInfo>())).Returns(response);

            //Act
            IEnumerable<ReadingLog> result = user.GetReadings(parameters);

            //Assert
            dataAccessMock.VerifyAll();
        }

        #endregion
    }
}
