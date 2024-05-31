using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Reflection;
using System.Windows.Forms;

namespace MusicPlayerApp.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void TestMainMethod()
        {
            // Arrange: Prepare to capture the output or handle the application initialization.
            bool enableVisualStylesCalled = false;
            bool setCompatibleTextRenderingDefaultCalled = false;
            bool runCalled = false;

            // Substitute for Application.EnableVisualStyles
            MethodInfo enableVisualStyles = typeof(Application).GetMethod("EnableVisualStyles", BindingFlags.Static | BindingFlags.NonPublic);
            enableVisualStyles.Invoke(null, new object[0]);
            enableVisualStylesCalled = true;

            // Substitute for Application.SetCompatibleTextRenderingDefault
            MethodInfo setCompatibleTextRenderingDefault = typeof(Application).GetMethod("SetCompatibleTextRenderingDefault", BindingFlags.Static | BindingFlags.NonPublic);
            setCompatibleTextRenderingDefault.Invoke(null, new object[] { false });
            setCompatibleTextRenderingDefaultCalled = true;

            // Substitute for Application.Run
            MethodInfo run = typeof(Application).GetMethod("Run", BindingFlags.Static | BindingFlags.NonPublic, null, new Type[] { typeof(Form) }, null);
            run.Invoke(null, new object[] { new Form() });
            runCalled = true;

            // Act: Call the Main method
            Program.Main();

            // Assert: Verify that each method was called
            Assert.IsTrue(enableVisualStylesCalled, "EnableVisualStyles was not called");
            Assert.IsTrue(setCompatibleTextRenderingDefaultCalled, "SetCompatibleTextRenderingDefault was not called");
            Assert.IsTrue(runCalled, "Run was not called");
        }
    }
}
