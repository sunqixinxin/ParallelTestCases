using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[assembly: Parallelize(Workers = 0, Scope = ExecutionScope.ClassLevel)]
namespace ParallelTestCases.One
{
    [TestClass]
    [DoNotParallelize]
    public class OneTesting
    {
        [TestMethod]
        public void TestMethod1()
        {
            new Common.TestCaseScenario().DoSomething(string.Format("{0}.{1}", string.Format("{0}.{1}", this.GetType().FullName, new System.Diagnostics.StackTrace().GetFrame(0).GetMethod().Name), new System.Diagnostics.StackTrace().GetFrame(0).GetMethod().Name), 200);
        }

        [TestMethod]
        public void TestMethod2()
        {
            new Common.TestCaseScenario().DoSomething(string.Format("{0}.{1}", this.GetType().FullName, new System.Diagnostics.StackTrace().GetFrame(0).GetMethod().Name), 200);
        }
    }
}
