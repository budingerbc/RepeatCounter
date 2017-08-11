using System;
using System.Text;

namespace RepeatCounterApp.Models
{
  public class RepeatCounter
  {
    public int CountRepeats(string word, string sentence)
    {
      if(word.Length == 0 || sentence.Length == 0)
      {
        return 0;
      }
      else
      {
        // Setting up the counter for keeping track of number of matched words
        int count = 0;
        // If multiple words are entered, only takes the first word, split on whitespace
        word = word.Split(' ')[0];
        // Strips the punctuation from both the word and sentence
        word = RemovePunctuation(word);
        sentence = RemovePunctuation(sentence);
        // Splits the words in the sentence into an array of strings
        string[] splitWords = sentence.Split(' ');
        // Checks to see if the formatted word matches and incremends the count if so
        foreach(string match in splitWords)
        {
          if (word == match)
            count++;
        }
        return count;
      }
    }

    public string RemovePunctuation(string sentence)
    {
      // Setting up a StringBuilder to strip punctuation out of the the submitted sentence
      StringBuilder strippedSentence = new StringBuilder();
      // Looping through each character in the sentence
      foreach (char c in sentence)
      {
        // If the character is not punctation, append it to the StringBuilder object
        if (!char.IsPunctuation(c))
          strippedSentence.Append(c);
      }
      // Converting our formatted StringBuilder back into a string and returning it
      return strippedSentence.ToString();
    }
  }
}
