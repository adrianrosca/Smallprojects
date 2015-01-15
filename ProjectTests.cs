using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Smallprojects
{
    [TestClass]
    public class ProjectTests
    {
        [TestMethod]
        public void ProjectCreate()
        {
            Assert.IsTrue(true, "Small project created");
        }


        [TestMethod]
        public void ProjectLoad()
        {
            Assert.IsTrue(false, "Small project loaded");
        }
    }
}
