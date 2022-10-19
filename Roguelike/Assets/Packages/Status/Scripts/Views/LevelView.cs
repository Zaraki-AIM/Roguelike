using Common;

namespace Status.Views
{
  public class LevelView:CommonTextView
  {
    private readonly string LevelTextTemplate = $"Lv：";
    public void SetText(string targetText)
    {
        _Text.text = $"{LevelTextTemplate}{targetText}";
    }
  }
}