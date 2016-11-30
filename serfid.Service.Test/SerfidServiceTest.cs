using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace serfid.Service.Test
{
    [TestClass]
    public class SerfidServiceTest
    {
        #region Fields
        private ListenerPort _targetPort;
        #endregion

        #region Test initialize
        [TestInitialize]
        public void TestInitialize()
        {
            _targetPort = new ListenerPort();
        }
        #endregion

        #region Test cleanup
        [TestCleanup]
        public void TestCleanUp()
        {
            _targetPort = null;
        }
        #endregion

        #region Tests
        //[TestMethod]
        public void CanOpenPort()
        {
            // Arrange

            // Act
            string result = _targetPort.Open();

            // Assert
            Assert.AreEqual("Success open port: TestArduino", result);
        }

        //[TestMethod]
        public void CanListenInPort()
        {
            // Arrange

            // Act
            string result = _targetPort.Read();

            // Assert
            Assert.AreNotEqual(string.Empty, result);
        }
        #endregion
    }
}
