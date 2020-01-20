using System.Collections;
using System.Collections.Generic;
using Assert = UnityEngine.Assertions.Assert;
using NUnit.Framework;

public class TestRunnerTestTest
{
    [Test]
    public void GetTextTest()
    {
        //TestRunnerTest script = new TestRunnerTest();
        string a = TestRunnerTest.GetText(1);

        Assert.AreEqual(a, "id:1");
    }

}
