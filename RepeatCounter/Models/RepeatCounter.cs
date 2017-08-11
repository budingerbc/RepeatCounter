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
        return -1;
      }
    }
  }
}
