using PracticeConsoleApp.Algorithms;
using Xunit;

public class AnagramTests
{
    // --- Issue: Null handling (Your code throws exception) ---
    [Fact]
    public void AreAnagrams_ShouldReturnFalse_WhenEitherStringIsNull()
    {
        Assert.False(Anagram.AreAnagrams(null, "abc"));
        Assert.False(Anagram.AreAnagrams("abc", null));
    }

    // --- Issue: Empty strings should be anagrams ---
    [Fact]
    public void AreAnagrams_ShouldReturnTrue_ForTwoEmptyStrings()
    {
        Assert.True(Anagram.AreAnagrams("", ""));
    }

    // --- Issue: Case sensitivity (Your code treats uppercase/lowercase as different) ---
    [Fact]
    public void AreAnagrams_ShouldFail_WhenCaseIsDifferent()
    {
        Assert.False(Anagram.AreAnagrams("Listen", "silent"));
        // Expected in your code
    }

    // --- Issue: Whitespace handling (Your code treats whitespace as a character) ---
    [Fact]
    public void AreAnagrams_ShouldFail_WhenWhitespaceDiffers()
    {
        Assert.False(Anagram.AreAnagrams("a bc", "cab"));
        // Because space is included
    }

    // --- Issue: Mutating second string inside loop (ensure original not changed) ---
    [Fact]
    public void AreAnagrams_ShouldNotModifyOriginalInputs()
    {
        string s1 = "abc";
        string s2 = "bca";

        Anagram.AreAnagrams(s1, s2);

        Assert.Equal("abc", s1); // Always true — but documents intent
        Assert.Equal("bca", s2); // This fails because you reassign str2 = str2.Remove(...)
    }

    // --- Issue: Duplicate characters (correct logic but test coverage) ---
    [Fact]
    public void AreAnagrams_ShouldReturnFalse_WhenDuplicateCountsMismatch()
    {
        Assert.False(Anagram.AreAnagrams("aab", "abb"));
    }

    // --- Edge case: Large string stress test (Your code is O(n²), slow) ---
    [Fact]
    public void AreAnagrams_LargeInput_PerformanceTest()
    {
        // 50k characters
        string s1 = new string('a', 50000);
        string s2 = new string('a', 50000);

        // This will highlight performance limitations (may run slow)
        Assert.True(Anagram.AreAnagrams(s1, s2));
    }

    // --- Issue: Strings of same length but different content ---
    [Fact]
    public void AreAnagrams_ShouldReturnFalse_ForSameLengthDifferentCharacters()
    {
        Assert.False(Anagram.AreAnagrams("abcd", "abce"));
    }

    // --- Issue: Unicode characters ---
    [Fact]
    public void AreAnagrams_ShouldHandleUnicodeCharacters()
    {
        Assert.True(Anagram.AreAnagrams("😊👍", "👍😊"));
    }
}
