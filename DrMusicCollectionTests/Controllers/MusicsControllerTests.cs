using Microsoft.VisualStudio.TestTools.UnitTesting;
using DrMusicCollection.Controllers;
using System;
using System.Collections.Generic;
using System.Text;
using ModelLib.Model;

namespace DrMusicCollection.Controllers.Tests
{
    [TestClass()]
    public class MusicsControllerTests
    {
        private MusicsController cntr = new MusicsController();

        [TestInitialize]

        public void BeforeEachMethod()
        {
            cntr = new MusicsController();
        }


        [TestMethod()]
        public void GetTest()
        {
            Assert.AreEqual(2,new List<Music>(cntr.Get()).Count);
        }
    }
}