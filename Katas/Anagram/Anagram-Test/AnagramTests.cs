using Microsoft.VisualBasic;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace Katas;

public class AnagramTests {
    private Anagram anagram;
    [SetUp]
    public void Setup() {
        anagram = new Anagram();
    }

    [Test]
    public void Anagrams_of_empty_word() {
        var input = "";
        var expected = new List<string>();

        var actual = anagram.GenerateAnagrams(input);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Anagrams_of_one_letter_word() {
        var input = "a";
        var expected = new List<string> { "a" };
        var actual = anagram.GenerateAnagrams(input);

        Assert.That(actual, Is.EqualTo(expected));
    }
}