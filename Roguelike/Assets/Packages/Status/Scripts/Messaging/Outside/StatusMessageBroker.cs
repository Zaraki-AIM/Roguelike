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

    public class SatietChange : EventBase, IStatusEventType
    {
        public int IncrementOfSatiet;
        public SatietChange(int incrementOfSatiet)
        {
            IncrementOfSatiet = incrementOfSatiet;
        }
    }
}