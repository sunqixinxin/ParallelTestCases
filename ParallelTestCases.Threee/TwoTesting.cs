﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ParallelTestCases.Threee
{
    [TestClass]
    public class TwoTesting
    {
        [TestMethod]
        public void TestMethod1()
        {
            new Common.TestCaseScenario().DoSomething(string.Format("{0}.{1}", this.GetType().FullName, new System.Diagnostics.StackTrace().GetFrame(0).GetMethod().Name), 20);
        }

        [TestMethod]
        public void TestMethod2()
        {
            new Common.TestCaseScenario().DoSomething(string.Format("{0}.{1}", this.GetType().FullName, new System.Diagnostics.StackTrace().GetFrame(0).GetMethod().Name), 20);
        }
    }
}
