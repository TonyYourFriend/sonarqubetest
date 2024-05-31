using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Windows.Forms;

namespace MusicPlayerApp.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void TestMainMethod()
        {
            // Arrange
            var applicationMock = new Mock<IApplication>();
            Program.ApplicationWrapper = applicationMock.Object;

            // Act
            Program.Main();

            // Assert
            applicationMock.Verify(a => a.EnableVisualStyles(), Times.Once, "EnableVisualStyles was not called");
            applicationMock.Verify(a => a.SetCompatibleTextRenderingDefault(false), Times.Once, "SetCompatibleTextRenderingDefault was not called");
            applicationMock.Verify(a => a.Run(It.IsAny<Form>()), Times.Once, "Run was not called");
        }
    }

    public interface IApplication
    {
        void EnableVisualStyles();
        void SetCompatibleTextRenderingDefault(bool defaultValue);
        void Run(Form mainForm);
    }

    public class ApplicationWrapper : IApplication
    {
        public void EnableVisualStyles()
        {
            Application.EnableVisualStyles();
        }

        public void SetCompatibleTextRenderingDefault(bool defaultValue)
        {
            Application.SetCompatibleTextRenderingDefault(defaultValue);
        }

        public void Run(Form mainForm)
        {
            Application.Run(mainForm);
        }
    }
}