using UnityEngine.UI;
using System.Collections.Generic;

namespace Status.Messaging
{
  public class LevelChange : EventBase, IStatusEventType
  {
    public int IncrementOfLevel;
    public LevelChange(int incrementOfLevel)
    {
      IncrementOfLevel = incrementOfLevel;
    }
  }

  public class SatietyChange : EventBase, IStatusEventType
  {
    public int IncrementOfSatiety;
    public SatietyChange(int incrementOfSatiety)
    {
      IncrementOfSatiety = incrementOfSatiety;
    }
  }

  public class HPChange : EventBase, IStatusEventType
  {
    public int IncrementOfHP;
    public int MaxHP;
    public HPChange(int incrementOfHP,int maxHP)
    {
      IncrementOfHP = incrementOfHP;
      MaxHP = maxHP;
    }
  }
}