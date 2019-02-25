# CaseConversions

**CaseConversions** lets you manipulate strings from one case-styling to another.

## Status
[![travis](https://img.shields.io/travis/andeart/CaseConversions.svg)](https://travis-ci.org/andeart/CaseConversions)<br />
[![github-release](https://img.shields.io/github/release/andeart/CaseConversions.svg)](https://github.com/andeart/CaseConversions/releases/latest)<br/>
[![license](https://img.shields.io/github/license/andeart/CaseConversions.svg)](https://github.com/andeart/CaseConversions/blob/master/LICENSE)

## API
```csharp
// Converts text to camelCase.
string ToCamelCase (this string text);

// Converts text to PascalCase.
string ToPascalCase (this string text);

// Converts text to lower_snake_case.
string ToLowerSnakeCase (this string text);

// Converts text to _underscoreCamelCase.
string ToUnderscoreCamelCase (this string text);
```

## Installation and Usage
Recommended: Install the package via NuGet console.
```powershell
Install-Package Andeart.CaseConversions
```
Optionally, you can instead download [the latest release](https://github.com/andeart/JsonButler/releases/latest) from the Github Releases tab.

## Feedback and Contribution
Please feel free to send in a Pull Request, or drop me an email. Cheers!
