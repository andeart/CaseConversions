using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace Andeart.CaseConversions.Tests
{

    [TestClass]
    public class CamelCaseConversionTests
    {
        [TestMethod]
        public void ConvertToCamelCase_From_SimpleWords ()
        {
            Tuple<string, string>[] originalsAndExpectedOutputs =
            {
                new Tuple<string, string> ("CaseConversionTests", "caseConversionTests"),
                new Tuple<string, string> ("caseConversionTests", "caseConversionTests"),
                new Tuple<string, string> ("case_conversion_tests", "caseConversionTests"),
                new Tuple<string, string> ("case_conversionTests", "caseConversionTests")
            };

            for (int i = 0; i < originalsAndExpectedOutputs.Length; i++)
            {
                string original = originalsAndExpectedOutputs[i].Item1;
                string expectedOutput = originalsAndExpectedOutputs[i].Item2;
                string output = original.ToCamelCase ();
                Assert.AreEqual (output, expectedOutput, $"Original: {original} // Expected: {expectedOutput} // Output: {output}");
            }
        }

        [TestMethod]
        public void ConvertToCamelCase_From_Phrases_Periods ()
        {
            Tuple<string, string>[] originalsAndExpectedOutputs =
            {
                new Tuple<string, string> (".CaseConversionTests", "caseConversionTests"),
                new Tuple<string, string> ("Case.ConversionTests", "caseConversionTests"),
                new Tuple<string, string> ("CaseConv.ersionTests", "caseConvErsionTests"),
                new Tuple<string, string> ("CaseConversionTests.", "caseConversionTests"),
                new Tuple<string, string> ("..CaseConversionTests", "caseConversionTests"),
                new Tuple<string, string> ("Case..Conversion...Tests", "caseConversionTests"),
                new Tuple<string, string> ("Case.Conv.ersionTests", "caseConvErsionTests"),
                new Tuple<string, string> ("CaseConversionTests...", "caseConversionTests")
            };

            for (int i = 0; i < originalsAndExpectedOutputs.Length; i++)
            {
                string original = originalsAndExpectedOutputs[i].Item1;
                string expectedOutput = originalsAndExpectedOutputs[i].Item2;
                string output = original.ToCamelCase ();
                Assert.AreEqual (output, expectedOutput, $"Original: {original} // Expected: {expectedOutput} // Output: {output}");
            }
        }

        [TestMethod]
        public void ConvertToCamelCase_From_Phrases_Spaces ()
        {
            Tuple<string, string>[] originalsAndExpectedOutputs =
            {
                new Tuple<string, string> (" CaseConversionTests", "caseConversionTests"),
                new Tuple<string, string> ("Case ConversionTests", "caseConversionTests"),
                new Tuple<string, string> ("CaseConv ersionTests", "caseConvErsionTests"),
                new Tuple<string, string> ("CaseConversionTests ", "caseConversionTests"),
                new Tuple<string, string> ("  CaseConversionTests", "caseConversionTests"),
                new Tuple<string, string> ("Case  Conversion   Tests", "caseConversionTests"),
                new Tuple<string, string> ("Case Conv ersionTests", "caseConvErsionTests"),
                new Tuple<string, string> ("CaseConversionTests   ", "caseConversionTests")
            };

            for (int i = 0; i < originalsAndExpectedOutputs.Length; i++)
            {
                string original = originalsAndExpectedOutputs[i].Item1;
                string expectedOutput = originalsAndExpectedOutputs[i].Item2;
                string output = original.ToCamelCase ();
                Assert.AreEqual (output, expectedOutput, $"Original: {original} // Expected: {expectedOutput} // Output: {output}");
            }
        }

        [TestMethod]
        public void ConvertToCamelCase_From_Phrases_Spaces_VaryingCases ()
        {
            Tuple<string, string>[] originalsAndExpectedOutputs =
            {
                new Tuple<string, string> (" caseConversionTests", "caseConversionTests"),
                new Tuple<string, string> ("Case conversionTests", "caseConversionTests"),
                new Tuple<string, string> ("caseConv ersionTests", "caseConvErsionTests"),
                new Tuple<string, string> ("caseConversionTests ", "caseConversionTests"),
                new Tuple<string, string> ("  caseConversionTests", "caseConversionTests"),
                new Tuple<string, string> ("Case  conversion   Tests", "caseConversionTests"),
                new Tuple<string, string> ("Case Conv ersionTests", "caseConvErsionTests"),
                new Tuple<string, string> ("CaseConversionTests   ", "caseConversionTests")
            };

            for (int i = 0; i < originalsAndExpectedOutputs.Length; i++)
            {
                string original = originalsAndExpectedOutputs[i].Item1;
                string expectedOutput = originalsAndExpectedOutputs[i].Item2;
                string output = original.ToCamelCase ();
                Assert.AreEqual (output, expectedOutput, $"Original: {original} // Expected: {expectedOutput} // Output: {output}");
            }
        }
    }

}