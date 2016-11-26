using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace serfid.Service.Test
{
    [TestClass]
    public class SerfidServiceTest
    {
        [TestMethod]
        public void CanOpenPort()
        {
            // Arrange

            // Act
            ListenerPort listenerPort = new ListenerPort();
            string result = listenerPort.Open();

            // Assert
            Assert.AreEqual("Success open port: TestArduino", result);
        }
    }
}
