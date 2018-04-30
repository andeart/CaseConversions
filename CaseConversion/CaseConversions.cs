using System.Text.RegularExpressions;



namespace Andeart.CaseConversion
{
    public static class CaseConversions
    {
        // camelCase
        public static string ToCamelCase (this string text)
        {
            text = text.Trim ();

            // Remove all non-alphanumerics and capitalise their following character.
            text = Regex.Replace (text, @"([^a-zA-Z\d]+[a-zA-Z])", RemoveAllButLastCapitalised);

            // Remove any remaining non-alphanumerics (i.e. ones that don't have any following characters).
            text = Regex.Replace (text, @"([^a-zA-Z\d])", string.Empty);

            // Un-capitalise first character
            text = UncapitaliseFirstChar (text);

            return text;
        }

        public static string ToPascalCase (this string text)
        {
            text = text.Trim ();

            // Remove all non-alphanumerics and capitalise their following character.
            text = Regex.Replace (text, @"([^a-zA-Z\d]+[a-zA-Z])", RemoveAllButLastCapitalised);

            // Remove any remaining non-alphanumerics (i.e. ones that don't have any following characters).
            text = Regex.Replace (text, @"([^a-zA-Z\d])", string.Empty);

            // Capitalise first character
            text = CapitaliseFirstChar (text);

            return text;
        }

        private static string RemoveAllButLastCapitalised (Match match)
        {
            return RemoveAllButLastCapitalised (match.Groups[1].Value);
        }

        private static string RemoveAllButLastCapitalised (string text)
        {
            text = text.Substring (text.Length - 1);
            text = text.ToUpperInvariant ();
            return text;
        }

        private static string CapitaliseFirstChar (string nonSpacedText)
        {
            nonSpacedText = Regex.Replace (nonSpacedText, @"(^.)", EvaluateCapitaliseString);
            return nonSpacedText;
        }

        private static string EvaluateCapitaliseString (Match match)
        {
            return match.Groups[1].Value.ToUpperInvariant ();
        }

        private static string UncapitaliseFirstChar (string nonSpacedText)
        {
            nonSpacedText = Regex.Replace (nonSpacedText, @"(^.)", EvaluateUncapitaliseString);
            return nonSpacedText;
        }

        private static string EvaluateUncapitaliseString (Match match)
        {
            return match.Groups[1].Value.ToLowerInvariant ();
        }
    }

}