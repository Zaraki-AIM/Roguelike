using Common;

namespace Status.Views
{
  public class HPView:CommonTextView
  {
    private readonly string HPTextTemplate = "HP：";
    public void SetHP(int nowHP,int maxHP )
    {
        _Text.text = $"{HPTextTemplate}{nowHP.ToString()} / {maxHP.ToString()}";
    }
  }
}