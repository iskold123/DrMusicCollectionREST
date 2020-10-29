using Microsoft.VisualStudio.TestTools.UnitTesting;
using DrMusicCollection.Controllers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
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
       
        [TestMethod()]
        public void GetArtistTest()
        {
            IEnumerable<Music> list = cntr.GetFromSubstring("Tessa");

            Assert.AreEqual(1,list.ToArray().Length);
        }

    }
}