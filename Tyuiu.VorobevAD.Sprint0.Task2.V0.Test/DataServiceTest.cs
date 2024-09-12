using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.VorobevAD.Sprint0.Task2.V0.Lib

namespace Tyuiu.VorobevAD.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Арсений";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Арсений", res)
        }
    }
}
