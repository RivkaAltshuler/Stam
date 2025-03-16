using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Tests
{
    [TestClass()]
    public class ShelvingUnitTests
    {
        [TestMethod()]
        public void Cenario1()
        {
            //stam
            //stam
			  //stam
            var a = new ShelvingUnit();
            var cell = a.Allocate_Cell(new Product("bread"), 2);
            Assert.IsNotNull(cell);
            Assert.AreEqual(new Tuple<int, int>(0, 0), cell);

            cell = a.Allocate_Cell(new Product("bamba"), 6);
            Assert.IsNotNull(cell);
            Assert.AreEqual(new Tuple<int, int>(0, 1), cell);
        }

        [TestMethod()]
        public void Cenario2()
        {
            var a = new ShelvingUnit();
            var cell = a.Allocate_Cell(new ChilledProduct("yogurt"), 2);
            Assert.IsNotNull(cell);
            Assert.AreEqual(new Tuple<int, int>(7, 7), cell);

  
        }

        [TestMethod()]
        public void Cenario3()
        {
            var a = new ShelvingUnit();
            var cell = a.Allocate_Cell(new ChilledProduct("apple"), 11);
            Assert.IsNull(cell);


        }

        [TestMethod()]
        public void Cenario4()
        {
            var a = new ShelvingUnit();
            var cell = a.Allocate_Cell(new HazardousProduct("stain removal"), 7);
            Assert.IsNotNull(cell);
            Assert.AreEqual(new Tuple<int, int>(0, 9), cell);


        }

        [TestMethod()]
        public void Cenario5()
        {
            var a = new ShelvingUnit();
            var cell = a.Allocate_Cell(new ChilledProduct("insulin"), 10);
            Assert.IsNotNull(cell);
            Assert.AreEqual(new Tuple<int, int>(7, 7), cell);


        }

        //more

        [TestMethod()]
        public void Cenario6()
        {
            var a = new ShelvingUnit();
            var cell = a.Allocate_Cell(new Product("bread"), 4);
            Assert.IsNotNull(cell);
            Assert.AreEqual(new Tuple<int, int>(0, 0), cell);
             cell = a.Allocate_Cell(new Product("bread"), 4);
            Assert.IsNotNull(cell);
            Assert.AreEqual(new Tuple<int, int>(0, 0), cell);

            cell = a.Allocate_Cell(new Product("bread"), 4);
            Assert.IsNotNull(cell);
            Assert.AreEqual(new Tuple<int, int>(0, 1), cell);


        }



    }
}