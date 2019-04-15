using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WinForm;
namespace TestProject
{
    [TestClass]
    public class Form1
    {
        [TestMethod]
        public void CallFbinacciTest()
        {
            int expectedResult = 55;
            WinForm.Form1 FabiForm= new WinForm.Form1();
            Assert.AreEqual(expectedResult, FabiForm.CallFbinacci());
        }
    }
}
