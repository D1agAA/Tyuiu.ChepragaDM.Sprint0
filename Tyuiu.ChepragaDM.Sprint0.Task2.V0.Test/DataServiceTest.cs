using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ChepragaDM.Sprint0.Task2.V0.Lib;

namespace Tyuiu.ChepragaDM.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Dima";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("Привет..., Dima", res);
        }
    }
}
