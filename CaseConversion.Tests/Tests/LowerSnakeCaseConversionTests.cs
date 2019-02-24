using System;
using Andeart.CaseConversion;
using Microsoft.VisualStudio.TestTools.UnitTesting;



namespace Andeart.CaseConversionTest
{

    [TestClass]
    public class LowerSnakeCaseConversionTests
    {
        [TestMethod]
        public void ConvertToLowerSnakeCase_From_SimpleWords ()
        {
            Tuple<string, string>[] originalsAndExpectedOutputs =
            {
                new Tuple<string, string> ("CaseConversionTests", "case_conversion_tests"),
                new Tuple<string, string> ("caseConversionTests", "case_conversion_tests"),
                new Tuple<string, string> ("case_conversion_tests", "case_conversion_tests"),
                new Tuple<string, string> ("case_conversionTests", "case_conversion_tests")
            };

            for (int i = 0; i < originalsAndExpectedOutputs.Length; i++)
            {
                string original = originalsAndExpectedOutputs[i].Item1;
                string expectedOutput = originalsAndExpectedOutputs[i].Item2;
                string output = original.ToLowerSnakeCase ();
                Assert.AreEqual (output, expectedOutput, $"Original: {original} // Expected: {expectedOutput} // Output: {output}");
            }
        }

        [TestMethod]
        public void ConvertToLowerSnakeCase_From_Phrases_Periods ()
        {
            Tuple<string, string>[] originalsAndExpectedOutputs =
            {
                new Tuple<string, string> (".CaseConversionTests", "case_conversion_tests"),
                new Tuple<string, string> ("Case.ConversionTests", "case_conversion_tests"),
                new Tuple<string, string> ("CaseConv.ersionTests", "case_conv_ersion_tests"),
                new Tuple<string, string> ("CaseConversionTests.", "case_conversion_tests"),
                new Tuple<string, string> ("..CaseConversionTests", "case_conversion_tests"),
                new Tuple<string, string> ("Case..Conversion...Tests", "case_conversion_tests"),
                new Tuple<string, string> ("Case.Conv.ersionTests", "case_conv_ersion_tests"),
                new Tuple<string, string> ("CaseConversionTests...", "case_conversion_tests")
            };

            for (int i = 0; i < originalsAndExpectedOutputs.Length; i++)
            {
                string original = originalsAndExpectedOutputs[i].Item1;
                string expectedOutput = originalsAndExpectedOutputs[i].Item2;
                string output = original.ToLowerSnakeCase ();
                Assert.AreEqual (output, expectedOutput, $"Original: {original} // Expected: {expectedOutput} // Output: {output}");
            }
        }

        [TestMethod]
        public void ConvertToLowerSnakeCase_From_Phrases_Spaces ()
        {
            Tuple<string, string>[] originalsAndExpectedOutputs =
            {
                new Tuple<string, string> (" CaseConversionTests", "case_conversion_tests"),
                new Tuple<string, string> ("Case ConversionTests", "case_conversion_tests"),
                new Tuple<string, string> ("CaseConv ersionTests", "case_conv_ersion_tests"),
                new Tuple<string, string> ("CaseConversionTests ", "case_conversion_tests"),
                new Tuple<string, string> ("  CaseConversionTests", "case_conversion_tests"),
                new Tuple<string, string> ("Case  Conversion   Tests", "case_conversion_tests"),
                new Tuple<string, string> ("Case Conv ersionTests", "case_conv_ersion_tests"),
                new Tuple<string, string> ("CaseConversionTests   ", "case_conversion_tests")
            };

            for (int i = 0; i < originalsAndExpectedOutputs.Length; i++)
            {
                string original = originalsAndExpectedOutputs[i].Item1;
                string expectedOutput = originalsAndExpectedOutputs[i].Item2;
                string output = original.ToLowerSnakeCase ();
                Assert.AreEqual (output, expectedOutput, $"Original: {original} // Expected: {expectedOutput} // Output: {output}");
            }
        }

        [TestMethod]
        public void ConvertToLowerSnakeCase_From_Phrases_Spaces_VaryingCases ()
        {
            Tuple<string, string>[] originalsAndExpectedOutputs =
            {
                new Tuple<string, string> (" caseConversionTests", "case_conversion_tests"),
                new Tuple<string, string> ("Case conversionTests", "case_conversion_tests"),
                new Tuple<string, string> ("caseConv ersionTests", "case_conv_ersion_tests"),
                new Tuple<string, string> ("caseConversionTests ", "case_conversion_tests"),
                new Tuple<string, string> ("  caseConversionTests", "case_conversion_tests"),
                new Tuple<string, string> ("Case  conversion   Tests", "case_conversion_tests"),
                new Tuple<string, string> ("Case Conv ersionTests", "case_conv_ersion_tests"),
                new Tuple<string, string> ("CaseConversionTests   ", "case_conversion_tests")
            };

            for (int i = 0; i < originalsAndExpectedOutputs.Length; i++)
            {
                string original = originalsAndExpectedOutputs[i].Item1;
                string expectedOutput = originalsAndExpectedOutputs[i].Item2;
                string output = original.ToLowerSnakeCase ();
                Assert.AreEqual (output, expectedOutput, $"Original: {original} // Expected: {expectedOutput} // Output: {output}");
            }
        }
    }

}