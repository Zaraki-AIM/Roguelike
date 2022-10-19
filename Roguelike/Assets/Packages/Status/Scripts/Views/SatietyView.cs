using Common;

namespace Status.Views
{
  public class SatietyView:CommonTextView
  {
    private readonly string SatietyTextTemplate = "満腹度：";
    public void SetSatiety(int nowSatiety)
    {
        _Text.text = $"{SatietyTextTemplate}{nowSatiety.ToString()}";
    }
  }
}