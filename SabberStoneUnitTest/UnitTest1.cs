using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SabberStone.Model;

namespace SabberStoneUnitTest
{
    [TestClass]
    public class UtilsTest
    {
        [TestMethod]
        public void UtilsTestGetDiscoverSets()
        {
            var result1 = Util.GetDiscoverSets(new List<int> {1, 2, 3});
            Assert.AreEqual(1, result1.Count());
            var result2 = Util.GetDiscoverSets(new List<int> { 1, 2, 3 , 4});
            Assert.AreEqual(4, result2.Count());
            var result3 = Util.GetDiscoverSets(new List<int> { 1, 2, 3, 4 , 5 });
            Assert.AreEqual(10, result3.Count());
            var result4 = Util.GetDiscoverSets(new List<int> { 1, 2, 3, 4, 5,
                                                               6, 7, 8, 9,10,
                                                              11,12,13,14,15,
                                                              16,17,18,19,20,
                                                              21,22,23,24,25,
                                                              26,27,28,29,30});
            Assert.AreEqual(4060, result4.Count());
        }
    }
}
