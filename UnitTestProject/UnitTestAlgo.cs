using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using ClassLibrary;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTestAlgo
    {
        [TestMethod]
        public void TestMethodBasic()
        {
            TestAdd(1, 1);
        }

        [TestMethod]
        public void TestMethodAdvanced()
        {
            var listA = new List<int> { 1, 3, 5, 7, 9 };
            var listB = new List<int> { 0, 2, 4, 6, 8 };

            foreach (var pair in Enumerable.Zip(listA, listB, (a, b) => new KeyValuePair<int, int>(a, b)))
            {
                TestAdd(pair.Key, pair.Value);
            }
        }

        [TestMethod]
        public void TestMethodRandom()
        {
            var random = new Random();
            foreach (var count in Enumerable.Range(0, 10))
            {
                TestAdd(random.Next(), random.Next());
            }
        }

        public static void TestAdd(int a, int b)
        {
            int result = Algo.Add(a, b);
            Assert.IsTrue(a + b == result, $"{a} + {b}!={result}");
        }
    }
}
