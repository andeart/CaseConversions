using System;
using Andeart.CaseConversion;
using Microsoft.VisualStudio.TestTools.UnitTesting;



namespace Andeart.CaseConversionTest
{

    [TestClass]
    public class PascalCaseConversionTests
    {
        [TestMethod]
        public void ConvertToPascalCase_From_SimpleWords ()
        {
            Tuple<string, string>[] originalsAndExpectedOutputs =
            {
                new Tuple<string, string> ("CaseConversionTests", "CaseConversionTests"),
                new Tuple<string, string> ("caseConversionTests", "CaseConversionTests"),
                new Tuple<string, string> ("case_conversion_tests", "CaseConversionTests"),
                new Tuple<string, string> ("case_conversionTests", "CaseConversionTests")
            };

            for (int i = 0; i < originalsAndExpectedOutputs.Length; i++)
            {
                string original = originalsAndExpectedOutputs[i].Item1;
                string expectedOutput = originalsAndExpectedOutputs[i].Item2;
                string output = original.ToPascalCase ();
                Assert.AreEqual (output, expectedOutput, $"Original: {original} // Expected: {expectedOutput} // Output: {output}");
            }
        }

        [TestMethod]
        public void ConvertToPascalCase_From_Phrases_Periods ()
        {
            Tuple<string, string>[] originalsAndExpectedOutputs =
            {
                new Tuple<string, string> (".CaseConversionTests", "CaseConversionTests"),
                new Tuple<string, string> ("Case.ConversionTests", "CaseConversionTests"),
                new Tuple<string, string> ("CaseConv.ersionTests", "CaseConvErsionTests"),
                new Tuple<string, string> ("CaseConversionTests.", "CaseConversionTests"),
                new Tuple<string, string> ("..CaseConversionTests", "CaseConversionTests"),
                new Tuple<string, string> ("Case..Conversion...Tests", "CaseConversionTests"),
                new Tuple<string, string> ("Case.Conv.ersionTests", "CaseConvErsionTests"),
                new Tuple<string, string> ("CaseConversionTests...", "CaseConversionTests")
            };

            for (int i = 0; i < originalsAndExpectedOutputs.Length; i++)
            {
                string original = originalsAndExpectedOutputs[i].Item1;
                string expectedOutput = originalsAndExpectedOutputs[i].Item2;
                string output = original.ToPascalCase ();
                Assert.AreEqual (output, expectedOutput, $"Original: {original} // Expected: {expectedOutput} // Output: {output}");
            }
        }

        [TestMethod]
        public void ConvertToPascalCase_From_Phrases_Spaces ()
        {
            Tuple<string, string>[] originalsAndExpectedOutputs =
            {
                new Tuple<string, string> (" CaseConversionTests", "CaseConversionTests"),
                new Tuple<string, string> ("Case ConversionTests", "CaseConversionTests"),
                new Tuple<string, string> ("CaseConv ersionTests", "CaseConvErsionTests"),
                new Tuple<string, string> ("CaseConversionTests ", "CaseConversionTests"),
                new Tuple<string, string> ("  CaseConversionTests", "CaseConversionTests"),
                new Tuple<string, string> ("Case  Conversion   Tests", "CaseConversionTests"),
                new Tuple<string, string> ("Case Conv ersionTests", "CaseConvErsionTests"),
                new Tuple<string, string> ("CaseConversionTests   ", "CaseConversionTests")
            };

            for (int i = 0; i < originalsAndExpectedOutputs.Length; i++)
            {
                string original = originalsAndExpectedOutputs[i].Item1;
                string expectedOutput = originalsAndExpectedOutputs[i].Item2;
                string output = original.ToPascalCase ();
                Assert.AreEqual (output, expectedOutput, $"Original: {original} // Expected: {expectedOutput} // Output: {output}");
            }
        }

        [TestMethod]
        public void ConvertToPascalCase_From_Phrases_Spaces_VaryingCases ()
        {
            Tuple<string, string>[] originalsAndExpectedOutputs =
            {
                new Tuple<string, string> (" caseConversionTests", "CaseConversionTests"),
                new Tuple<string, string> ("Case conversionTests", "CaseConversionTests"),
                new Tuple<string, string> ("caseConv ersionTests", "CaseConvErsionTests"),
                new Tuple<string, string> ("caseConversionTests ", "CaseConversionTests"),
                new Tuple<string, string> ("  caseConversionTests", "CaseConversionTests"),
                new Tuple<string, string> ("Case  conversion   Tests", "CaseConversionTests"),
                new Tuple<string, string> ("Case Conv ersionTests", "CaseConvErsionTests"),
                new Tuple<string, string> ("CaseConversionTests   ", "CaseConversionTests")
            };

            for (int i = 0; i < originalsAndExpectedOutputs.Length; i++)
            {
                string original = originalsAndExpectedOutputs[i].Item1;
                string expectedOutput = originalsAndExpectedOutputs[i].Item2;
                string output = original.ToPascalCase ();
                Assert.AreEqual (output, expectedOutput, $"Original: {original} // Expected: {expectedOutput} // Output: {output}");
            }
        }
    }

}