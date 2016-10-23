﻿using NUnit.Framework;
using UnityEngine;
using UnityIO;

public class EnumerationTests : AssertionHelper
{

    [Test]
    [Description("This test looks inside the " + GetFilesTests.UNIT_TEST_LOADING_TEST_ASSETS + " directory and counts the total files. It should be constant")]
    public void EnumerationCount()
    {
        var dir = GetFilesTests.SetupTest();

        int count = 0;
        foreach(var directory in dir)
        {

     
            count++;
        }
        // Test if our count is correct.
        Assert.AreEqual(count, 4, "There should be four files in the testing directory at " + GetFilesTests.UNIT_TEST_LOADING_TEST_ASSETS);
    }
}
