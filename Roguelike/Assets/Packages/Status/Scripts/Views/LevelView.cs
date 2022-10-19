using Common;

namespace Status.Views
{
  public class LevelView:CommonTextView
  {
    private readonly string LevelTextTemplate = "Lv：";
    public void SetLevel(int nowLevel)
    {
        _Text.text = $"{LevelTextTemplate}{nowLevel.ToString()}";
    }
  }
}