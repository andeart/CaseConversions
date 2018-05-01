using System;
using Andeart.CaseConversion;
using Microsoft.VisualStudio.TestTools.UnitTesting;



namespace Andeart.CaseConversionTest
{

    [TestClass]
    public class UnderscoreCamelCaseConversionTests
    {
        [TestMethod]
        public void ConvertToUnderscoreCamelCase_From_SimpleWords ()
        {
            Tuple<string, string>[] originalsAndExpectedOutputs =
            {
                new Tuple<string, string> ("CaseConversionTests", "_caseConversionTests"),
                new Tuple<string, string> ("caseConversionTests", "_caseConversionTests"),
                new Tuple<string, string> ("case_conversion_tests", "_caseConversionTests"),
                new Tuple<string, string> ("case_conversionTests", "_caseConversionTests")
            };

            for (int i = 0; i < originalsAndExpectedOutputs.Length; i++)
            {
                string original = originalsAndExpectedOutputs[i].Item1;
                string expectedOutput = originalsAndExpectedOutputs[i].Item2;
                string output = original.ToUnderscoreCamelCase ();
                Assert.AreEqual (output, expectedOutput, $"Original: {original} // Expected: {expectedOutput} // Output: {output}");
            }
        }

        [TestMethod]
        public void ConvertToUnderscoreCamelCase_From_Phrases_Periods ()
        {
            Tuple<string, string>[] originalsAndExpectedOutputs =
            {
                new Tuple<string, string> (".CaseConversionTests", "_caseConversionTests"),
                new Tuple<string, string> ("Case.ConversionTests", "_caseConversionTests"),
                new Tuple<string, string> ("CaseConv.ersionTests", "_caseConvErsionTests"),
                new Tuple<string, string> ("CaseConversionTests.", "_caseConversionTests"),
                new Tuple<string, string> ("..CaseConversionTests", "_caseConversionTests"),
                new Tuple<string, string> ("Case..Conversion...Tests", "_caseConversionTests"),
                new Tuple<string, string> ("Case.Conv.ersionTests", "_caseConvErsionTests"),
                new Tuple<string, string> ("CaseConversionTests...", "_caseConversionTests")
            };

            for (int i = 0; i < originalsAndExpectedOutputs.Length; i++)
            {
                string original = originalsAndExpectedOutputs[i].Item1;
                string expectedOutput = originalsAndExpectedOutputs[i].Item2;
                string output = original.ToUnderscoreCamelCase ();
                Assert.AreEqual (output, expectedOutput, $"Original: {original} // Expected: {expectedOutput} // Output: {output}");
            }
        }

        [TestMethod]
        public void ConvertToUnderscoreCamelCase_From_Phrases_Spaces ()
        {
            Tuple<string, string>[] originalsAndExpectedOutputs =
            {
                new Tuple<string, string> (" CaseConversionTests", "_caseConversionTests"),
                new Tuple<string, string> ("Case ConversionTests", "_caseConversionTests"),
                new Tuple<string, string> ("CaseConv ersionTests", "_caseConvErsionTests"),
                new Tuple<string, string> ("CaseConversionTests ", "_caseConversionTests"),
                new Tuple<string, string> ("  CaseConversionTests", "_caseConversionTests"),
                new Tuple<string, string> ("Case  Conversion   Tests", "_caseConversionTests"),
                new Tuple<string, string> ("Case Conv ersionTests", "_caseConvErsionTests"),
                new Tuple<string, string> ("CaseConversionTests   ", "_caseConversionTests")
            };

            for (int i = 0; i < originalsAndExpectedOutputs.Length; i++)
            {
                string original = originalsAndExpectedOutputs[i].Item1;
                string expectedOutput = originalsAndExpectedOutputs[i].Item2;
                string output = original.ToUnderscoreCamelCase ();
                Assert.AreEqual (output, expectedOutput, $"Original: {original} // Expected: {expectedOutput} // Output: {output}");
            }
        }

        [TestMethod]
        public void ConvertToUnderscoreCamelCase_From_Phrases_Spaces_VaryingCases ()
        {
            Tuple<string, string>[] originalsAndExpectedOutputs =
            {
                new Tuple<string, string> (" caseConversionTests", "_caseConversionTests"),
                new Tuple<string, string> ("Case conversionTests", "_caseConversionTests"),
                new Tuple<string, string> ("caseConv ersionTests", "_caseConvErsionTests"),
                new Tuple<string, string> ("caseConversionTests ", "_caseConversionTests"),
                new Tuple<string, string> ("  caseConversionTests", "_caseConversionTests"),
                new Tuple<string, string> ("Case  conversion   Tests", "_caseConversionTests"),
                new Tuple<string, string> ("Case Conv ersionTests", "_caseConvErsionTests"),
                new Tuple<string, string> ("CaseConversionTests   ", "_caseConversionTests")
            };

            for (int i = 0; i < originalsAndExpectedOutputs.Length; i++)
            {
                string original = originalsAndExpectedOutputs[i].Item1;
                string expectedOutput = originalsAndExpectedOutputs[i].Item2;
                string output = original.ToUnderscoreCamelCase ();
                Assert.AreEqual (output, expectedOutput, $"Original: {original} // Expected: {expectedOutput} // Output: {output}");
            }
        }
    }

}